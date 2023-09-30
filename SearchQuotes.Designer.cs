namespace MegaDesk_JosueBenjaminCenturion
{
    partial class SearchQuotes
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
            this.BackMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackMainMenu
            // 
            this.BackMainMenu.AutoSize = true;
            this.BackMainMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackMainMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.BackMainMenu.Location = new System.Drawing.Point(12, 9);
            this.BackMainMenu.Name = "BackMainMenu";
            this.BackMainMenu.Padding = new System.Windows.Forms.Padding(5);
            this.BackMainMenu.Size = new System.Drawing.Size(98, 23);
            this.BackMainMenu.TabIndex = 1;
            this.BackMainMenu.Text = "Back Main Menu";
            this.BackMainMenu.Click += new System.EventHandler(this.BackMainMenu_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 344);
            this.Controls.Add(this.BackMainMenu);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackMainMenu;
    }
}