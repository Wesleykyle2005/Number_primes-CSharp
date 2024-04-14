namespace PrimeNumbers
{
    partial class PrimeNumbersForm
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
            btnCalculate = new Button();
            txtFirstValue = new TextBox();
            txtSecondValue = new TextBox();
            button1 = new Button();
            btnFirst = new Button();
            btnSecond = new Button();
            listPrimes = new ListBox();
            btnRestart = new Button();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ActiveCaption;
            btnCalculate.Enabled = false;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Location = new Point(200, 350);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 50);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += CalculatePrimes;
            // 
            // txtFirstValue
            // 
            txtFirstValue.Cursor = Cursors.IBeam;
            txtFirstValue.Location = new Point(50, 50);
            txtFirstValue.Name = "txtFirstValue";
            txtFirstValue.Size = new Size(100, 23);
            txtFirstValue.TabIndex = 3;
            // 
            // txtSecondValue
            // 
            txtSecondValue.Cursor = Cursors.IBeam;
            txtSecondValue.Location = new Point(200, 50);
            txtSecondValue.Name = "txtSecondValue";
            txtSecondValue.Size = new Size(100, 23);
            txtSecondValue.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(305, 178);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = SystemColors.ActiveCaption;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Location = new Point(50, 100);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(100, 50);
            btnFirst.TabIndex = 6;
            btnFirst.Text = "Establecer inicio";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += GetFirstValue;
            // 
            // btnSecond
            // 
            btnSecond.BackColor = SystemColors.ActiveCaption;
            btnSecond.Enabled = false;
            btnSecond.FlatStyle = FlatStyle.Flat;
            btnSecond.Location = new Point(200, 100);
            btnSecond.Name = "btnSecond";
            btnSecond.Size = new Size(100, 50);
            btnSecond.TabIndex = 7;
            btnSecond.Text = "Establecer final";
            btnSecond.UseVisualStyleBackColor = false;
            btnSecond.Click += GetSecondValue;
            // 
            // listPrimes
            // 
            listPrimes.BorderStyle = BorderStyle.FixedSingle;
            listPrimes.FormattingEnabled = true;
            listPrimes.HorizontalExtent = 100;
            listPrimes.HorizontalScrollbar = true;
            listPrimes.IntegralHeight = false;
            listPrimes.ItemHeight = 15;
            listPrimes.Location = new Point(348, 50);
            listPrimes.Name = "listPrimes";
            listPrimes.ScrollAlwaysVisible = true;
            listPrimes.Size = new Size(100, 100);
            listPrimes.TabIndex = 8;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = SystemColors.ActiveCaption;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Location = new Point(50, 350);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(100, 50);
            btnRestart.TabIndex = 9;
            btnRestart.Text = "Reiniciar";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += RestartAll;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(348, 350);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 10;
            // 
            // PrimeNumbersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(txtCantidad);
            Controls.Add(btnRestart);
            Controls.Add(listPrimes);
            Controls.Add(btnSecond);
            Controls.Add(btnFirst);
            Controls.Add(button1);
            Controls.Add(txtSecondValue);
            Controls.Add(txtFirstValue);
            Controls.Add(btnCalculate);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PrimeNumbersForm";
            Text = "Calculo de números primos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtFirstValue;
        private TextBox txtSecondValue;
        private Button button1;
        private Button btnFirst;
        private Button btnSecond;
        private ListBox listPrimes;
        private Button btnRestart;
        private TextBox txtCantidad;
    }
}