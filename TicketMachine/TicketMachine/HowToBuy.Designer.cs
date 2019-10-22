namespace TicketMachine
{
    partial class HowToBuy
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Money = new System.Windows.Forms.Button();
            this.Electronic_Money = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(168, 108);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(178, 73);
            this.Money.TabIndex = 1;
            this.Money.Text = "現金";
            this.Money.UseVisualStyleBackColor = true;
            this.Money.Click += new System.EventHandler(this.Money_Click);
            // 
            // Electronic_Money
            // 
            this.Electronic_Money.Location = new System.Drawing.Point(428, 108);
            this.Electronic_Money.Name = "Electronic_Money";
            this.Electronic_Money.Size = new System.Drawing.Size(178, 73);
            this.Electronic_Money.TabIndex = 2;
            this.Electronic_Money.Text = "電子マネー";
            this.Electronic_Money.UseVisualStyleBackColor = true;
            this.Electronic_Money.Click += new System.EventHandler(this.Electronic_Money_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "支払い方法を選択してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "130円";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "124円";
            // 
            // HowToBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Electronic_Money);
            this.Controls.Add(this.Money);
            this.Name = "HowToBuy";
            this.Text = "TiketMachine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Proto_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Money;
        private System.Windows.Forms.Button Electronic_Money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

