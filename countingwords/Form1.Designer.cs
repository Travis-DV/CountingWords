namespace countingwords
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
            this.inputTB = new System.Windows.Forms.TextBox();
            this.inputLB = new System.Windows.Forms.Label();
            this.outputLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(12, 37);
            this.inputTB.Multiline = true;
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(157, 73);
            this.inputTB.TabIndex = 0;
            this.inputTB.TextChanged += new System.EventHandler(this.inputTB_TextChanged);
            // 
            // inputLB
            // 
            this.inputLB.AutoSize = true;
            this.inputLB.Location = new System.Drawing.Point(42, 9);
            this.inputLB.Name = "inputLB";
            this.inputLB.Size = new System.Drawing.Size(91, 25);
            this.inputLB.TabIndex = 0;
            this.inputLB.Text = "Input text";
            // 
            // outputLB
            // 
            this.outputLB.AutoSize = true;
            this.outputLB.Location = new System.Drawing.Point(12, 123);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(157, 25);
            this.outputLB.TabIndex = 1;
            this.outputLB.Text = "You have  words";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 248);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.inputLB);
            this.Controls.Add(this.inputTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label inputLB;
        private System.Windows.Forms.Label outputLB;
    }
}

