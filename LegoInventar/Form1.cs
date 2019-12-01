using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Net;

namespace LegoInventar
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        OpenFileDialog fileDialog = new OpenFileDialog();
        String firstLine = "";
        String completeLine = "";
        List<string> setNumber = new List<string>();
        List<string> setName = new List<string>();
        List<string> setBrickCount = new List<string>();
        List<string> setGenre = new List<string>();
        List<string> setSubGenre = new List<string>();
        List<string> setLocation = new List<string>();
        List<string> setYear = new List<string>();
        List<string> setUVPprice = new List<string>();
        List<string> setMarketPrice = new List<string>();
        List<string> setPricePerBrick = new List<string>();

        
        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtbx_source_path.Text = fileDialog.FileName;
                    Properties.Settings.Default.lastUsedPath = txtbx_source_path.Text;
                }
                catch(SecurityException ex)
                {
                    MessageBox.Show($"Security Error.\n\nError Message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtbx_source_path.Text))
            {
                var reader = new StreamReader(txtbx_source_path.Text);
                int i = 0;

                firstLine = reader.ReadLine();
                var cathegories = firstLine.Split(';');
                
                while (!reader.EndOfStream)
                {
                    completeLine = reader.ReadLine();
                    var docItem = completeLine.Split(';');

                    setNumber.Add(docItem[0]);
                    setName.Add(docItem[1]);
                    setBrickCount.Add(docItem[2]);
                    setGenre.Add(docItem[3]);
                    setSubGenre.Add(docItem[4]);
                    setLocation.Add(docItem[5]);
                    setYear.Add(docItem[6]);
                    setUVPprice.Add(docItem[7]);
                    setMarketPrice.Add(docItem[8]);
                    setPricePerBrick.Add(docItem[9]);

                    lstbx_lego_sets.Items.Add(setNumber[i] + ": " + setName[i++]);
                }
            }
            else
            {
                MessageBox.Show("Datei nicht gefunden",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning) ;
            }
        }

        private void lstbx_lego_sets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newIndex = lstbx_lego_sets.SelectedIndex;

            lbl_number.Text         = setNumber[newIndex] == "" ? "-" : setNumber[newIndex];
            lbl_name.Text           = setName[newIndex] == "" ? "-" : setName[newIndex];
            lbl_brick_count.Text    = setBrickCount[newIndex] == "" ? "-" : setBrickCount[newIndex];
            lbl_genre.Text          = setGenre[newIndex] == "" ? "-" : setGenre[newIndex];
            lbl_subgenre.Text       = setSubGenre[newIndex] == "" ? "-" : setSubGenre[newIndex];
            lbl_year.Text           = setYear[newIndex] == "" ? "-" : setYear[newIndex];
            lbl_location.Text       = setLocation[newIndex] == "" ? "-" : setLocation[newIndex];
            lbl_uvp_price.Text      = setUVPprice[newIndex] == "" ? "-" : setUVPprice[newIndex];
            lbl_market_price.Text   = setMarketPrice[newIndex] == "" ? "-" : setMarketPrice[newIndex];
            lbl_price_per_brick.Text = setPricePerBrick[newIndex] == "" ? "-" : setPricePerBrick[newIndex];

            // Adding packshot
            try
            {
                picbx_preview.Image = loadImage(lbl_number.Text);
                picbx_preview.SizeMode = PictureBoxSizeMode.Zoom;
                lbl_image_fallback.Visible = false;
            }
            catch (Exception e1)
            {
                try
                {
                    picbx_preview.Image = loadImage(lbl_number.Text + "-1");
                    picbx_preview.SizeMode = PictureBoxSizeMode.Zoom;
                    lbl_image_fallback.Visible = false;
                }
                catch (Exception e2)
                {
                    picbx_preview.Image = null;
                    lbl_image_fallback.Visible = true;
                    //MessageBox.Show("Fehler beim Laden des Packshot-Bildes\n\n" + "Fehler: " + e2, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Image loadImage(String number)
        {
            HttpWebRequest imageRequest = (HttpWebRequest)HttpWebRequest.Create("https://images.brickset.com/sets/images/" + number + ".jpg");
            HttpWebResponse imageResponse = (HttpWebResponse)imageRequest.GetResponse();
            Stream imageStream = imageResponse.GetResponseStream();

            return Image.FromStream(imageStream);
        }

        // Suche-Button ueber ListView
        private void btn_search_Click_1(object sender, EventArgs e)
        {
            using(SearchForm searchForm = new SearchForm())
            {
                bool isFound = false;
                if(searchForm.ShowDialog() == DialogResult.OK)
                {
                    for (var i = 0; i < setNumber.Count(); i++)
                    {
                        if (setNumber[i] == searchForm.searchNumber)
                        {
                            lstbx_lego_sets.SetSelected(i, true);
                            isFound = true;
                            break;
                        }
                    }

                    if (!isFound)
                    {
                        MessageBox.Show("Set-Nummer nicht gefunden.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
    }
}
