namespace LegoInventar
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.txtbx_f2_search = new System.Windows.Forms.TextBox();
            this.lbl_f2_number_desc = new System.Windows.Forms.Label();
            this.btn_f2_search = new System.Windows.Forms.Button();
            this.btn_f2_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_f2_search
            // 
            this.txtbx_f2_search.Location = new System.Drawing.Point(86, 6);
            this.txtbx_f2_search.Name = "txtbx_f2_search";
            this.txtbx_f2_search.Size = new System.Drawing.Size(100, 20);
            this.txtbx_f2_search.TabIndex = 0;
            // 
            // lbl_f2_number_desc
            // 
            this.lbl_f2_number_desc.AutoSize = true;
            this.lbl_f2_number_desc.Location = new System.Drawing.Point(12, 9);
            this.lbl_f2_number_desc.Name = "lbl_f2_number_desc";
            this.lbl_f2_number_desc.Size = new System.Drawing.Size(68, 13);
            this.lbl_f2_number_desc.TabIndex = 1;
            this.lbl_f2_number_desc.Text = "Set-Nummer:";
            // 
            // btn_f2_search
            // 
            this.btn_f2_search.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_f2_search.Location = new System.Drawing.Point(15, 32);
            this.btn_f2_search.Name = "btn_f2_search";
            this.btn_f2_search.Size = new System.Drawing.Size(75, 23);
            this.btn_f2_search.TabIndex = 2;
            this.btn_f2_search.Text = "Suche...";
            this.btn_f2_search.UseVisualStyleBackColor = true;
            this.btn_f2_search.Click += new System.EventHandler(this.btn_f2_search_Click);
            // 
            // btn_f2_cancel
            // 
            this.btn_f2_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_f2_cancel.Location = new System.Drawing.Point(111, 32);
            this.btn_f2_cancel.Name = "btn_f2_cancel";
            this.btn_f2_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_f2_cancel.TabIndex = 3;
            this.btn_f2_cancel.Text = "Abbruch";
            this.btn_f2_cancel.UseVisualStyleBackColor = true;
            this.btn_f2_cancel.Click += new System.EventHandler(this.btn_f2_cancel_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 66);
            this.ControlBox = false;
            this.Controls.Add(this.btn_f2_cancel);
            this.Controls.Add(this.btn_f2_search);
            this.Controls.Add(this.lbl_f2_number_desc);
            this.Controls.Add(this.txtbx_f2_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suche nach Set-Nummer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_f2_search;
        private System.Windows.Forms.Label lbl_f2_number_desc;
        private System.Windows.Forms.Button btn_f2_search;
        private System.Windows.Forms.Button btn_f2_cancel;
    }
}