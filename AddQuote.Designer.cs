namespace MegaDesk_JosueBenjaminCenturion
{
    partial class AddNewQuoteForm
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
            this.components = new System.ComponentModel.Container();
            this.sendQuote = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.depthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.drawersTextBox = new System.Windows.Forms.TextBox();
            this.drawersErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.rushComboBox = new System.Windows.Forms.ComboBox();
            this.rushLabel = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sendQuote
            // 
            this.sendQuote.AutoSize = true;
            this.sendQuote.BackColor = System.Drawing.Color.RoyalBlue;
            this.sendQuote.ForeColor = System.Drawing.SystemColors.Control;
            this.sendQuote.Location = new System.Drawing.Point(306, 366);
            this.sendQuote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sendQuote.Name = "sendQuote";
            this.sendQuote.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.sendQuote.Size = new System.Drawing.Size(95, 28);
            this.sendQuote.TabIndex = 0;
            this.sendQuote.Text = "Send Quote ";
            this.sendQuote.Click += new System.EventHandler(this.sendQuote_Click);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(23, 81);
            this.customerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(44, 16);
            this.customerName.TabIndex = 1;
            this.customerName.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(20, 107);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(154, 24);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // widthErrorProvider
            // 
            this.widthErrorProvider.ContainerControl = this;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(20, 169);
            this.widthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(154, 22);
            this.widthTextBox.TabIndex = 3;
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextBox_Validating);
            this.widthTextBox.Validated += new System.EventHandler(this.widthTextBox_Validated);
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width.Location = new System.Drawing.Point(23, 143);
            this.Width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(90, 16);
            this.Width.TabIndex = 4;
            this.Width.Text = "Width (24 - 96)";
            this.Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(23, 206);
            this.depthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(95, 16);
            this.depthLabel.TabIndex = 5;
            this.depthLabel.Text = "Depth (12 - 48) ";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(20, 231);
            this.depthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(154, 22);
            this.depthTextBox.TabIndex = 6;
            this.depthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthTextBox_KeyPress);
            this.depthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.depthTextBox_Validating);
            // 
            // depthErrorProvider
            // 
            this.depthErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Num. Drawers (0 - 7)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drawersTextBox
            // 
            this.drawersTextBox.Location = new System.Drawing.Point(220, 107);
            this.drawersTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.drawersTextBox.Name = "drawersTextBox";
            this.drawersTextBox.Size = new System.Drawing.Size(181, 22);
            this.drawersTextBox.TabIndex = 6;
            this.drawersTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.drawersTextBox_Validating);
            // 
            // drawersErrorProvider
            // 
            this.drawersErrorProvider.ContainerControl = this;
            // 
            // materialComboBox
            // 
            this.materialComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(220, 167);
            this.materialComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(181, 24);
            this.materialComboBox.TabIndex = 7;
            this.materialComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.materialComboBox_Validating);
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(216, 143);
            this.materialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(58, 16);
            this.materialLabel.TabIndex = 1;
            this.materialLabel.Text = "Material ";
            // 
            // materialErrorProvider
            // 
            this.materialErrorProvider.ContainerControl = this;
            // 
            // rushComboBox
            // 
            this.rushComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushComboBox.FormattingEnabled = true;
            this.rushComboBox.Location = new System.Drawing.Point(220, 230);
            this.rushComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.rushComboBox.Name = "rushComboBox";
            this.rushComboBox.Size = new System.Drawing.Size(181, 24);
            this.rushComboBox.TabIndex = 8;
            this.rushComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.rushcomboBox_Validating);
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushLabel.Location = new System.Drawing.Point(216, 204);
            this.rushLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(132, 16);
            this.rushLabel.TabIndex = 1;
            this.rushLabel.Text = "Rush Order (In days) ";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.Location = new System.Drawing.Point(23, 366);
            this.currentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(44, 16);
            this.currentTime.TabIndex = 9;
            this.currentTime.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Back Main Menu";
            this.label2.Click += new System.EventHandler(this.BackMainMenu_Click);
            // 
            // AddNewQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 414);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.rushComboBox);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.drawersTextBox);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendQuote);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewQuoteForm";
            this.Text = "Add New Quote";
            this.Load += new System.EventHandler(this.AddNewQuoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sendQuote;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ErrorProvider widthErrorProvider;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.ErrorProvider depthErrorProvider;
        private System.Windows.Forms.TextBox drawersTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider drawersErrorProvider;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.ErrorProvider materialErrorProvider;
        private System.Windows.Forms.ComboBox rushComboBox;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label label2;
    }
}