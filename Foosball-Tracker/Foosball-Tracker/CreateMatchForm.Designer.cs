namespace Foosball_Tracker
{
    partial class CreateMatchForm
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
            this.CreateMatchButton = new System.Windows.Forms.Button();
            this.playerABox = new System.Windows.Forms.ComboBox();
            this.playerALabel = new System.Windows.Forms.Label();
            this.playerBLabel = new System.Windows.Forms.Label();
            this.playerBBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.scoreALabel = new System.Windows.Forms.Label();
            this.AScoreBox = new System.Windows.Forms.ComboBox();
            this.scoreBLabel = new System.Windows.Forms.Label();
            this.BScoreBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CreateMatchButton
            // 
            this.CreateMatchButton.Location = new System.Drawing.Point(383, 92);
            this.CreateMatchButton.Name = "CreateMatchButton";
            this.CreateMatchButton.Size = new System.Drawing.Size(115, 23);
            this.CreateMatchButton.TabIndex = 0;
            this.CreateMatchButton.Text = "Create Match";
            this.CreateMatchButton.UseVisualStyleBackColor = true;
            this.CreateMatchButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // playerABox
            // 
            this.playerABox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerABox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerABox.FormattingEnabled = true;
            this.playerABox.Location = new System.Drawing.Point(89, 12);
            this.playerABox.Name = "playerABox";
            this.playerABox.Size = new System.Drawing.Size(156, 28);
            this.playerABox.TabIndex = 1;
            // 
            // playerALabel
            // 
            this.playerALabel.AutoSize = true;
            this.playerALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerALabel.Location = new System.Drawing.Point(12, 15);
            this.playerALabel.Name = "playerALabel";
            this.playerALabel.Size = new System.Drawing.Size(71, 20);
            this.playerALabel.TabIndex = 2;
            this.playerALabel.Text = "Player A:";
            // 
            // playerBLabel
            // 
            this.playerBLabel.AutoSize = true;
            this.playerBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBLabel.Location = new System.Drawing.Point(265, 15);
            this.playerBLabel.Name = "playerBLabel";
            this.playerBLabel.Size = new System.Drawing.Size(71, 20);
            this.playerBLabel.TabIndex = 4;
            this.playerBLabel.Text = "Player B:";
            // 
            // playerBBox
            // 
            this.playerBBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerBBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBBox.FormattingEnabled = true;
            this.playerBBox.Location = new System.Drawing.Point(342, 12);
            this.playerBBox.Name = "playerBBox";
            this.playerBBox.Size = new System.Drawing.Size(156, 28);
            this.playerBBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 92);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // scoreALabel
            // 
            this.scoreALabel.AutoSize = true;
            this.scoreALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreALabel.Location = new System.Drawing.Point(12, 49);
            this.scoreALabel.Name = "scoreALabel";
            this.scoreALabel.Size = new System.Drawing.Size(117, 20);
            this.scoreALabel.TabIndex = 7;
            this.scoreALabel.Text = "Player A Score:";
            // 
            // AScoreBox
            // 
            this.AScoreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AScoreBox.FormattingEnabled = true;
            this.AScoreBox.Location = new System.Drawing.Point(135, 46);
            this.AScoreBox.Name = "AScoreBox";
            this.AScoreBox.Size = new System.Drawing.Size(75, 28);
            this.AScoreBox.TabIndex = 6;
            // 
            // scoreBLabel
            // 
            this.scoreBLabel.AutoSize = true;
            this.scoreBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBLabel.Location = new System.Drawing.Point(300, 49);
            this.scoreBLabel.Name = "scoreBLabel";
            this.scoreBLabel.Size = new System.Drawing.Size(117, 20);
            this.scoreBLabel.TabIndex = 9;
            this.scoreBLabel.Text = "Player A Score:";
            // 
            // BScoreBox
            // 
            this.BScoreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BScoreBox.FormattingEnabled = true;
            this.BScoreBox.Location = new System.Drawing.Point(423, 46);
            this.BScoreBox.Name = "BScoreBox";
            this.BScoreBox.Size = new System.Drawing.Size(75, 28);
            this.BScoreBox.TabIndex = 8;
            // 
            // CreateMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 127);
            this.Controls.Add(this.scoreBLabel);
            this.Controls.Add(this.BScoreBox);
            this.Controls.Add(this.scoreALabel);
            this.Controls.Add(this.AScoreBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.playerBLabel);
            this.Controls.Add(this.playerBBox);
            this.Controls.Add(this.playerALabel);
            this.Controls.Add(this.playerABox);
            this.Controls.Add(this.CreateMatchButton);
            this.Name = "CreateMatchForm";
            this.Text = "Barry\'s Foosball Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateMatchButton;
        private System.Windows.Forms.ComboBox playerABox;
        private System.Windows.Forms.Label playerALabel;
        private System.Windows.Forms.Label playerBLabel;
        private System.Windows.Forms.ComboBox playerBBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label scoreALabel;
        private System.Windows.Forms.ComboBox AScoreBox;
        private System.Windows.Forms.Label scoreBLabel;
        private System.Windows.Forms.ComboBox BScoreBox;
    }
}