
namespace Intel_8085
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AXRegisterTextBox = new System.Windows.Forms.TextBox();
            this.ARegisterLabel = new System.Windows.Forms.Label();
            this.Registers = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HighRegisters = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LowRegisters = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FirstRegisterComboBox = new System.Windows.Forms.ComboBox();
            this.ExchangeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RandomButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SecondRegisterComboBox = new System.Windows.Forms.ComboBox();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.Registers.SuspendLayout();
            this.HighRegisters.SuspendLayout();
            this.LowRegisters.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AXRegisterTextBox
            // 
            this.AXRegisterTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AXRegisterTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AXRegisterTextBox.Location = new System.Drawing.Point(42, 44);
            this.AXRegisterTextBox.Name = "AXRegisterTextBox";
            this.AXRegisterTextBox.ReadOnly = true;
            this.AXRegisterTextBox.Size = new System.Drawing.Size(66, 23);
            this.AXRegisterTextBox.TabIndex = 3;
            // 
            // ARegisterLabel
            // 
            this.ARegisterLabel.AutoSize = true;
            this.ARegisterLabel.ForeColor = System.Drawing.Color.Black;
            this.ARegisterLabel.Location = new System.Drawing.Point(14, 18);
            this.ARegisterLabel.Name = "ARegisterLabel";
            this.ARegisterLabel.Size = new System.Drawing.Size(22, 15);
            this.ARegisterLabel.TabIndex = 1;
            this.ARegisterLabel.Text = "AX";
            // 
            // Registers
            // 
            this.Registers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Registers.Controls.Add(this.label3);
            this.Registers.Controls.Add(this.textBox3);
            this.Registers.Controls.Add(this.label2);
            this.Registers.Controls.Add(this.AXRegisterTextBox);
            this.Registers.Controls.Add(this.textBox2);
            this.Registers.Controls.Add(this.textBox1);
            this.Registers.Controls.Add(this.label1);
            this.Registers.Controls.Add(this.ARegisterLabel);
            this.Registers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Registers.ForeColor = System.Drawing.Color.Black;
            this.Registers.Location = new System.Drawing.Point(607, 65);
            this.Registers.MinimumSize = new System.Drawing.Size(100, 100);
            this.Registers.Name = "Registers";
            this.Registers.Size = new System.Drawing.Size(235, 304);
            this.Registers.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "DX";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Location = new System.Drawing.Point(42, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(66, 23);
            this.textBox3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "CX";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(42, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(66, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(42, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(66, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "BX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "AX";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(28, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(83, 23);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "AX";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(28, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(83, 23);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(28, 73);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(83, 23);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(28, 102);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(83, 23);
            this.textBox7.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "AX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "AX";
            // 
            // HighRegisters
            // 
            this.HighRegisters.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HighRegisters.Controls.Add(this.label12);
            this.HighRegisters.Controls.Add(this.textBox12);
            this.HighRegisters.Controls.Add(this.label13);
            this.HighRegisters.Controls.Add(this.textBox13);
            this.HighRegisters.Controls.Add(this.textBox14);
            this.HighRegisters.Controls.Add(this.textBox15);
            this.HighRegisters.Controls.Add(this.label14);
            this.HighRegisters.Controls.Add(this.label15);
            this.HighRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HighRegisters.ForeColor = System.Drawing.Color.Black;
            this.HighRegisters.Location = new System.Drawing.Point(367, 65);
            this.HighRegisters.MinimumSize = new System.Drawing.Size(100, 100);
            this.HighRegisters.Name = "HighRegisters";
            this.HighRegisters.Size = new System.Drawing.Size(114, 304);
            this.HighRegisters.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(14, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "DH";
            // 
            // textBox12
            // 
            this.textBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox12.Location = new System.Drawing.Point(42, 15);
            this.textBox12.MaxLength = 2;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(38, 23);
            this.textBox12.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(14, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "CH";
            // 
            // textBox13
            // 
            this.textBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox13.Location = new System.Drawing.Point(42, 44);
            this.textBox13.MaxLength = 2;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(38, 23);
            this.textBox13.TabIndex = 12;
            // 
            // textBox14
            // 
            this.textBox14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox14.Location = new System.Drawing.Point(42, 73);
            this.textBox14.MaxLength = 2;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(38, 23);
            this.textBox14.TabIndex = 11;
            // 
            // textBox15
            // 
            this.textBox15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox15.Location = new System.Drawing.Point(42, 102);
            this.textBox15.MaxLength = 2;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(38, 23);
            this.textBox15.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(14, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "BH";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(14, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "AH";
            // 
            // LowRegisters
            // 
            this.LowRegisters.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LowRegisters.Controls.Add(this.label8);
            this.LowRegisters.Controls.Add(this.textBox8);
            this.LowRegisters.Controls.Add(this.label9);
            this.LowRegisters.Controls.Add(this.textBox9);
            this.LowRegisters.Controls.Add(this.textBox10);
            this.LowRegisters.Controls.Add(this.textBox11);
            this.LowRegisters.Controls.Add(this.label10);
            this.LowRegisters.Controls.Add(this.label11);
            this.LowRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LowRegisters.ForeColor = System.Drawing.Color.Black;
            this.LowRegisters.Location = new System.Drawing.Point(487, 65);
            this.LowRegisters.MinimumSize = new System.Drawing.Size(100, 100);
            this.LowRegisters.Name = "LowRegisters";
            this.LowRegisters.Size = new System.Drawing.Size(114, 304);
            this.LowRegisters.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "DL";
            // 
            // textBox8
            // 
            this.textBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox8.Location = new System.Drawing.Point(42, 15);
            this.textBox8.MaxLength = 2;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(38, 23);
            this.textBox8.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "CL";
            // 
            // textBox9
            // 
            this.textBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox9.Location = new System.Drawing.Point(42, 44);
            this.textBox9.MaxLength = 2;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(38, 23);
            this.textBox9.TabIndex = 12;
            // 
            // textBox10
            // 
            this.textBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox10.Location = new System.Drawing.Point(42, 73);
            this.textBox10.MaxLength = 2;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(38, 23);
            this.textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox11.Location = new System.Drawing.Point(42, 102);
            this.textBox11.MaxLength = 2;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(38, 23);
            this.textBox11.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(14, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "BL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(14, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "AL";
            // 
            // FirstRegisterComboBox
            // 
            this.FirstRegisterComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstRegisterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstRegisterComboBox.FormattingEnabled = true;
            this.FirstRegisterComboBox.Location = new System.Drawing.Point(367, 375);
            this.FirstRegisterComboBox.Name = "FirstRegisterComboBox";
            this.FirstRegisterComboBox.Size = new System.Drawing.Size(114, 23);
            this.FirstRegisterComboBox.TabIndex = 20;
            // 
            // ExchangeButton
            // 
            this.ExchangeButton.Location = new System.Drawing.Point(15, 142);
            this.ExchangeButton.Margin = new System.Windows.Forms.Padding(10);
            this.ExchangeButton.Name = "ExchangeButton";
            this.ExchangeButton.Padding = new System.Windows.Forms.Padding(10);
            this.ExchangeButton.Size = new System.Drawing.Size(209, 49);
            this.ExchangeButton.TabIndex = 21;
            this.ExchangeButton.Text = "Exchange";
            this.ExchangeButton.UseVisualStyleBackColor = true;
            this.ExchangeButton.Click += new System.EventHandler(this.ExchangeButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.RandomButton);
            this.panel3.Controls.Add(this.ResetButton);
            this.panel3.Controls.Add(this.MoveButton);
            this.panel3.Controls.Add(this.ExchangeButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(126, 65);
            this.panel3.MinimumSize = new System.Drawing.Size(100, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 304);
            this.panel3.TabIndex = 22;
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(15, 29);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(10);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Padding = new System.Windows.Forms.Padding(10);
            this.RandomButton.Size = new System.Drawing.Size(209, 53);
            this.RandomButton.TabIndex = 24;
            this.RandomButton.Text = "Random";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(15, 197);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(10);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Padding = new System.Windows.Forms.Padding(10);
            this.ResetButton.Size = new System.Drawing.Size(209, 50);
            this.ResetButton.TabIndex = 23;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(15, 88);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(10);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Padding = new System.Windows.Forms.Padding(10);
            this.MoveButton.Size = new System.Drawing.Size(209, 48);
            this.MoveButton.TabIndex = 22;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.LowRegisters, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.HighRegisters, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Registers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SecondRegisterComboBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ErrorMessage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FirstRegisterComboBox, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 620);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // SecondRegisterComboBox
            // 
            this.SecondRegisterComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondRegisterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondRegisterComboBox.FormattingEnabled = true;
            this.SecondRegisterComboBox.Location = new System.Drawing.Point(487, 375);
            this.SecondRegisterComboBox.Name = "SecondRegisterComboBox";
            this.SecondRegisterComboBox.Size = new System.Drawing.Size(114, 23);
            this.SecondRegisterComboBox.TabIndex = 23;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorMessage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorMessage.ForeColor = System.Drawing.Color.LightCoral;
            this.ErrorMessage.Location = new System.Drawing.Point(607, 372);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorMessage.Size = new System.Drawing.Size(235, 28);
            this.ErrorMessage.TabIndex = 24;
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(965, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Registers.ResumeLayout(false);
            this.Registers.PerformLayout();
            this.HighRegisters.ResumeLayout(false);
            this.HighRegisters.PerformLayout();
            this.LowRegisters.ResumeLayout(false);
            this.LowRegisters.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AXRegisterTextBox;
        private System.Windows.Forms.Label ARegisterLabel;
        private System.Windows.Forms.Panel Registers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel HighRegisters;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel LowRegisters;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox FirstRegisterComboBox;
        private System.Windows.Forms.Button ExchangeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox SecondRegisterComboBox;
        private System.Windows.Forms.Label ErrorMessage;
    }
}

