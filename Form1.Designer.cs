namespace TemperatureConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonFahrenToKel = new System.Windows.Forms.RadioButton();
            this.radioButtonKelToCel = new System.Windows.Forms.RadioButton();
            this.radioButtonCelToKel = new System.Windows.Forms.RadioButton();
            this.radioButtonCelToFahren = new System.Windows.Forms.RadioButton();
            this.radioButtonFahrenToCel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputTextBox);
            this.groupBox1.Controls.Add(this.inputTextBox);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonConvert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButtonFahrenToKel);
            this.groupBox1.Controls.Add(this.radioButtonKelToCel);
            this.groupBox1.Controls.Add(this.radioButtonCelToKel);
            this.groupBox1.Controls.Add(this.radioButtonCelToFahren);
            this.groupBox1.Controls.Add(this.radioButtonFahrenToCel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temprature  Converter";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(424, 381);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(265, 35);
            this.outputTextBox.TabIndex = 11;
            this.outputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(331, 86);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(358, 35);
            this.inputTextBox.TabIndex = 10;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(28, 476);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(102, 34);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(587, 476);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(102, 34);
            this.buttonConvert.TabIndex = 8;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Converted Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conversion Type";
            // 
            // radioButtonFahrenToKel
            // 
            this.radioButtonFahrenToKel.AutoSize = true;
            this.radioButtonFahrenToKel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFahrenToKel.Location = new System.Drawing.Point(27, 337);
            this.radioButtonFahrenToKel.Name = "radioButtonFahrenToKel";
            this.radioButtonFahrenToKel.Size = new System.Drawing.Size(197, 29);
            this.radioButtonFahrenToKel.TabIndex = 5;
            this.radioButtonFahrenToKel.TabStop = true;
            this.radioButtonFahrenToKel.Text = "Fahrenheit to Kelvin";
            this.radioButtonFahrenToKel.UseVisualStyleBackColor = true;
            // 
            // radioButtonKelToCel
            // 
            this.radioButtonKelToCel.AutoSize = true;
            this.radioButtonKelToCel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKelToCel.Location = new System.Drawing.Point(27, 302);
            this.radioButtonKelToCel.Name = "radioButtonKelToCel";
            this.radioButtonKelToCel.Size = new System.Drawing.Size(167, 29);
            this.radioButtonKelToCel.TabIndex = 4;
            this.radioButtonKelToCel.TabStop = true;
            this.radioButtonKelToCel.Text = "Kelvin to Celsius";
            this.radioButtonKelToCel.UseVisualStyleBackColor = true;
            // 
            // radioButtonCelToKel
            // 
            this.radioButtonCelToKel.AutoSize = true;
            this.radioButtonCelToKel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCelToKel.Location = new System.Drawing.Point(27, 267);
            this.radioButtonCelToKel.Name = "radioButtonCelToKel";
            this.radioButtonCelToKel.Size = new System.Drawing.Size(167, 29);
            this.radioButtonCelToKel.TabIndex = 3;
            this.radioButtonCelToKel.TabStop = true;
            this.radioButtonCelToKel.Text = "Celsius to Kelvin";
            this.radioButtonCelToKel.UseVisualStyleBackColor = true;
            // 
            // radioButtonCelToFahren
            // 
            this.radioButtonCelToFahren.AutoSize = true;
            this.radioButtonCelToFahren.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCelToFahren.Location = new System.Drawing.Point(28, 232);
            this.radioButtonCelToFahren.Name = "radioButtonCelToFahren";
            this.radioButtonCelToFahren.Size = new System.Drawing.Size(205, 29);
            this.radioButtonCelToFahren.TabIndex = 2;
            this.radioButtonCelToFahren.TabStop = true;
            this.radioButtonCelToFahren.Text = "Celsius to Fahrenheit";
            this.radioButtonCelToFahren.UseVisualStyleBackColor = true;
            // 
            // radioButtonFahrenToCel
            // 
            this.radioButtonFahrenToCel.AutoSize = true;
            this.radioButtonFahrenToCel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFahrenToCel.Location = new System.Drawing.Point(28, 197);
            this.radioButtonFahrenToCel.Name = "radioButtonFahrenToCel";
            this.radioButtonFahrenToCel.Size = new System.Drawing.Size(205, 29);
            this.radioButtonFahrenToCel.TabIndex = 1;
            this.radioButtonFahrenToCel.TabStop = true;
            this.radioButtonFahrenToCel.Text = "Fahrenheit to Celsius";
            this.radioButtonFahrenToCel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Value to Convert:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonFahrenToKel;
        private System.Windows.Forms.RadioButton radioButtonKelToCel;
        private System.Windows.Forms.RadioButton radioButtonCelToKel;
        private System.Windows.Forms.RadioButton radioButtonCelToFahren;
        private System.Windows.Forms.RadioButton radioButtonFahrenToCel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

