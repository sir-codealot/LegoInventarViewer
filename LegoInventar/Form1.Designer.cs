namespace LegoInventar
{
    partial class mainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.btn_browse = new System.Windows.Forms.Button();
            this.txtbx_source_path = new System.Windows.Forms.TextBox();
            this.lbl_source = new System.Windows.Forms.Label();
            this.lstbx_lego_sets = new System.Windows.Forms.ListBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_listlabel = new System.Windows.Forms.Label();
            this.grpbx_set_details = new System.Windows.Forms.GroupBox();
            this.lbl_price_per_brick = new System.Windows.Forms.Label();
            this.lbl_market_price = new System.Windows.Forms.Label();
            this.lbl_uvp_price = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_subgenre = new System.Windows.Forms.Label();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_brick_count = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_price_per_brick_desc = new System.Windows.Forms.Label();
            this.lbl_market_price_desc = new System.Windows.Forms.Label();
            this.lbl_uvp_price_desc = new System.Windows.Forms.Label();
            this.lbl_location_desc = new System.Windows.Forms.Label();
            this.lbl_year_desc = new System.Windows.Forms.Label();
            this.lbl_subgenre_desc = new System.Windows.Forms.Label();
            this.lbl_genre_desc = new System.Windows.Forms.Label();
            this.lbl_brick_count_desc = new System.Windows.Forms.Label();
            this.lbl_name_desc = new System.Windows.Forms.Label();
            this.lbl_number_desc = new System.Windows.Forms.Label();
            this.picbx_preview = new System.Windows.Forms.PictureBox();
            this.grpbx_pic_preview = new System.Windows.Forms.GroupBox();
            this.lbl_image_fallback = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.grpbx_set_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_preview)).BeginInit();
            this.grpbx_pic_preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(645, 11);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(96, 20);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Durchsuchen";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txtbx_source_path
            // 
            this.txtbx_source_path.Location = new System.Drawing.Point(85, 12);
            this.txtbx_source_path.Name = "txtbx_source_path";
            this.txtbx_source_path.Size = new System.Drawing.Size(554, 20);
            this.txtbx_source_path.TabIndex = 1;
            // 
            // lbl_source
            // 
            this.lbl_source.AutoSize = true;
            this.lbl_source.Location = new System.Drawing.Point(20, 15);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(62, 13);
            this.lbl_source.TabIndex = 2;
            this.lbl_source.Text = "Quell-Datei:";
            // 
            // lstbx_lego_sets
            // 
            this.lstbx_lego_sets.FormattingEnabled = true;
            this.lstbx_lego_sets.Location = new System.Drawing.Point(23, 93);
            this.lstbx_lego_sets.Name = "lstbx_lego_sets";
            this.lstbx_lego_sets.Size = new System.Drawing.Size(210, 303);
            this.lstbx_lego_sets.TabIndex = 3;
            this.lstbx_lego_sets.SelectedIndexChanged += new System.EventHandler(this.lstbx_lego_sets_SelectedIndexChanged);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(747, 11);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(96, 20);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Laden";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_listlabel
            // 
            this.lbl_listlabel.AutoSize = true;
            this.lbl_listlabel.Location = new System.Drawing.Point(23, 74);
            this.lbl_listlabel.Name = "lbl_listlabel";
            this.lbl_listlabel.Size = new System.Drawing.Size(28, 13);
            this.lbl_listlabel.TabIndex = 4;
            this.lbl_listlabel.Text = "Sets";
            // 
            // grpbx_set_details
            // 
            this.grpbx_set_details.Controls.Add(this.lbl_price_per_brick);
            this.grpbx_set_details.Controls.Add(this.lbl_market_price);
            this.grpbx_set_details.Controls.Add(this.lbl_uvp_price);
            this.grpbx_set_details.Controls.Add(this.lbl_location);
            this.grpbx_set_details.Controls.Add(this.lbl_year);
            this.grpbx_set_details.Controls.Add(this.lbl_subgenre);
            this.grpbx_set_details.Controls.Add(this.lbl_genre);
            this.grpbx_set_details.Controls.Add(this.lbl_brick_count);
            this.grpbx_set_details.Controls.Add(this.lbl_name);
            this.grpbx_set_details.Controls.Add(this.lbl_number);
            this.grpbx_set_details.Controls.Add(this.lbl_price_per_brick_desc);
            this.grpbx_set_details.Controls.Add(this.lbl_market_price_desc);
            this.grpbx_set_details.Controls.Add(this.lbl_uvp_price_desc);
            this.grpbx_set_details.Controls.Add(this.lbl_location_desc);
            this.grpbx_set_details.Controls.Add(this.lbl_year_desc);
            this.grpbx_set_details.Controls.Add(this.lbl_subgenre_desc);
            this.grpbx_set_details.Controls.Add(this.lbl_genre_desc);
            this.grpbx_set_details.Controls.Add(this.lbl_brick_count_desc);
            this.grpbx_set_details.Controls.Add(this.lbl_name_desc);
            this.grpbx_set_details.Controls.Add(this.lbl_number_desc);
            this.grpbx_set_details.Location = new System.Drawing.Point(265, 93);
            this.grpbx_set_details.Name = "grpbx_set_details";
            this.grpbx_set_details.Size = new System.Drawing.Size(359, 303);
            this.grpbx_set_details.TabIndex = 5;
            this.grpbx_set_details.TabStop = false;
            this.grpbx_set_details.Text = "Set-Details";
            // 
            // lbl_price_per_brick
            // 
            this.lbl_price_per_brick.AutoSize = true;
            this.lbl_price_per_brick.Location = new System.Drawing.Point(129, 227);
            this.lbl_price_per_brick.Name = "lbl_price_per_brick";
            this.lbl_price_per_brick.Size = new System.Drawing.Size(10, 13);
            this.lbl_price_per_brick.TabIndex = 1;
            this.lbl_price_per_brick.Text = "-";
            this.lbl_price_per_brick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_market_price
            // 
            this.lbl_market_price.AutoSize = true;
            this.lbl_market_price.Location = new System.Drawing.Point(129, 204);
            this.lbl_market_price.Name = "lbl_market_price";
            this.lbl_market_price.Size = new System.Drawing.Size(10, 13);
            this.lbl_market_price.TabIndex = 1;
            this.lbl_market_price.Text = "-";
            this.lbl_market_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_uvp_price
            // 
            this.lbl_uvp_price.AutoSize = true;
            this.lbl_uvp_price.Location = new System.Drawing.Point(129, 181);
            this.lbl_uvp_price.Name = "lbl_uvp_price";
            this.lbl_uvp_price.Size = new System.Drawing.Size(10, 13);
            this.lbl_uvp_price.TabIndex = 1;
            this.lbl_uvp_price.Text = "-";
            this.lbl_uvp_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(129, 158);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(10, 13);
            this.lbl_location.TabIndex = 1;
            this.lbl_location.Text = "-";
            this.lbl_location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(129, 135);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(10, 13);
            this.lbl_year.TabIndex = 1;
            this.lbl_year.Text = "-";
            this.lbl_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_subgenre
            // 
            this.lbl_subgenre.AutoSize = true;
            this.lbl_subgenre.Location = new System.Drawing.Point(129, 112);
            this.lbl_subgenre.Name = "lbl_subgenre";
            this.lbl_subgenre.Size = new System.Drawing.Size(10, 13);
            this.lbl_subgenre.TabIndex = 1;
            this.lbl_subgenre.Text = "-";
            this.lbl_subgenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Location = new System.Drawing.Point(129, 89);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(10, 13);
            this.lbl_genre.TabIndex = 1;
            this.lbl_genre.Text = "-";
            this.lbl_genre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_brick_count
            // 
            this.lbl_brick_count.AutoSize = true;
            this.lbl_brick_count.Location = new System.Drawing.Point(129, 66);
            this.lbl_brick_count.Name = "lbl_brick_count";
            this.lbl_brick_count.Size = new System.Drawing.Size(10, 13);
            this.lbl_brick_count.TabIndex = 1;
            this.lbl_brick_count.Text = "-";
            this.lbl_brick_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(129, 43);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(10, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "-";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(129, 20);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(10, 13);
            this.lbl_number.TabIndex = 1;
            this.lbl_number.Text = "-";
            this.lbl_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price_per_brick_desc
            // 
            this.lbl_price_per_brick_desc.AutoSize = true;
            this.lbl_price_per_brick_desc.Location = new System.Drawing.Point(8, 227);
            this.lbl_price_per_brick_desc.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_price_per_brick_desc.Name = "lbl_price_per_brick_desc";
            this.lbl_price_per_brick_desc.Size = new System.Drawing.Size(68, 13);
            this.lbl_price_per_brick_desc.TabIndex = 0;
            this.lbl_price_per_brick_desc.Text = "Preis / Stein:";
            this.lbl_price_per_brick_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_market_price_desc
            // 
            this.lbl_market_price_desc.AutoSize = true;
            this.lbl_market_price_desc.Location = new System.Drawing.Point(8, 204);
            this.lbl_market_price_desc.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_market_price_desc.Name = "lbl_market_price_desc";
            this.lbl_market_price_desc.Size = new System.Drawing.Size(67, 13);
            this.lbl_market_price_desc.TabIndex = 0;
            this.lbl_market_price_desc.Text = "Preis aktuell:";
            this.lbl_market_price_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_uvp_price_desc
            // 
            this.lbl_uvp_price_desc.AutoSize = true;
            this.lbl_uvp_price_desc.Location = new System.Drawing.Point(8, 181);
            this.lbl_uvp_price_desc.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_uvp_price_desc.Name = "lbl_uvp_price_desc";
            this.lbl_uvp_price_desc.Size = new System.Drawing.Size(58, 13);
            this.lbl_uvp_price_desc.TabIndex = 0;
            this.lbl_uvp_price_desc.Text = "Preis UVP:";
            this.lbl_uvp_price_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_location_desc
            // 
            this.lbl_location_desc.AutoSize = true;
            this.lbl_location_desc.Location = new System.Drawing.Point(7, 158);
            this.lbl_location_desc.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_location_desc.Name = "lbl_location_desc";
            this.lbl_location_desc.Size = new System.Drawing.Size(79, 13);
            this.lbl_location_desc.TabIndex = 0;
            this.lbl_location_desc.Text = "Aufbewahrung:";
            this.lbl_location_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_year_desc
            // 
            this.lbl_year_desc.AutoSize = true;
            this.lbl_year_desc.Location = new System.Drawing.Point(8, 135);
            this.lbl_year_desc.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_year_desc.Name = "lbl_year_desc";
            this.lbl_year_desc.Size = new System.Drawing.Size(30, 13);
            this.lbl_year_desc.TabIndex = 0;
            this.lbl_year_desc.Text = "Jahr:";
            this.lbl_year_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_subgenre_desc
            // 
            this.lbl_subgenre_desc.AutoSize = true;
            this.lbl_subgenre_desc.Location = new System.Drawing.Point(8, 112);
            this.lbl_subgenre_desc.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_subgenre_desc.Name = "lbl_subgenre_desc";
            this.lbl_subgenre_desc.Size = new System.Drawing.Size(61, 13);
            this.lbl_subgenre_desc.TabIndex = 0;
            this.lbl_subgenre_desc.Text = "Sub-Genre:";
            this.lbl_subgenre_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_genre_desc
            // 
            this.lbl_genre_desc.AutoSize = true;
            this.lbl_genre_desc.Location = new System.Drawing.Point(8, 89);
            this.lbl_genre_desc.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_genre_desc.Name = "lbl_genre_desc";
            this.lbl_genre_desc.Size = new System.Drawing.Size(39, 13);
            this.lbl_genre_desc.TabIndex = 0;
            this.lbl_genre_desc.Text = "Genre:";
            this.lbl_genre_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_brick_count_desc
            // 
            this.lbl_brick_count_desc.AutoSize = true;
            this.lbl_brick_count_desc.Location = new System.Drawing.Point(8, 66);
            this.lbl_brick_count_desc.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_brick_count_desc.Name = "lbl_brick_count_desc";
            this.lbl_brick_count_desc.Size = new System.Drawing.Size(33, 13);
            this.lbl_brick_count_desc.TabIndex = 0;
            this.lbl_brick_count_desc.Text = "Teile:";
            this.lbl_brick_count_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name_desc
            // 
            this.lbl_name_desc.AutoSize = true;
            this.lbl_name_desc.Location = new System.Drawing.Point(7, 43);
            this.lbl_name_desc.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_name_desc.Name = "lbl_name_desc";
            this.lbl_name_desc.Size = new System.Drawing.Size(38, 13);
            this.lbl_name_desc.TabIndex = 0;
            this.lbl_name_desc.Text = "Name:";
            this.lbl_name_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_number_desc
            // 
            this.lbl_number_desc.AutoSize = true;
            this.lbl_number_desc.Location = new System.Drawing.Point(7, 20);
            this.lbl_number_desc.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_number_desc.Name = "lbl_number_desc";
            this.lbl_number_desc.Size = new System.Drawing.Size(49, 13);
            this.lbl_number_desc.TabIndex = 0;
            this.lbl_number_desc.Text = "Nummer:";
            this.lbl_number_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picbx_preview
            // 
            this.picbx_preview.Location = new System.Drawing.Point(6, 19);
            this.picbx_preview.Name = "picbx_preview";
            this.picbx_preview.Size = new System.Drawing.Size(329, 278);
            this.picbx_preview.TabIndex = 6;
            this.picbx_preview.TabStop = false;
            // 
            // grpbx_pic_preview
            // 
            this.grpbx_pic_preview.Controls.Add(this.lbl_image_fallback);
            this.grpbx_pic_preview.Controls.Add(this.picbx_preview);
            this.grpbx_pic_preview.Location = new System.Drawing.Point(631, 93);
            this.grpbx_pic_preview.Name = "grpbx_pic_preview";
            this.grpbx_pic_preview.Size = new System.Drawing.Size(341, 303);
            this.grpbx_pic_preview.TabIndex = 7;
            this.grpbx_pic_preview.TabStop = false;
            this.grpbx_pic_preview.Text = "Set-Bild";
            // 
            // lbl_image_fallback
            // 
            this.lbl_image_fallback.AutoSize = true;
            this.lbl_image_fallback.Location = new System.Drawing.Point(152, 135);
            this.lbl_image_fallback.Name = "lbl_image_fallback";
            this.lbl_image_fallback.Size = new System.Drawing.Size(48, 13);
            this.lbl_image_fallback.TabIndex = 7;
            this.lbl_image_fallback.Text = "Kein Bild";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(158, 69);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Suche";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 441);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.grpbx_pic_preview);
            this.Controls.Add(this.grpbx_set_details);
            this.Controls.Add(this.lstbx_lego_sets);
            this.Controls.Add(this.lbl_listlabel);
            this.Controls.Add(this.lbl_source);
            this.Controls.Add(this.txtbx_source_path);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Text = "Lego Inventar Viewer";
            this.grpbx_set_details.ResumeLayout(false);
            this.grpbx_set_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_preview)).EndInit();
            this.grpbx_pic_preview.ResumeLayout(false);
            this.grpbx_pic_preview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txtbx_source_path;
        private System.Windows.Forms.Label lbl_source;
        private System.Windows.Forms.ListBox lstbx_lego_sets;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lbl_listlabel;
        private System.Windows.Forms.GroupBox grpbx_set_details;
        private System.Windows.Forms.Label lbl_price_per_brick;
        private System.Windows.Forms.Label lbl_market_price;
        private System.Windows.Forms.Label lbl_uvp_price;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_subgenre;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_brick_count;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_price_per_brick_desc;
        private System.Windows.Forms.Label lbl_market_price_desc;
        private System.Windows.Forms.Label lbl_uvp_price_desc;
        private System.Windows.Forms.Label lbl_location_desc;
        private System.Windows.Forms.Label lbl_year_desc;
        private System.Windows.Forms.Label lbl_subgenre_desc;
        private System.Windows.Forms.Label lbl_genre_desc;
        private System.Windows.Forms.Label lbl_brick_count_desc;
        private System.Windows.Forms.Label lbl_name_desc;
        private System.Windows.Forms.Label lbl_number_desc;
        private System.Windows.Forms.PictureBox picbx_preview;
        private System.Windows.Forms.GroupBox grpbx_pic_preview;
        private System.Windows.Forms.Label lbl_image_fallback;
        private System.Windows.Forms.Button btn_search;
    }
}

