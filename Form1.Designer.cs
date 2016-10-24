namespace lab2
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.lblDisplay3 = new System.Windows.Forms.Label();
            this.lblDisplay4 = new System.Windows.Forms.Label();
            this.lblDisplay5 = new System.Windows.Forms.Label();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnANS = new System.Windows.Forms.Button();
            this.lbldisplay6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(21, 29);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(72, 13);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Enter Number";
            // 
            // lblDisplay2
            // 
            this.lblDisplay2.AutoSize = true;
            this.lblDisplay2.Location = new System.Drawing.Point(21, 63);
            this.lblDisplay2.Name = "lblDisplay2";
            this.lblDisplay2.Size = new System.Drawing.Size(72, 13);
            this.lblDisplay2.TabIndex = 1;
            this.lblDisplay2.Text = "Enter Number";
            // 
            // lblDisplay3
            // 
            this.lblDisplay3.AutoSize = true;
            this.lblDisplay3.Location = new System.Drawing.Point(21, 104);
            this.lblDisplay3.Name = "lblDisplay3";
            this.lblDisplay3.Size = new System.Drawing.Size(72, 13);
            this.lblDisplay3.TabIndex = 2;
            this.lblDisplay3.Text = "Enter Number";
            // 
            // lblDisplay4
            // 
            this.lblDisplay4.AutoSize = true;
            this.lblDisplay4.Location = new System.Drawing.Point(21, 143);
            this.lblDisplay4.Name = "lblDisplay4";
            this.lblDisplay4.Size = new System.Drawing.Size(72, 13);
            this.lblDisplay4.TabIndex = 3;
            this.lblDisplay4.Text = "Enter Number";
            // 
            // lblDisplay5
            // 
            this.lblDisplay5.AutoSize = true;
            this.lblDisplay5.Location = new System.Drawing.Point(21, 192);
            this.lblDisplay5.Name = "lblDisplay5";
            this.lblDisplay5.Size = new System.Drawing.Size(72, 13);
            this.lblDisplay5.TabIndex = 4;
            this.lblDisplay5.Text = "Enter Number";
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(99, 101);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(100, 20);
            this.txtNum3.TabIndex = 5;
            // 
            // txtNum4
            // 
            this.txtNum4.Location = new System.Drawing.Point(99, 140);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(100, 20);
            this.txtNum4.TabIndex = 6;
            // 
            // txtNum5
            // 
            this.txtNum5.Location = new System.Drawing.Point(99, 192);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.Size = new System.Drawing.Size(100, 20);
            this.txtNum5.TabIndex = 7;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(99, 29);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 8;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(99, 63);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 9;
            // 
            // btnANS
            // 
            this.btnANS.Location = new System.Drawing.Point(48, 249);
            this.btnANS.Name = "btnANS";
            this.btnANS.Size = new System.Drawing.Size(149, 53);
            this.btnANS.TabIndex = 10;
            this.btnANS.Text = "Calculate ";
            this.btnANS.UseVisualStyleBackColor = true;
            this.btnANS.Click += new System.EventHandler(this.btnANS_Click);
            // 
            // lbldisplay6
            // 
            this.lbldisplay6.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplay6.Location = new System.Drawing.Point(257, 36);
            this.lbldisplay6.Name = "lbldisplay6";
            this.lbldisplay6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbldisplay6.Size = new System.Drawing.Size(187, 176);
            this.lbldisplay6.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 355);
            this.Controls.Add(this.lbldisplay6);
            this.Controls.Add(this.btnANS);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum5);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.lblDisplay5);
            this.Controls.Add(this.lblDisplay4);
            this.Controls.Add(this.lblDisplay3);
            this.Controls.Add(this.lblDisplay2);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblDisplay2;
        private System.Windows.Forms.Label lblDisplay3;
        private System.Windows.Forms.Label lblDisplay4;
        private System.Windows.Forms.Label lblDisplay5;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnANS;
        private System.Windows.Forms.Label lbldisplay6;
    }
}

