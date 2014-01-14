namespace Foosball_Tracker
{
    partial class viewMatchForm
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
            this.playerALabel = new System.Windows.Forms.Label();
            this.playerBLabel = new System.Windows.Forms.Label();
            this.VSLabel = new System.Windows.Forms.Label();
            this.scoreALabel = new System.Windows.Forms.Label();
            this.scoreBLabel = new System.Windows.Forms.Label();
            this.resultALabel = new System.Windows.Forms.Label();
            this.resultBLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerALabel
            // 
            this.playerALabel.AutoSize = true;
            this.playerALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerALabel.Location = new System.Drawing.Point(10, 9);
            this.playerALabel.Name = "playerALabel";
            this.playerALabel.Size = new System.Drawing.Size(116, 31);
            this.playerALabel.TabIndex = 0;
            this.playerALabel.Text = "Player A";
            // 
            // playerBLabel
            // 
            this.playerBLabel.AutoSize = true;
            this.playerBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBLabel.Location = new System.Drawing.Point(294, 9);
            this.playerBLabel.Name = "playerBLabel";
            this.playerBLabel.Size = new System.Drawing.Size(116, 31);
            this.playerBLabel.TabIndex = 1;
            this.playerBLabel.Text = "Player B";
            this.playerBLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // VSLabel
            // 
            this.VSLabel.AutoSize = true;
            this.VSLabel.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSLabel.Location = new System.Drawing.Point(202, 60);
            this.VSLabel.Name = "VSLabel";
            this.VSLabel.Size = new System.Drawing.Size(83, 67);
            this.VSLabel.TabIndex = 2;
            this.VSLabel.Text = "VS";
            // 
            // scoreALabel
            // 
            this.scoreALabel.AutoSize = true;
            this.scoreALabel.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreALabel.Location = new System.Drawing.Point(66, 60);
            this.scoreALabel.Name = "scoreALabel";
            this.scoreALabel.Size = new System.Drawing.Size(62, 67);
            this.scoreALabel.TabIndex = 3;
            this.scoreALabel.Text = "0";
            // 
            // scoreBLabel
            // 
            this.scoreBLabel.AutoSize = true;
            this.scoreBLabel.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBLabel.Location = new System.Drawing.Point(348, 60);
            this.scoreBLabel.Name = "scoreBLabel";
            this.scoreBLabel.Size = new System.Drawing.Size(62, 67);
            this.scoreBLabel.TabIndex = 4;
            this.scoreBLabel.Text = "0";
            // 
            // resultALabel
            // 
            this.resultALabel.AutoSize = true;
            this.resultALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultALabel.Location = new System.Drawing.Point(12, 142);
            this.resultALabel.Name = "resultALabel";
            this.resultALabel.Size = new System.Drawing.Size(96, 24);
            this.resultALabel.TabIndex = 5;
            this.resultALabel.Text = "The Loser";
            // 
            // resultBLabel
            // 
            this.resultBLabel.AutoSize = true;
            this.resultBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBLabel.Location = new System.Drawing.Point(296, 142);
            this.resultBLabel.Name = "resultBLabel";
            this.resultBLabel.Size = new System.Drawing.Size(96, 24);
            this.resultBLabel.TabIndex = 6;
            this.resultBLabel.Text = "The Loser";
            this.resultBLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // viewMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 175);
            this.Controls.Add(this.resultBLabel);
            this.Controls.Add(this.resultALabel);
            this.Controls.Add(this.scoreBLabel);
            this.Controls.Add(this.scoreALabel);
            this.Controls.Add(this.VSLabel);
            this.Controls.Add(this.playerBLabel);
            this.Controls.Add(this.playerALabel);
            this.Name = "viewMatchForm";
            this.Text = "viewMatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerALabel;
        private System.Windows.Forms.Label playerBLabel;
        private System.Windows.Forms.Label VSLabel;
        private System.Windows.Forms.Label scoreALabel;
        private System.Windows.Forms.Label scoreBLabel;
        private System.Windows.Forms.Label resultALabel;
        private System.Windows.Forms.Label resultBLabel;
    }
}