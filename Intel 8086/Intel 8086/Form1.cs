using System;
using System.Windows.Forms;

namespace Intel_8085
{
    public partial class Form1 : Form
    {
        private Register firstRegister;
        private Register secondRegister;

        private Register.SubRegister firstSubRegister;
        private Register.SubRegister secondSubRegister;

        public Form1() {
            InitializeComponent();

            FirstRegisterComboBox.SelectedValueChanged += FirstRegisterComboBox_SelectedValueChanged;
            SecondRegisterComboBox.SelectedValueChanged += SecondRegisterComboBox_SelectedValueChanged;

            Start();
        }

        private void SecondRegisterComboBox_SelectedValueChanged(object sender, EventArgs e) {
            secondRegister = null;
            secondSubRegister = null;

            object obj = SecondRegisterComboBox.SelectedItem;


            if (obj is Register)
                secondRegister = obj as Register;
            else if (obj is Register.SubRegister)
                secondSubRegister = obj as Register.SubRegister;
        }

        private void FirstRegisterComboBox_SelectedValueChanged(object sender, EventArgs e) {
            firstRegister = null;
            firstSubRegister = null;

            object obj = FirstRegisterComboBox.SelectedItem;


            if (obj is Register)
                firstRegister = obj as Register;
            else if (obj is Register.SubRegister)
                firstSubRegister = obj as Register.SubRegister;
        }

        private void Start() {
            Register A = new Register("A");
            Register B = new Register("B");
            Register C = new Register("C");
            Register D = new Register("D");


            int i;

            /// Set register displays
            i = 0;
            foreach (var v in Registers.Controls) {
                if(v is TextBox box) {
                    Register.AllRegisters[i].RegisterDisplay = box;
                    box.Text = Register.AllRegisters[i].Name;
                    i++;
                }
            }
            
            /// Set hight registers
            i = 0;
            foreach (var v in HighRegisters.Controls)
            {
                if (v is TextBox box)
                {
                    Register.AllRegisters[i].HightRegister.Input = box;
                    box.Text = Register.AllRegisters[i].Name;
                    i++;
                }
            }

            /// Set Low registers
            i = 0;
            foreach (var v in LowRegisters.Controls)
            {
                if (v is TextBox box)
                {
                    Register.AllRegisters[i].LowRegister.Input = box;
                    box.Text = Register.AllRegisters[i].Name;
                    i++;
                }
            }

            foreach (Register register in Register.AllRegisters) {
                FirstRegisterComboBox.Items.Add(register);
                SecondRegisterComboBox.Items.Add(register);
            }

            foreach (Register register in Register.AllRegisters)
            {
                FirstRegisterComboBox.Items.Add(register.HightRegister);
                FirstRegisterComboBox.Items.Add(register.LowRegister);

                SecondRegisterComboBox.Items.Add(register.HightRegister);
                SecondRegisterComboBox.Items.Add(register.LowRegister);
            }

            Reset();
        }

        private void RandomButton_Click(object sender, EventArgs e) {
            foreach(Register register in Register.AllRegisters)
            {
                register.Randomize();
            }
        }

        private void ExchangeButton_Click(object sender, EventArgs e) {
            if(firstRegister != null && secondRegister != null)
            {
                string temp = firstRegister.Value;
                firstRegister.Set(secondRegister.Value);
                secondRegister.Set(temp);
            }else if (firstSubRegister != null && secondSubRegister != null)
            {
                string temp = firstSubRegister.Value;
                firstSubRegister.Set(secondSubRegister.Value);
                secondSubRegister.Set(temp);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            Reset();
        }

        private void Reset() {
            foreach (Register register in Register.AllRegisters)
            {
                register.Reset();
            }
        }

        private void MoveButton_Click(object sender, EventArgs e) {

            if (firstRegister != null && secondRegister != null)
            {
                firstRegister.Set(secondRegister.Value);
            } else if (firstSubRegister != null && secondSubRegister != null)
            {
                firstSubRegister.Set(secondSubRegister.Value);
            }
        }
    }
}
