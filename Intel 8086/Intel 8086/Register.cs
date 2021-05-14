using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Intel_8085
{
    class Register
    {
        const string avaliableCharacters = "0123456789ABCDEF";

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

        public bool CorrectRegisters { get; set; } = false;

        ///Sub-Classes
        ///
        public class SubRegister
        {
            public Register Register { get; set; }

            private TextBox input;
            public TextBox Input {
                private get => input;
                set {
                    if (input != null)
                        input.TextChanged -= Register.TextChanged;

                    input = value;
                    input.TextChanged += Register.TextChanged;
                }
            }
            public string Name { get; set; }
            public string Value { get => input.Text; set => Set(value); }

            public override string ToString() {
                return Register.Name + Name;
            }

            public void Set(string value) {
                if (value.Length != 2)
                    throw new Exception("SubRegister value has to have length of 2");

                input.Text = value;
            }
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
            return Name + "X";
        }

        public void Randomize() {
            char[] lowRegister = { GetRandomRegisterCharacter(), GetRandomRegisterCharacter() };
            LowRegister.Value = new string(lowRegister);
            char[] hightRegister = { GetRandomRegisterCharacter(), GetRandomRegisterCharacter() };
            HightRegister.Value = new string(hightRegister);
        }

        public void Reset() {
            LowRegister.Value = "00";
            HightRegister.Value = "00";
        }

        public void Set(string value) {
            if (value.Length != 4)
                throw new Exception("Register value has to have length of 4");

            HightRegister.Value = value.Substring(0, 2);
            LowRegister.Value = value.Substring(2, 2);
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
            if(IsRegisterValueCorrect(HightRegister) && IsRegisterValueCorrect(LowRegister)) {
                value = HightRegister.Value + LowRegister.Value;

                RegisterDisplay.Text = value;
                Form1.instance.ShowError(null);
                CorrectRegisters = true;
            } else
            {
                Form1.instance.ShowError("Niepoprawne wartości rejestrów.");
                CorrectRegisters = false;
            }
        }

        private bool IsRegisterValueCorrect(SubRegister subRegister) {
            string value = subRegister.Value;
            if (value.Length != 2)
                return false;

            foreach (var v in value)
                if (!avaliableCharacters.ToCharArray().Contains(v))
                    return false;

            return true;
        }
    }
}
