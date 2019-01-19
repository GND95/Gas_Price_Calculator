namespace GasPriceCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTankCapacity = new System.Windows.Forms.TextBox();
            this.textBoxGasPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGasLevel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(-3, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tank Capacity (Gallons)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(558, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Gas Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(386, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gas Price";
            // 
            // textBoxTankCapacity
            // 
            this.textBoxTankCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxTankCapacity.Location = new System.Drawing.Point(70, 58);
            this.textBoxTankCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTankCapacity.Multiline = true;
            this.textBoxTankCapacity.Name = "textBoxTankCapacity";
            this.textBoxTankCapacity.Size = new System.Drawing.Size(175, 58);
            this.textBoxTankCapacity.TabIndex = 3;
            // 
            // textBoxGasPrice
            // 
            this.textBoxGasPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxGasPrice.Location = new System.Drawing.Point(393, 58);
            this.textBoxGasPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxGasPrice.Multiline = true;
            this.textBoxGasPrice.Name = "textBoxGasPrice";
            this.textBoxGasPrice.Size = new System.Drawing.Size(152, 58);
            this.textBoxGasPrice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(219, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(219, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 46);
            this.label5.TabIndex = 6;
            this.label5.Text = "$";
            // 
            // comboBoxGasLevel
            // 
            this.comboBoxGasLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGasLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBoxGasLevel.FormattingEnabled = true;
            this.comboBoxGasLevel.Location = new System.Drawing.Point(650, 58);
            this.comboBoxGasLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGasLevel.Name = "comboBoxGasLevel";
            this.comboBoxGasLevel.Size = new System.Drawing.Size(122, 30);
            this.comboBoxGasLevel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(4, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 111);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelTotalCost.Location = new System.Drawing.Point(249, 194);
            this.labelTotalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(97, 46);
            this.labelTotalCost.TabIndex = 9;
            this.labelTotalCost.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 272);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxGasLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGasPrice);
            this.Controls.Add(this.textBoxTankCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gas Cost Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTankCapacity;
        private System.Windows.Forms.TextBox textBoxGasPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGasLevel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotalCost;
    }
}

