
namespace Excercise3
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
            this.inchesPromptLabel = new System.Windows.Forms.Label();
            this.inchesTextBox = new System.Windows.Forms.TextBox();
            this.centimeterPromptLabel = new System.Windows.Forms.Label();
            this.centimeterTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inchesPromptLabel
            // 
            this.inchesPromptLabel.AutoSize = true;
            this.inchesPromptLabel.Location = new System.Drawing.Point(28, 39);
            this.inchesPromptLabel.Name = "inchesPromptLabel";
            this.inchesPromptLabel.Size = new System.Drawing.Size(234, 25);
            this.inchesPromptLabel.TabIndex = 0;
            this.inchesPromptLabel.Text = "Enter your Height in Inches: ";
            this.inchesPromptLabel.Click += new System.EventHandler(this.inchesPromptLabel_Click);
            // 
            // inchesTextBox
            // 
            this.inchesTextBox.Location = new System.Drawing.Point(286, 36);
            this.inchesTextBox.Name = "inchesTextBox";
            this.inchesTextBox.Size = new System.Drawing.Size(220, 31);
            this.inchesTextBox.TabIndex = 1;
            this.inchesTextBox.TextChanged += new System.EventHandler(this.inchesTextBox_TextChanged);
            // 
            // centimeterPromptLabel
            // 
            this.centimeterPromptLabel.AutoSize = true;
            this.centimeterPromptLabel.Location = new System.Drawing.Point(30, 148);
            this.centimeterPromptLabel.Name = "centimeterPromptLabel";
            this.centimeterPromptLabel.Size = new System.Drawing.Size(232, 25);
            this.centimeterPromptLabel.TabIndex = 2;
            this.centimeterPromptLabel.Text = "Your Height in Centimeters: ";
            this.centimeterPromptLabel.Click += new System.EventHandler(this.centimeterPromptLabel_Click);
            // 
            // centimeterTextBox
            // 
            this.centimeterTextBox.Location = new System.Drawing.Point(286, 145);
            this.centimeterTextBox.Name = "centimeterTextBox";
            this.centimeterTextBox.Size = new System.Drawing.Size(220, 31);
            this.centimeterTextBox.TabIndex = 3;
            this.centimeterTextBox.TextChanged += new System.EventHandler(this.centimeterTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(318, 267);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(188, 53);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 418);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.centimeterTextBox);
            this.Controls.Add(this.centimeterPromptLabel);
            this.Controls.Add(this.inchesTextBox);
            this.Controls.Add(this.inchesPromptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inchesPromptLabel;
        private System.Windows.Forms.TextBox inchesTextBox;
        private System.Windows.Forms.Label centimeterPromptLabel;
        private System.Windows.Forms.TextBox centimeterTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitButton;
    }
}

