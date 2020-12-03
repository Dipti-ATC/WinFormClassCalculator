
namespace WinFormClassCalculator
{
    partial class Calculator
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
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.lblSecondNum = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(251, 71);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNum.TabIndex = 0;
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(251, 129);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNum.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(251, 194);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 2;
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Location = new System.Drawing.Point(248, 41);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(94, 13);
            this.lblFirstNum.TabIndex = 3;
            this.lblFirstNum.Text = "Enter First Number";
            // 
            // lblSecondNum
            // 
            this.lblSecondNum.AutoSize = true;
            this.lblSecondNum.Location = new System.Drawing.Point(248, 104);
            this.lblSecondNum.Name = "lblSecondNum";
            this.lblSecondNum.Size = new System.Drawing.Size(112, 13);
            this.lblSecondNum.TabIndex = 4;
            this.lblSecondNum.Text = "Enter Second Number";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(248, 163);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 339);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblSecondNum);
            this.Controls.Add(this.lblFirstNum);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtSecondNum;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.Label lblSecondNum;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnAdd;
    }
}

