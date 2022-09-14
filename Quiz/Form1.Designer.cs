namespace Quiz
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
            this.buttonResult = new System.Windows.Forms.Button();
            this.textBoxHigh = new System.Windows.Forms.TextBox();
            this.textBoxLow = new System.Windows.Forms.TextBox();
            this.labelNums = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(351, 175);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(122, 46);
            this.buttonResult.TabIndex = 0;
            this.buttonResult.Text = "Press to Find Even Num.";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonSonuc_Click);
            // 
            // textBoxHigh
            // 
            this.textBoxHigh.Location = new System.Drawing.Point(145, 137);
            this.textBoxHigh.Name = "textBoxHigh";
            this.textBoxHigh.Size = new System.Drawing.Size(104, 23);
            this.textBoxHigh.TabIndex = 1;
            this.textBoxHigh.TextChanged += new System.EventHandler(this.textBoxDeger1_TextChanged);
            // 
            // textBoxLow
            // 
            this.textBoxLow.Location = new System.Drawing.Point(145, 226);
            this.textBoxLow.Name = "textBoxLow";
            this.textBoxLow.Size = new System.Drawing.Size(104, 23);
            this.textBoxLow.TabIndex = 2;
            // 
            // labelNums
            // 
            this.labelNums.AutoSize = true;
            this.labelNums.Location = new System.Drawing.Point(553, 175);
            this.labelNums.Name = "labelNums";
            this.labelNums.Size = new System.Drawing.Size(87, 15);
            this.labelNums.TabIndex = 3;
            this.labelNums.Text = "Even Numbers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Finish Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNums);
            this.Controls.Add(this.textBoxLow);
            this.Controls.Add(this.textBoxHigh);
            this.Controls.Add(this.buttonResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonResult;
        private TextBox textBoxHigh;
        private TextBox textBoxLow;
        private Label labelNums;
        private Label label1;
        private Label label2;
    }
}