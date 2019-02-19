namespace ATM
{
    partial class ATM
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
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.atM_Services1 = new ATM_Services();
            this.SuspendLayout();
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(263, 30);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(85, 37);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "ATM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 94);
            this.button1.TabIndex = 4;
            this.button1.Text = "Saving Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 94);
            this.button2.TabIndex = 5;
            this.button2.Text = "Current Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(326, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(199, 92);
            this.button6.TabIndex = 7;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // atM_Services1
            // 
            this.atM_Services1.Location = new System.Drawing.Point(36, 21);
            this.atM_Services1.Name = "atM_Services1";
            this.atM_Services1.Size = new System.Drawing.Size(540, 440);
            this.atM_Services1.TabIndex = 8;
            this.atM_Services1.Visible = false;
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.atM_Services1);
            this.Name = "ATM";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private ATM_Services atM_Services1;
    }
}

