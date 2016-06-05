namespace ScintillaNET_FindReplaceDialog
{
    partial class GoToDialog
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
            this.lblCurrentLine = new MetroFramework.Controls.MetroLabel();
            this.txtCurrentLine = new MetroFramework.Controls.MetroTextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMaxLine = new MetroFramework.Controls.MetroTextBox();
            this.lblMaxLine = new MetroFramework.Controls.MetroLabel();
            this.txtGotoLine = new MetroFramework.Controls.MetroTextBox();
            this.lblGotoLine = new MetroFramework.Controls.MetroLabel();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentLine
            // 
            this.lblCurrentLine.AutoSize = true;
            this.lblCurrentLine.Location = new System.Drawing.Point(39, 16);
            this.lblCurrentLine.Name = "lblCurrentLine";
            this.lblCurrentLine.Size = new System.Drawing.Size(127, 19);
            this.lblCurrentLine.TabIndex = 0;
            this.lblCurrentLine.Text = "&Current line number";
            // 
            // txtCurrentLine
            // 
            // 
            // 
            // 
            this.txtCurrentLine.CustomButton.Image = null;
            this.txtCurrentLine.CustomButton.Location = new System.Drawing.Point(51, 2);
            this.txtCurrentLine.CustomButton.Name = "";
            this.txtCurrentLine.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCurrentLine.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurrentLine.CustomButton.TabIndex = 1;
            this.txtCurrentLine.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurrentLine.CustomButton.UseSelectable = true;
            this.txtCurrentLine.CustomButton.Visible = false;
            this.txtCurrentLine.Lines = new string[0];
            this.txtCurrentLine.Location = new System.Drawing.Point(172, 13);
            this.txtCurrentLine.MaxLength = 32767;
            this.txtCurrentLine.Name = "txtCurrentLine";
            this.txtCurrentLine.PasswordChar = '\0';
            this.txtCurrentLine.ReadOnly = true;
            this.txtCurrentLine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentLine.SelectedText = "";
            this.txtCurrentLine.SelectionLength = 0;
            this.txtCurrentLine.SelectionStart = 0;
            this.txtCurrentLine.Size = new System.Drawing.Size(75, 26);
            this.txtCurrentLine.TabIndex = 1;
            this.txtCurrentLine.UseSelectable = true;
            this.txtCurrentLine.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrentLine.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtMaxLine
            // 
            // 
            // 
            // 
            this.txtMaxLine.CustomButton.Image = null;
            this.txtMaxLine.CustomButton.Location = new System.Drawing.Point(51, 2);
            this.txtMaxLine.CustomButton.Name = "";
            this.txtMaxLine.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaxLine.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxLine.CustomButton.TabIndex = 1;
            this.txtMaxLine.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxLine.CustomButton.UseSelectable = true;
            this.txtMaxLine.CustomButton.Visible = false;
            this.txtMaxLine.Lines = new string[0];
            this.txtMaxLine.Location = new System.Drawing.Point(172, 45);
            this.txtMaxLine.MaxLength = 32767;
            this.txtMaxLine.Name = "txtMaxLine";
            this.txtMaxLine.PasswordChar = '\0';
            this.txtMaxLine.ReadOnly = true;
            this.txtMaxLine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxLine.SelectedText = "";
            this.txtMaxLine.SelectionLength = 0;
            this.txtMaxLine.SelectionStart = 0;
            this.txtMaxLine.Size = new System.Drawing.Size(75, 26);
            this.txtMaxLine.TabIndex = 3;
            this.txtMaxLine.UseSelectable = true;
            this.txtMaxLine.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxLine.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMaxLine
            // 
            this.lblMaxLine.AutoSize = true;
            this.lblMaxLine.Location = new System.Drawing.Point(12, 48);
            this.lblMaxLine.Name = "lblMaxLine";
            this.lblMaxLine.Size = new System.Drawing.Size(154, 19);
            this.lblMaxLine.TabIndex = 2;
            this.lblMaxLine.Text = "&Maxmimum line number";
            // 
            // txtGotoLine
            // 
            // 
            // 
            // 
            this.txtGotoLine.CustomButton.Image = null;
            this.txtGotoLine.CustomButton.Location = new System.Drawing.Point(51, 2);
            this.txtGotoLine.CustomButton.Name = "";
            this.txtGotoLine.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGotoLine.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGotoLine.CustomButton.TabIndex = 1;
            this.txtGotoLine.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGotoLine.CustomButton.UseSelectable = true;
            this.txtGotoLine.CustomButton.Visible = false;
            this.txtGotoLine.Lines = new string[0];
            this.txtGotoLine.Location = new System.Drawing.Point(172, 77);
            this.txtGotoLine.MaxLength = 32767;
            this.txtGotoLine.Name = "txtGotoLine";
            this.txtGotoLine.PasswordChar = '\0';
            this.txtGotoLine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGotoLine.SelectedText = "";
            this.txtGotoLine.SelectionLength = 0;
            this.txtGotoLine.SelectionStart = 0;
            this.txtGotoLine.Size = new System.Drawing.Size(75, 26);
            this.txtGotoLine.TabIndex = 5;
            this.txtGotoLine.UseSelectable = true;
            this.txtGotoLine.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGotoLine.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblGotoLine
            // 
            this.lblGotoLine.AutoSize = true;
            this.lblGotoLine.Location = new System.Drawing.Point(50, 80);
            this.lblGotoLine.Name = "lblGotoLine";
            this.lblGotoLine.Size = new System.Drawing.Size(116, 19);
            this.lblGotoLine.TabIndex = 4;
            this.lblGotoLine.Text = "&Go to line number";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(91, 109);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 26);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(172, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // GoToDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(261, 148);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtGotoLine);
            this.Controls.Add(this.lblGotoLine);
            this.Controls.Add(this.txtMaxLine);
            this.Controls.Add(this.lblMaxLine);
            this.Controls.Add(this.txtCurrentLine);
            this.Controls.Add(this.lblCurrentLine);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Go To Line";
            this.Activated += new System.EventHandler(this.GoToDialog_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoToDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCurrentLine;
        private MetroFramework.Controls.MetroTextBox txtCurrentLine;
        private System.Windows.Forms.ErrorProvider err;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroTextBox txtGotoLine;
        private MetroFramework.Controls.MetroLabel lblGotoLine;
        private MetroFramework.Controls.MetroTextBox txtMaxLine;
        private MetroFramework.Controls.MetroLabel lblMaxLine;
    }
}