using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoraApp
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            this.WindowState= FormWindowState.Maximized;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            const string message =
        "Esta seguro que desea salir del sistema?";
            const string caption = "Confirmar salida";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                // cancel the closure of the form.
                this.Close();
            }
            
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            Informacion about = new Informacion();
            about.ShowDialog();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
