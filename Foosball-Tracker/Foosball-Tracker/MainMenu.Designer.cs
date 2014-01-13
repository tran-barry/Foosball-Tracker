namespace Foosball_Tracker
{
    partial class MainMenuForm
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
            this.CreatePlayerButton = new System.Windows.Forms.Button();
            this.ViewPlayerButton = new System.Windows.Forms.Button();
            this.CreateMatchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreatePlayerButton
            // 
            this.CreatePlayerButton.Location = new System.Drawing.Point(119, 111);
            this.CreatePlayerButton.Name = "CreatePlayerButton";
            this.CreatePlayerButton.Size = new System.Drawing.Size(194, 40);
            this.CreatePlayerButton.TabIndex = 0;
            this.CreatePlayerButton.Text = "Create Player";
            this.CreatePlayerButton.UseVisualStyleBackColor = true;
            this.CreatePlayerButton.Click += new System.EventHandler(this.CreatePlayer_Click);
            // 
            // ViewPlayerButton
            // 
            this.ViewPlayerButton.Location = new System.Drawing.Point(119, 157);
            this.ViewPlayerButton.Name = "ViewPlayerButton";
            this.ViewPlayerButton.Size = new System.Drawing.Size(194, 40);
            this.ViewPlayerButton.TabIndex = 1;
            this.ViewPlayerButton.Text = "View Player";
            this.ViewPlayerButton.UseVisualStyleBackColor = true;
            this.ViewPlayerButton.Click += new System.EventHandler(this.ViewPlayer_Click);
            // 
            // CreateMatchButton
            // 
            this.CreateMatchButton.Location = new System.Drawing.Point(119, 203);
            this.CreateMatchButton.Name = "CreateMatchButton";
            this.CreateMatchButton.Size = new System.Drawing.Size(194, 40);
            this.CreateMatchButton.TabIndex = 2;
            this.CreateMatchButton.Text = "Create Match";
            this.CreateMatchButton.UseVisualStyleBackColor = true;
            this.CreateMatchButton.Click += new System.EventHandler(this.CreateMatch_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(313, 247);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(124, 36);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(77, 37);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(276, 31);
            this.MainLabel.TabIndex = 4;
            this.MainLabel.Text = "Foosball Tracker v1.0";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(12, 270);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(156, 13);
            this.imageLabel.TabIndex = 5;
            this.imageLabel.Text = "Image from www.cutcaster.com";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Foosball_Tracker.Properties.Resources.MainMenuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(449, 295);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CreateMatchButton);
            this.Controls.Add(this.ViewPlayerButton);
            this.Controls.Add(this.CreatePlayerButton);
            this.Name = "MainMenuForm";
            this.Text = "Barry\'s Foosball Tracker";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePlayerButton;
        private System.Windows.Forms.Button ViewPlayerButton;
        private System.Windows.Forms.Button CreateMatchButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label imageLabel;
    }
}

