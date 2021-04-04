using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8085
{
    class Register
    {
        public static List<Register> AllRegisters = new List<Register>();

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

        public string Name { get; set; } 

        public Register(string name) {
            Name = name;
            AllRegisters.Add(this);
        }
        ~Register() {
            AllRegisters.Remove(this);
        }

        public override string ToString() {
            return Name;
        }

        private void TextChanged(object sender, EventArgs e) {
            if(HightRegisterInput.Text.Length == 2 && LowRegisterInput.Text.Length == 2) {

            }
        }

    }
}
