namespace BlackJack3
{
    partial class InputViewForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelButton = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonHold = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelButton
            // 
            this.labelButton.AutoSize = true;
            this.labelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButton.Location = new System.Drawing.Point(12, 84);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(61, 15);
            this.labelButton.TabIndex = 1;
            this.labelButton.Text = "My hand";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "New Round";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonHold
            // 
            this.buttonHold.Location = new System.Drawing.Point(179, 13);
            this.buttonHold.Name = "buttonHold";
            this.buttonHold.Size = new System.Drawing.Size(97, 58);
            this.buttonHold.TabIndex = 3;
            this.buttonHold.Text = "Hold";
            this.buttonHold.UseVisualStyleBackColor = true;
            this.buttonHold.Click += new System.EventHandler(this.buttonHold_Click);
            // 
            // InputViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonHold);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelButton);
            this.Controls.Add(this.button1);
            this.Name = "InputViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelButton;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button buttonHold;

    }
}