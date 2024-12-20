namespace kalkulator
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            amount = new NumericUpDown();
            label1 = new Label();
            groupBox1 = new GroupBox();
            firstCHF = new RadioButton();
            firstNOK = new RadioButton();
            firstEUR = new RadioButton();
            firstUSD = new RadioButton();
            firstPLN = new RadioButton();
            groupBox2 = new GroupBox();
            secondCHF = new RadioButton();
            secondNOK = new RadioButton();
            secondEUR = new RadioButton();
            secondUSD = new RadioButton();
            secondPLN = new RadioButton();
            calculateButton = new Button();
            groupBox3 = new GroupBox();
            wynikText = new Label();
            wynikHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)amount).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // amount
            // 
            amount.Location = new Point(12, 24);
            amount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            amount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amount.Name = "amount";
            amount.Size = new Size(220, 23);
            amount.TabIndex = 0;
            amount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            amount.ValueChanged += amount_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Kwota:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(firstCHF);
            groupBox1.Controls.Add(firstNOK);
            groupBox1.Controls.Add(firstEUR);
            groupBox1.Controls.Add(firstUSD);
            groupBox1.Controls.Add(firstPLN);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(90, 149);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Waluta:";
            // 
            // firstCHF
            // 
            firstCHF.AutoSize = true;
            firstCHF.Location = new Point(6, 122);
            firstCHF.Name = "firstCHF";
            firstCHF.Size = new Size(48, 19);
            firstCHF.TabIndex = 4;
            firstCHF.TabStop = true;
            firstCHF.Text = "CHF";
            firstCHF.UseVisualStyleBackColor = true;
            firstCHF.CheckedChanged += firstCHF_CheckedChanged;
            // 
            // firstNOK
            // 
            firstNOK.AutoSize = true;
            firstNOK.Location = new Point(6, 97);
            firstNOK.Name = "firstNOK";
            firstNOK.Size = new Size(50, 19);
            firstNOK.TabIndex = 3;
            firstNOK.TabStop = true;
            firstNOK.Text = "NOK";
            firstNOK.UseVisualStyleBackColor = true;
            firstNOK.CheckedChanged += firstNOK_CheckedChanged;
            // 
            // firstEUR
            // 
            firstEUR.AutoSize = true;
            firstEUR.Location = new Point(6, 72);
            firstEUR.Name = "firstEUR";
            firstEUR.Size = new Size(46, 19);
            firstEUR.TabIndex = 2;
            firstEUR.TabStop = true;
            firstEUR.Text = "EUR";
            firstEUR.UseVisualStyleBackColor = true;
            firstEUR.CheckedChanged += firstEUR_CheckedChanged;
            // 
            // firstUSD
            // 
            firstUSD.AutoSize = true;
            firstUSD.Location = new Point(6, 47);
            firstUSD.Name = "firstUSD";
            firstUSD.Size = new Size(47, 19);
            firstUSD.TabIndex = 1;
            firstUSD.TabStop = true;
            firstUSD.Text = "USD";
            firstUSD.UseVisualStyleBackColor = true;
            firstUSD.CheckedChanged += firstUSD_CheckedChanged;
            // 
            // firstPLN
            // 
            firstPLN.AutoSize = true;
            firstPLN.Location = new Point(6, 22);
            firstPLN.Name = "firstPLN";
            firstPLN.Size = new Size(47, 19);
            firstPLN.TabIndex = 0;
            firstPLN.TabStop = true;
            firstPLN.Text = "PLN";
            firstPLN.UseVisualStyleBackColor = true;
            firstPLN.CheckedChanged += firstPLN_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(secondCHF);
            groupBox2.Controls.Add(secondNOK);
            groupBox2.Controls.Add(secondEUR);
            groupBox2.Controls.Add(secondUSD);
            groupBox2.Controls.Add(secondPLN);
            groupBox2.Location = new Point(108, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(124, 149);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Waluta docelowa:";
            // 
            // secondCHF
            // 
            secondCHF.AutoSize = true;
            secondCHF.Location = new Point(6, 122);
            secondCHF.Name = "secondCHF";
            secondCHF.Size = new Size(48, 19);
            secondCHF.TabIndex = 4;
            secondCHF.TabStop = true;
            secondCHF.Text = "CHF";
            secondCHF.UseVisualStyleBackColor = true;
            secondCHF.CheckedChanged += secondCHF_CheckedChanged;
            // 
            // secondNOK
            // 
            secondNOK.AutoSize = true;
            secondNOK.Location = new Point(6, 97);
            secondNOK.Name = "secondNOK";
            secondNOK.Size = new Size(50, 19);
            secondNOK.TabIndex = 3;
            secondNOK.TabStop = true;
            secondNOK.Text = "NOK";
            secondNOK.UseVisualStyleBackColor = true;
            secondNOK.CheckedChanged += secondNOK_CheckedChanged;
            // 
            // secondEUR
            // 
            secondEUR.AutoSize = true;
            secondEUR.Location = new Point(6, 72);
            secondEUR.Name = "secondEUR";
            secondEUR.Size = new Size(46, 19);
            secondEUR.TabIndex = 2;
            secondEUR.TabStop = true;
            secondEUR.Text = "EUR";
            secondEUR.UseVisualStyleBackColor = true;
            secondEUR.CheckedChanged += secondEUR_CheckedChanged;
            // 
            // secondUSD
            // 
            secondUSD.AutoSize = true;
            secondUSD.Location = new Point(6, 47);
            secondUSD.Name = "secondUSD";
            secondUSD.Size = new Size(47, 19);
            secondUSD.TabIndex = 1;
            secondUSD.TabStop = true;
            secondUSD.Text = "USD";
            secondUSD.UseVisualStyleBackColor = true;
            secondUSD.CheckedChanged += secondUSD_CheckedChanged;
            // 
            // secondPLN
            // 
            secondPLN.AutoSize = true;
            secondPLN.Location = new Point(6, 22);
            secondPLN.Name = "secondPLN";
            secondPLN.Size = new Size(47, 19);
            secondPLN.TabIndex = 0;
            secondPLN.TabStop = true;
            secondPLN.Text = "PLN";
            secondPLN.UseVisualStyleBackColor = true;
            secondPLN.CheckedChanged += secondPLN_CheckedChanged;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(12, 208);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(220, 32);
            calculateButton.TabIndex = 8;
            calculateButton.Text = "Przelicz kwotę";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(wynikText);
            groupBox3.Controls.Add(wynikHeader);
            groupBox3.Location = new Point(12, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(220, 83);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Wynik przeliczenia:";
            // 
            // wynikText
            // 
            wynikText.AutoSize = true;
            wynikText.Location = new Point(15, 34);
            wynikText.Name = "wynikText";
            wynikText.Size = new Size(0, 15);
            wynikText.TabIndex = 1;
            // 
            // wynikHeader
            // 
            wynikHeader.AutoSize = true;
            wynikHeader.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            wynikHeader.Location = new Point(6, 19);
            wynikHeader.Name = "wynikHeader";
            wynikHeader.Size = new Size(0, 15);
            wynikHeader.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 341);
            Controls.Add(groupBox3);
            Controls.Add(calculateButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(amount);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(260, 380);
            MinimumSize = new Size(260, 380);
            Name = "Form1";
            Text = "Kantor 3000";
            ((System.ComponentModel.ISupportInitialize)amount).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown amount;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton firstCHF;
        private RadioButton firstNOK;
        private RadioButton firstEUR;
        private RadioButton firstUSD;
        private RadioButton firstPLN;
        private GroupBox groupBox2;
        private RadioButton secondCHF;
        private RadioButton secondNOK;
        private RadioButton secondEUR;
        private RadioButton secondUSD;
        private RadioButton secondPLN;
        private Button calculateButton;
        private GroupBox groupBox3;
        private Label wynikText;
        private Label wynikHeader;
    }
}
