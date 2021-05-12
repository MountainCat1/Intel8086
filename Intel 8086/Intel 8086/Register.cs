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
        public SubRegister HightRegister { get; set; }
        public SubRegister LowRegister { get; set; }
        public TextBox RegisterDisplay {
            get; set;
        }

        public string Name { get; set; } 

        public string Value { get => value;}
        private string value = "0000";

        ///Sub-Classes
        ///
        public class SubRegister
        {
            public Register Register { get; set; }

            private TextBox input;
            public TextBox Input {
                get => input;
                set {
                    if (input != null)
                        input.TextChanged -= Register.TextChanged;

                    input = value;
                    input.TextChanged += Register.TextChanged;
                }
            }
            public string Name { get; set; }
        }

        /// Methods
        /// 
        public Register(string name, bool addToAllRegisters = true) {
            Name = name;

            LowRegister = new SubRegister() { Name = "L", Register = this };
            HightRegister = new SubRegister() { Name = "H", Register = this };

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
            LowRegister.Input.Text = new string(lowRegister);
            char[] hightRegister = { GetRandomRegisterCharacter(), GetRandomRegisterCharacter() };
            HightRegister.Input.Text = new string(hightRegister);
        }

        public void Reset() {
            LowRegister.Input.Text = "00";
            HightRegister.Input.Text = "00";
        }

        public void Set(string value) {
            if (value.Length != 4)
                throw new Exception("Register value has to have length of 4");

            HightRegister.Input.Text = value.Substring(0, 2);
            LowRegister.Input.Text = value.Substring(2, 2);
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
            if(HightRegister.Input.Text.Length == 2 && LowRegister.Input.Text.Length == 2) {
                value = HightRegister.Input.Text + LowRegister.Input.Text;

                RegisterDisplay.Text = value;
            }
        }

    }
}
