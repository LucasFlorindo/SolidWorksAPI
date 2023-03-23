using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SWAPI objSW = new SWAPI();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirSW_Click(object sender, EventArgs e)
        {
         
            // Substituir (Visivel.Checked, Versão do seu SW);
            objSW.AbrirSolidworks(Visivel.Checked, 31);
        }

        private void chkinv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFecharSW_Click(object sender, EventArgs e)
        {

        }
    }
}
