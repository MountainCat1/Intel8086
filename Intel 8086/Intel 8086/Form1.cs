﻿using System;
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
            secondRegister = FirstRegisterComboBox.SelectedItem as Register;
        }

        private void FirstRegisterComboBox_SelectedValueChanged(object sender, EventArgs e) {
            firstRegister = FirstRegisterComboBox.SelectedItem as Register;
        }

        private void Start() {
            Register A = new Register("A");
            Register B = new Register("B");
            Register C = new Register("C");
            Register D = new Register("D");


            int i = 0;
            foreach (var v in Registers.Controls) {
                if(v is TextBox box) {
                    box.Text = Register.AllRegisters[i].Name;
                    i++;
                }
            }

            foreach(Register register in Register.AllRegisters) {
                FirstRegisterComboBox.Items.Add(register);
                SecondRegisterComboBox.Items.Add(register);
            }
        }
    }
}