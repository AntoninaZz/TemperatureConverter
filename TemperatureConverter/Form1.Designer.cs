namespace TemperatureConverter
{
    partial class TemperatureConverter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpConvertFrom = new System.Windows.Forms.GroupBox();
            this.rbFromF = new System.Windows.Forms.RadioButton();
            this.rbFromK = new System.Windows.Forms.RadioButton();
            this.rbFromC = new System.Windows.Forms.RadioButton();
            this.grpConvertTo = new System.Windows.Forms.GroupBox();
            this.rbToF = new System.Windows.Forms.RadioButton();
            this.rbToK = new System.Windows.Forms.RadioButton();
            this.rbToC = new System.Windows.Forms.RadioButton();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtConvertedTemp = new System.Windows.Forms.TextBox();
            this.lblConvertFrom = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblConvertTo = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpConvertFrom.SuspendLayout();
            this.grpConvertTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConvertFrom
            // 
            this.grpConvertFrom.Controls.Add(this.rbFromF);
            this.grpConvertFrom.Controls.Add(this.rbFromK);
            this.grpConvertFrom.Controls.Add(this.rbFromC);
            this.grpConvertFrom.Location = new System.Drawing.Point(28, 32);
            this.grpConvertFrom.Name = "grpConvertFrom";
            this.grpConvertFrom.Size = new System.Drawing.Size(269, 116);
            this.grpConvertFrom.TabIndex = 0;
            this.grpConvertFrom.TabStop = false;
            this.grpConvertFrom.Text = "Convert &from";
            // 
            // rbFromF
            // 
            this.rbFromF.AutoSize = true;
            this.rbFromF.Location = new System.Drawing.Point(16, 85);
            this.rbFromF.Name = "rbFromF";
            this.rbFromF.Size = new System.Drawing.Size(111, 24);
            this.rbFromF.TabIndex = 2;
            this.rbFromF.Text = "&Fahrenheit";
            this.rbFromF.UseVisualStyleBackColor = true;
            this.rbFromF.CheckedChanged += new System.EventHandler(this.rbFromF_CheckedChanged);
            // 
            // rbFromK
            // 
            this.rbFromK.AutoSize = true;
            this.rbFromK.Location = new System.Drawing.Point(16, 55);
            this.rbFromK.Name = "rbFromK";
            this.rbFromK.Size = new System.Drawing.Size(75, 24);
            this.rbFromK.TabIndex = 1;
            this.rbFromK.Text = "&Kelvin";
            this.rbFromK.UseVisualStyleBackColor = true;
            this.rbFromK.CheckedChanged += new System.EventHandler(this.rbFromK_CheckedChanged);
            // 
            // rbFromC
            // 
            this.rbFromC.AutoSize = true;
            this.rbFromC.Checked = true;
            this.rbFromC.Location = new System.Drawing.Point(16, 25);
            this.rbFromC.Name = "rbFromC";
            this.rbFromC.Size = new System.Drawing.Size(85, 24);
            this.rbFromC.TabIndex = 0;
            this.rbFromC.TabStop = true;
            this.rbFromC.Text = "&Celsius";
            this.rbFromC.UseVisualStyleBackColor = true;
            this.rbFromC.CheckedChanged += new System.EventHandler(this.rbFromC_CheckedChanged);
            // 
            // grpConvertTo
            // 
            this.grpConvertTo.Controls.Add(this.rbToF);
            this.grpConvertTo.Controls.Add(this.rbToK);
            this.grpConvertTo.Controls.Add(this.rbToC);
            this.grpConvertTo.Location = new System.Drawing.Point(320, 32);
            this.grpConvertTo.Name = "grpConvertTo";
            this.grpConvertTo.Size = new System.Drawing.Size(272, 116);
            this.grpConvertTo.TabIndex = 1;
            this.grpConvertTo.TabStop = false;
            this.grpConvertTo.Text = "Convert &to";
            // 
            // rbToF
            // 
            this.rbToF.AutoSize = true;
            this.rbToF.Location = new System.Drawing.Point(18, 85);
            this.rbToF.Name = "rbToF";
            this.rbToF.Size = new System.Drawing.Size(111, 24);
            this.rbToF.TabIndex = 2;
            this.rbToF.Text = "&Fahrenheit";
            this.rbToF.UseVisualStyleBackColor = true;
            this.rbToF.CheckedChanged += new System.EventHandler(this.rbToF_CheckedChanged);
            // 
            // rbToK
            // 
            this.rbToK.AutoSize = true;
            this.rbToK.Checked = true;
            this.rbToK.Location = new System.Drawing.Point(18, 55);
            this.rbToK.Name = "rbToK";
            this.rbToK.Size = new System.Drawing.Size(75, 24);
            this.rbToK.TabIndex = 1;
            this.rbToK.TabStop = true;
            this.rbToK.Text = "&Kelvin";
            this.rbToK.UseVisualStyleBackColor = true;
            this.rbToK.CheckedChanged += new System.EventHandler(this.rbToK_CheckedChanged);
            // 
            // rbToC
            // 
            this.rbToC.AutoSize = true;
            this.rbToC.Location = new System.Drawing.Point(18, 25);
            this.rbToC.Name = "rbToC";
            this.rbToC.Size = new System.Drawing.Size(85, 24);
            this.rbToC.TabIndex = 0;
            this.rbToC.Text = "&Celsius";
            this.rbToC.UseVisualStyleBackColor = true;
            this.rbToC.CheckedChanged += new System.EventHandler(this.rbToC_CheckedChanged);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(124, 205);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(131, 26);
            this.txtTemp.TabIndex = 2;
            this.txtTemp.Click += new System.EventHandler(this.txtTemp_Click);
            this.txtTemp.TextChanged += new System.EventHandler(this.txtTemp_TextChanged);
            this.txtTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp_KeyPress);
            // 
            // txtConvertedTemp
            // 
            this.txtConvertedTemp.Location = new System.Drawing.Point(338, 205);
            this.txtConvertedTemp.Name = "txtConvertedTemp";
            this.txtConvertedTemp.ReadOnly = true;
            this.txtConvertedTemp.Size = new System.Drawing.Size(131, 26);
            this.txtConvertedTemp.TabIndex = 3;
            // 
            // lblConvertFrom
            // 
            this.lblConvertFrom.AutoSize = true;
            this.lblConvertFrom.Location = new System.Drawing.Point(261, 208);
            this.lblConvertFrom.Name = "lblConvertFrom";
            this.lblConvertFrom.Size = new System.Drawing.Size(20, 20);
            this.lblConvertFrom.TabIndex = 4;
            this.lblConvertFrom.Text = "C";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(299, 208);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(18, 20);
            this.lblEquals.TabIndex = 5;
            this.lblEquals.Text = "=";
            // 
            // lblConvertTo
            // 
            this.lblConvertTo.AutoSize = true;
            this.lblConvertTo.Location = new System.Drawing.Point(475, 208);
            this.lblConvertTo.Name = "lblConvertTo";
            this.lblConvertTo.Size = new System.Drawing.Size(19, 20);
            this.lblConvertTo.TabIndex = 6;
            this.lblConvertTo.Text = "K";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(54, 311);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(113, 37);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(457, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblConvertTo);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblConvertFrom);
            this.Controls.Add(this.txtConvertedTemp);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.grpConvertTo);
            this.Controls.Add(this.grpConvertFrom);
            this.Name = "TemperatureConverter";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.TemperatureConverter_Load);
            this.grpConvertFrom.ResumeLayout(false);
            this.grpConvertFrom.PerformLayout();
            this.grpConvertTo.ResumeLayout(false);
            this.grpConvertTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConvertFrom;
        private System.Windows.Forms.RadioButton rbFromF;
        private System.Windows.Forms.RadioButton rbFromK;
        private System.Windows.Forms.RadioButton rbFromC;
        private System.Windows.Forms.GroupBox grpConvertTo;
        private System.Windows.Forms.RadioButton rbToF;
        private System.Windows.Forms.RadioButton rbToK;
        private System.Windows.Forms.RadioButton rbToC;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtConvertedTemp;
        private System.Windows.Forms.Label lblConvertFrom;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblConvertTo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
    }
}

