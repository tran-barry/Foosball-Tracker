namespace Foosball_Tracker
{
    partial class choosePlayerForm
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
            this.playerGrid = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // playerGrid
            // 
            this.playerGrid.AllowUserToAddRows = false;
            this.playerGrid.AllowUserToDeleteRows = false;
            this.playerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.playerGrid.Location = new System.Drawing.Point(12, 12);
            this.playerGrid.MultiSelect = false;
            this.playerGrid.Name = "playerGrid";
            this.playerGrid.ReadOnly = true;
            this.playerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playerGrid.ShowEditingIcon = false;
            this.playerGrid.Size = new System.Drawing.Size(565, 272);
            this.playerGrid.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(502, 290);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // choosePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 325);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.playerGrid);
            this.Name = "choosePlayerForm";
            this.Text = "Choose A Player";
            ((System.ComponentModel.ISupportInitialize)(this.playerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView playerGrid;
        private System.Windows.Forms.Button selectButton;

    }
}