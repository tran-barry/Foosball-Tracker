namespace Foosball_Tracker
{
    partial class ViewPlayerForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.winRatioLabel = new System.Windows.Forms.Label();
            this.matchHistoryLabel = new System.Windows.Forms.Label();
            this.matchGrid = new System.Windows.Forms.DataGridView();
            this.viewMatchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(327, 221);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(106, 31);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Player: ";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsLabel.Location = new System.Drawing.Point(14, 49);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(106, 20);
            this.winsLabel.TabIndex = 2;
            this.winsLabel.Text = "Games Won: ";
            // 
            // lossesLabel
            // 
            this.lossesLabel.AutoSize = true;
            this.lossesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossesLabel.Location = new System.Drawing.Point(14, 69);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(104, 20);
            this.lossesLabel.TabIndex = 3;
            this.lossesLabel.Text = "Games Lost: ";
            // 
            // winRatioLabel
            // 
            this.winRatioLabel.AutoSize = true;
            this.winRatioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winRatioLabel.Location = new System.Drawing.Point(14, 89);
            this.winRatioLabel.Name = "winRatioLabel";
            this.winRatioLabel.Size = new System.Drawing.Size(114, 20);
            this.winRatioLabel.TabIndex = 4;
            this.winRatioLabel.Text = "Win Ratio (%): ";
            // 
            // matchHistoryLabel
            // 
            this.matchHistoryLabel.AutoSize = true;
            this.matchHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchHistoryLabel.Location = new System.Drawing.Point(14, 109);
            this.matchHistoryLabel.Name = "matchHistoryLabel";
            this.matchHistoryLabel.Size = new System.Drawing.Size(114, 20);
            this.matchHistoryLabel.TabIndex = 5;
            this.matchHistoryLabel.Text = "Match History: ";
            // 
            // matchGrid
            // 
            this.matchGrid.AllowUserToAddRows = false;
            this.matchGrid.AllowUserToDeleteRows = false;
            this.matchGrid.AllowUserToResizeColumns = false;
            this.matchGrid.AllowUserToResizeRows = false;
            this.matchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.matchGrid.Location = new System.Drawing.Point(12, 132);
            this.matchGrid.MultiSelect = false;
            this.matchGrid.Name = "matchGrid";
            this.matchGrid.ReadOnly = true;
            this.matchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.matchGrid.Size = new System.Drawing.Size(390, 83);
            this.matchGrid.TabIndex = 6;
            this.matchGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matchGrid_CellDoubleClick);
            // 
            // viewMatchButton
            // 
            this.viewMatchButton.Location = new System.Drawing.Point(12, 221);
            this.viewMatchButton.Name = "viewMatchButton";
            this.viewMatchButton.Size = new System.Drawing.Size(75, 23);
            this.viewMatchButton.TabIndex = 7;
            this.viewMatchButton.Text = "View Match";
            this.viewMatchButton.UseVisualStyleBackColor = true;
            this.viewMatchButton.Click += new System.EventHandler(this.viewMatchButton_Click);
            // 
            // ViewPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 256);
            this.Controls.Add(this.viewMatchButton);
            this.Controls.Add(this.matchGrid);
            this.Controls.Add(this.matchHistoryLabel);
            this.Controls.Add(this.winRatioLabel);
            this.Controls.Add(this.lossesLabel);
            this.Controls.Add(this.winsLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.OKButton);
            this.Name = "ViewPlayerForm";
            this.Text = "Barry\'s Foosball Tracker";
            this.Load += new System.EventHandler(this.ViewPlayerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.Label winRatioLabel;
        private System.Windows.Forms.Label matchHistoryLabel;
        private System.Windows.Forms.DataGridView matchGrid;
        private System.Windows.Forms.Button viewMatchButton;

    }
}