using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8085
{
    public partial class Form1 : Form
    {
        private Register firstRegister;
        private Register secondRegister;

        public Form1() {
            InitializeComponent();

            FirstRegisterComboBox.SelectedValueChanged += FirstRegisterComboBox_SelectedValueChanged;
            SecondRegisterComboBox.SelectedValueChanged += SecondRegisterComboBox_SelectedValueChanged;

            Start();
        }

        private void SecondRegisterComboBox_SelectedValueChanged(object sender, EventArgs e) {
            secondRegister = SecondRegisterComboBox.SelectedItem as Register;
        }

        private void FirstRegisterComboBox_SelectedValueChanged(object sender, EventArgs e) {
            firstRegister = FirstRegisterComboBox.SelectedItem as Register;
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

            Reset();
        }

        private void RandomButton_Click(object sender, EventArgs e) {
            foreach(Register register in Register.AllRegisters)
            {
                register.Randomize();
            }
        }

        private void ExchangeButton_Click(object sender, EventArgs e) {
            if(firstRegister == null || secondRegister == null)
            {
                return;
            }

            string temp = firstRegister.Value;
            firstRegister.Set(secondRegister.Value);
            secondRegister.Set(temp);
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
            if (firstRegister == null || secondRegister == null)
            {
                return;
            }

            firstRegister.Set(secondRegister.Value);
        }
    }
}
