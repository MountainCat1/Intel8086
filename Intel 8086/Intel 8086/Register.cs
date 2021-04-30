using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Intel_8085
{
    class Register
    {
        public static List<Register> AllRegisters = new List<Register>();

        /// Properties
        /// 
        private TextBox hightRegisterInput;
        private TextBox lowRegisterInput;

        public TextBox HightRegisterInput { 
            get => hightRegisterInput;
            set { 
                if(hightRegisterInput != null)
                    hightRegisterInput.TextChanged -= TextChanged;

                hightRegisterInput = value;
                hightRegisterInput.TextChanged += TextChanged;
            }
        }
        public TextBox LowRegisterInput { 
            get => lowRegisterInput;
            set {
                if (lowRegisterInput != null)
                    lowRegisterInput.TextChanged -= TextChanged;

                lowRegisterInput = value;
                lowRegisterInput.TextChanged += TextChanged;
            }
        }
        public TextBox RegisterDisplay {
            get; set;
        }

        public string Name { get; set; } 

        public string Value { get => HightRegisterInput.Text + LowRegisterInput.Text; }

        /// Methods
        /// 
        public Register(string name, bool addToAllRegisters = true) {
            Name = name;

            if(addToAllRegisters)
                AllRegisters.Add(this);
        }
        ~Register() {
            AllRegisters.Remove(this);
        }

        public override string ToString() {
            return Name;
        }

        public void Randomize() {
            char[] lowRegister = { GetRandomRegisterCharacter(), GetRandomRegisterCharacter() };
            LowRegisterInput.Text = new string(lowRegister);
            char[] hightRegister = { GetRandomRegisterCharacter(), GetRandomRegisterCharacter() };
            HightRegisterInput.Text = new string(hightRegister);
        }

        public void Set(string value) {
            if (value.Length > 4 || value.Length == 0)
                throw new Exception("Register value has to have length of 4");

            hightRegisterInput.Text = value.Substring(0, 2);
            lowRegisterInput.Text = value.Substring(1, 2);
        }

        private char GetRandomRegisterCharacter() {
            Random prng = new Random();

            char letter;
            double flt = prng.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(16 * flt));
            int ascii;
            if (shift < 10)
            {
                ascii = '0' + (shift);
            } else
            {
                ascii = shift + 65 - 10;
            }

            letter = Convert.ToChar(ascii);

            return letter;
        }

        private void TextChanged(object sender, EventArgs e) {
            if(HightRegisterInput.Text.Length == 2 && LowRegisterInput.Text.Length == 2) {
                RegisterDisplay.Text = HightRegisterInput.Text + LowRegisterInput.Text;
            }
        }

    }
}
