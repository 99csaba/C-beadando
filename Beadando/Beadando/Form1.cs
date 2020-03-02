using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            Database data = new Database();
            bool Artist_used = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicDataSet2.Album' table. You can move, or remove it, as needed.
            this.albumTableAdapter1.Fill(this.musicDataSet2.Album);
            // TODO: This line of code loads data into the 'musicDataSet1.Album' table. You can move, or remove it, as needed.
            this.albumTableAdapter.Fill(this.musicDataSet1.Album);
            // TODO: This line of code loads data into the 'musicDataSet.Tracks' table. You can move, or remove it, as needed.
            this.tracksTableAdapter.Fill(this.musicDataSet.Tracks);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void eloadok_cbToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.albumTableAdapter.eloadok_cb(this.musicDataSet1.Album);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void eloadok_cbToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool used = false;
            var s =eloadok_cb.SelectedItem;
            
            if (eloadok_cb.SelectedItem.Equals(s))
            {
                used = true;
                album_cb.Enabled = true;
            }

        }

        private void eloadoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.albumTableAdapter.eloado(this.musicDataSet1.Album);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void eloadoToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.albumTableAdapter.eloado(this.musicDataSet1.Album);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
