using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoInventar
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        public String searchNumber { get { return txtbx_f2_search.Text; } }
        

        private void btn_f2_search_Click(object sender, EventArgs e)
        {
            Regex pattern = new Regex("[0-9-]");
            if (!pattern.IsMatch(txtbx_f2_search.Text))
            {
                MessageBox.Show("Ungültige Eingabe!\n" +
                                "Erlaubt sind Ziffern und '-'",
                                "Eingabefehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                //txtbx_f2_search.Text = "";
                this.DialogResult = DialogResult.None;
            }
        }

        private void btn_f2_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
