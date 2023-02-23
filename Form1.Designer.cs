namespace Roulette
{
    partial class Roulette
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
            this.bet1 = new System.Windows.Forms.Button();
            this.bet10 = new System.Windows.Forms.Button();
            this.bet50 = new System.Windows.Forms.Button();
            this.bet100 = new System.Windows.Forms.Button();
            this.bet250 = new System.Windows.Forms.Button();
            this.bet500 = new System.Windows.Forms.Button();
            this.betManual = new System.Windows.Forms.Button();
            this.betAmountManual = new System.Windows.Forms.TextBox();
            this.selectedToken = new System.Windows.Forms.Label();
            this.userMoney = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bet1
            // 
            this.bet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet1.Location = new System.Drawing.Point(12, 12);
            this.bet1.Name = "bet1";
            this.bet1.Size = new System.Drawing.Size(75, 75);
            this.bet1.TabIndex = 0;
            this.bet1.Text = "1";
            this.bet1.UseVisualStyleBackColor = true;
            this.bet1.Click += new System.EventHandler(this.ChangeBetAmount);
            // 
            // bet10
            // 
            this.bet10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet10.Location = new System.Drawing.Point(12, 93);
            this.bet10.Name = "bet10";
            this.bet10.Size = new System.Drawing.Size(75, 75);
            this.bet10.TabIndex = 1;
            this.bet10.Text = "10";
            this.bet10.UseVisualStyleBackColor = true;
            this.bet10.Click += new System.EventHandler(this.ChangeBetAmount);
            // 
            // bet50
            // 
            this.bet50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet50.Location = new System.Drawing.Point(12, 174);
            this.bet50.Name = "bet50";
            this.bet50.Size = new System.Drawing.Size(75, 75);
            this.bet50.TabIndex = 2;
            this.bet50.Text = "50";
            this.bet50.UseVisualStyleBackColor = true;
            this.bet50.Click += new System.EventHandler(this.ChangeBetAmount);
            // 
            // bet100
            // 
            this.bet100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bet100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet100.Location = new System.Drawing.Point(12, 255);
            this.bet100.Name = "bet100";
            this.bet100.Size = new System.Drawing.Size(75, 75);
            this.bet100.TabIndex = 3;
            this.bet100.Text = "100";
            this.bet100.UseVisualStyleBackColor = false;
            this.bet100.Click += new System.EventHandler(this.ChangeBetAmount);
            // 
            // bet250
            // 
            this.bet250.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet250.Location = new System.Drawing.Point(12, 336);
            this.bet250.Name = "bet250";
            this.bet250.Size = new System.Drawing.Size(75, 75);
            this.bet250.TabIndex = 4;
            this.bet250.Text = "250";
            this.bet250.UseVisualStyleBackColor = true;
            this.bet250.Click += new System.EventHandler(this.ChangeBetAmount);
            // 
            // bet500
            // 
            this.bet500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bet500.Location = new System.Drawing.Point(12, 417);
            this.bet500.Name = "bet500";
            this.bet500.Size = new System.Drawing.Size(75, 75);
            this.bet500.TabIndex = 5;
            this.bet500.Text = "500";
            this.bet500.UseVisualStyleBackColor = true;
            this.bet500.Click += new System.EventHandler(this.ChangeBetAmount);
            // 
            // betManual
            // 
            this.betManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.betManual.Location = new System.Drawing.Point(12, 498);
            this.betManual.Name = "betManual";
            this.betManual.Size = new System.Drawing.Size(75, 75);
            this.betManual.TabIndex = 6;
            this.betManual.Text = "Manual";
            this.betManual.UseVisualStyleBackColor = true;
            this.betManual.Click += new System.EventHandler(this.ChangeBetAmount);
            // 
            // betAmountManual
            // 
            this.betAmountManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.betAmountManual.ForeColor = System.Drawing.Color.Gainsboro;
            this.betAmountManual.Location = new System.Drawing.Point(12, 579);
            this.betAmountManual.Name = "betAmountManual";
            this.betAmountManual.Size = new System.Drawing.Size(75, 23);
            this.betAmountManual.TabIndex = 7;
            this.betAmountManual.Text = "100";
            this.betAmountManual.TextChanged += new System.EventHandler(this.ChangeBetAmount);
            // 
            // selectedToken
            // 
            this.selectedToken.AutoSize = true;
            this.selectedToken.Location = new System.Drawing.Point(12, 631);
            this.selectedToken.Name = "selectedToken";
            this.selectedToken.Size = new System.Drawing.Size(75, 15);
            this.selectedToken.TabIndex = 8;
            this.selectedToken.Text = "Selected: 100";
            // 
            // userMoney
            // 
            this.userMoney.Location = new System.Drawing.Point(414, 627);
            this.userMoney.Name = "userMoney";
            this.userMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userMoney.Size = new System.Drawing.Size(100, 23);
            this.userMoney.TabIndex = 9;
            this.userMoney.Text = "Money: 1000";
            this.userMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rollButton
            // 
            this.rollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollButton.Location = new System.Drawing.Point(439, 12);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 75);
            this.rollButton.TabIndex = 10;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.RollRandom);
            // 
            // Roulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(526, 655);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.userMoney);
            this.Controls.Add(this.selectedToken);
            this.Controls.Add(this.betAmountManual);
            this.Controls.Add(this.betManual);
            this.Controls.Add(this.bet500);
            this.Controls.Add(this.bet250);
            this.Controls.Add(this.bet100);
            this.Controls.Add(this.bet50);
            this.Controls.Add(this.bet10);
            this.Controls.Add(this.bet1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Roulette";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Roulette";
            this.Load += new System.EventHandler(this.Initialization);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bet1;
        private Button bet10;
        private Button bet50;
        private Button bet100;
        private Button bet250;
        private Button bet500;
        private Button betManual;
        private TextBox betAmountManual;
        private Label selectedToken;
        private Label userMoney;
        private Button rollButton;
    }
}