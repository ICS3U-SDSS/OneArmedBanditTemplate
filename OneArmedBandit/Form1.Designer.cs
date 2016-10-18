namespace OneArmedBandit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spinButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.scoreDisplay = new System.Windows.Forms.Label();
            this.reel3 = new System.Windows.Forms.Label();
            this.reel2 = new System.Windows.Forms.Label();
            this.reel1 = new System.Windows.Forms.Label();
            this.coinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // spinButton
            // 
            this.spinButton.BackColor = System.Drawing.Color.LimeGreen;
            this.spinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spinButton.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.Location = new System.Drawing.Point(478, 188);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(77, 71);
            this.spinButton.TabIndex = 3;
            this.spinButton.Text = "SPIN";
            this.spinButton.UseVisualStyleBackColor = false;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.DimGray;
            this.outputLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(156, 363);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(243, 48);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreDisplay
            // 
            this.scoreDisplay.BackColor = System.Drawing.Color.Transparent;
            this.scoreDisplay.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreDisplay.ForeColor = System.Drawing.Color.White;
            this.scoreDisplay.Location = new System.Drawing.Point(89, 363);
            this.scoreDisplay.Name = "scoreDisplay";
            this.scoreDisplay.Size = new System.Drawing.Size(61, 48);
            this.scoreDisplay.TabIndex = 5;
            this.scoreDisplay.Text = "10";
            this.scoreDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reel3
            // 
            this.reel3.BackColor = System.Drawing.Color.White;
            this.reel3.Image = global::OneArmedBandit.Properties.Resources.diamond_100x125;
            this.reel3.Location = new System.Drawing.Point(345, 174);
            this.reel3.Name = "reel3";
            this.reel3.Size = new System.Drawing.Size(100, 94);
            this.reel3.TabIndex = 2;
            // 
            // reel2
            // 
            this.reel2.BackColor = System.Drawing.Color.White;
            this.reel2.Image = global::OneArmedBandit.Properties.Resources.cherry_100x125;
            this.reel2.Location = new System.Drawing.Point(229, 174);
            this.reel2.Name = "reel2";
            this.reel2.Size = new System.Drawing.Size(100, 94);
            this.reel2.TabIndex = 1;
            // 
            // reel1
            // 
            this.reel1.BackColor = System.Drawing.Color.White;
            this.reel1.Image = global::OneArmedBandit.Properties.Resources._7_100x125;
            this.reel1.Location = new System.Drawing.Point(114, 174);
            this.reel1.Name = "reel1";
            this.reel1.Size = new System.Drawing.Size(99, 94);
            this.reel1.TabIndex = 0;
            // 
            // coinLabel
            // 
            this.coinLabel.BackColor = System.Drawing.Color.Transparent;
            this.coinLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinLabel.ForeColor = System.Drawing.Color.White;
            this.coinLabel.Location = new System.Drawing.Point(16, 362);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(84, 48);
            this.coinLabel.TabIndex = 6;
            this.coinLabel.Text = "Coins:";
            this.coinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OneArmedBandit.Properties.Resources.slotBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(559, 413);
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.scoreDisplay);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.reel3);
            this.Controls.Add(this.reel2);
            this.Controls.Add(this.reel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Central Slots";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label reel1;
        private System.Windows.Forms.Label reel2;
        private System.Windows.Forms.Label reel3;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label scoreDisplay;
        private System.Windows.Forms.Label coinLabel;
    }
}

