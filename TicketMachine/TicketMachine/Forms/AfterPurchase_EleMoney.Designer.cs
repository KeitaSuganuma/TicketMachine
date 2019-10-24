namespace TicketMachine
{
    partial class AfterPurchase_EleMoney
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
            this.BalanceMoney = new System.Windows.Forms.Label();
            this.TopButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "残高";
            // 
            // BalanceMoney
            // 
            this.BalanceMoney.AutoSize = true;
            this.BalanceMoney.Location = new System.Drawing.Point(455, 251);
            this.BalanceMoney.Name = "BalanceMoney";
            this.BalanceMoney.Size = new System.Drawing.Size(52, 18);
            this.BalanceMoney.TabIndex = 1;
            this.BalanceMoney.Text = "label2";
            // 
            // TopButton
            // 
            this.TopButton.Location = new System.Drawing.Point(564, 424);
            this.TopButton.Name = "TopButton";
            this.TopButton.Size = new System.Drawing.Size(169, 73);
            this.TopButton.TabIndex = 2;
            this.TopButton.Text = "トップページへ";
            this.TopButton.UseVisualStyleBackColor = true;
            this.TopButton.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketMachine.Properties.Resources.train_ic_card;
            this.pictureBox1.Location = new System.Drawing.Point(196, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AfterPurchase_EleMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TopButton);
            this.Controls.Add(this.BalanceMoney);
            this.Controls.Add(this.label1);
            this.Name = "AfterPurchase_EleMoney";
            this.Text = "TicketMachine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Proto_FormClosing);
            this.Load += new System.EventHandler(this.AfterPurchase_EleMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BalanceMoney;
        private System.Windows.Forms.Button TopButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}