namespace ConsoleApp1
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
            this.outputBox = new System.Windows.Forms.TextBox();
            this.operatorButton = new System.Windows.Forms.Button();
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.operatorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(260, 170);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(201, 28);
            this.outputBox.TabIndex = 0;
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // operatorButton
            // 
            this.operatorButton.Location = new System.Drawing.Point(260, 219);
            this.operatorButton.Name = "operatorButton";
            this.operatorButton.Size = new System.Drawing.Size(201, 23);
            this.operatorButton.TabIndex = 1;
            this.operatorButton.Text = "operator";
            this.operatorButton.UseVisualStyleBackColor = true;
            this.operatorButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(112, 113);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(201, 28);
            this.inputBox1.TabIndex = 2;
            this.inputBox1.TextChanged += new System.EventHandler(this.inputBox1_TextChanged);
            // 
            // inputBox2
            // 
            this.inputBox2.Location = new System.Drawing.Point(386, 113);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(225, 28);
            this.inputBox2.TabIndex = 3;
            this.inputBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // operatorBox
            // 
            this.operatorBox.Location = new System.Drawing.Point(337, 112);
            this.operatorBox.Name = "operatorBox";
            this.operatorBox.Size = new System.Drawing.Size(31, 28);
            this.operatorBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 586);
            this.Controls.Add(this.operatorBox);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.operatorButton);
            this.Controls.Add(this.outputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button operatorButton;
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.TextBox operatorBox;
    }
}