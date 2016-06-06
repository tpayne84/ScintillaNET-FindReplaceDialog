namespace ScintillaNET_FindReplaceDialog
{
    partial class IncrementalSearcher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncrementalSearcher));
            this.tlpIncrementalSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblFind = new MetroFramework.Controls.MetroLabel();
            this.btnClearHighlights = new MetroFramework.Controls.MetroButton();
            this.txtFind = new MetroFramework.Controls.MetroTextBox();
            this.btnHighlightAll = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            this.tlpIncrementalSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpIncrementalSearch
            // 
            this.tlpIncrementalSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpIncrementalSearch.ColumnCount = 6;
            this.tlpIncrementalSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpIncrementalSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIncrementalSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpIncrementalSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpIncrementalSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpIncrementalSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpIncrementalSearch.Controls.Add(this.lblFind, 0, 0);
            this.tlpIncrementalSearch.Controls.Add(this.btnClearHighlights, 5, 0);
            this.tlpIncrementalSearch.Controls.Add(this.txtFind, 1, 0);
            this.tlpIncrementalSearch.Controls.Add(this.btnHighlightAll, 4, 0);
            this.tlpIncrementalSearch.Controls.Add(this.btnNext, 2, 0);
            this.tlpIncrementalSearch.Controls.Add(this.btnPrevious, 3, 0);
            this.tlpIncrementalSearch.Location = new System.Drawing.Point(3, 0);
            this.tlpIncrementalSearch.Name = "tlpIncrementalSearch";
            this.tlpIncrementalSearch.RowCount = 1;
            this.tlpIncrementalSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpIncrementalSearch.Size = new System.Drawing.Size(330, 32);
            this.tlpIncrementalSearch.TabIndex = 9;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFind.Location = new System.Drawing.Point(3, 0);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(37, 33);
            this.lblFind.TabIndex = 3;
            this.lblFind.Text = "Find";
            this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearHighlights
            // 
            this.btnClearHighlights.BackColor = System.Drawing.Color.Transparent;
            this.btnClearHighlights.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearHighlights.BackgroundImage")));
            this.btnClearHighlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearHighlights.Location = new System.Drawing.Point(300, 3);
            this.btnClearHighlights.Name = "btnClearHighlights";
            this.btnClearHighlights.Size = new System.Drawing.Size(27, 27);
            this.btnClearHighlights.TabIndex = 6;
            this.btnClearHighlights.UseSelectable = true;
            // 
            // txtFind
            // 
            // 
            // 
            // 
            this.txtFind.CustomButton.Image = null;
            this.txtFind.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtFind.CustomButton.Name = "";
            this.txtFind.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFind.CustomButton.TabIndex = 1;
            this.txtFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFind.CustomButton.UseSelectable = true;
            this.txtFind.CustomButton.Visible = false;
            this.txtFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(46, 3);
            this.txtFind.MaxLength = 32767;
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.Size = new System.Drawing.Size(149, 27);
            this.txtFind.TabIndex = 7;
            this.txtFind.UseSelectable = true;
            this.txtFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnHighlightAll
            // 
            this.btnHighlightAll.BackColor = System.Drawing.Color.Transparent;
            this.btnHighlightAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHighlightAll.BackgroundImage")));
            this.btnHighlightAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHighlightAll.Location = new System.Drawing.Point(267, 3);
            this.btnHighlightAll.Name = "btnHighlightAll";
            this.btnHighlightAll.Size = new System.Drawing.Size(27, 27);
            this.btnHighlightAll.TabIndex = 5;
            this.btnHighlightAll.UseSelectable = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.BackgroundImage = global::ScintillaNET_FindReplaceDialog.Properties.Resources.next;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Location = new System.Drawing.Point(201, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 27);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseSelectable = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrevious.BackgroundImage = global::ScintillaNET_FindReplaceDialog.Properties.Resources.previous;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.Location = new System.Drawing.Point(234, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(27, 27);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.UseSelectable = true;
            // 
            // IncrementalSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tlpIncrementalSearch);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "IncrementalSearcher";
            this.Size = new System.Drawing.Size(336, 35);
            this.tlpIncrementalSearch.ResumeLayout(false);
            this.tlpIncrementalSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpIncrementalSearch;
        private MetroFramework.Controls.MetroLabel lblFind;
        private MetroFramework.Controls.MetroButton btnClearHighlights;
        private MetroFramework.Controls.MetroTextBox txtFind;
        private MetroFramework.Controls.MetroButton btnHighlightAll;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnPrevious;
    }
}
