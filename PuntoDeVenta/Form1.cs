using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVenta.UserControls;

namespace PuntoDeVenta
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            AddWindows();
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            SelectMenu(buttonShop.Name);
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            SelectMenu(buttonProducts.Name);
        }

        private void buttonConfiguration_Click(object sender, EventArgs e)
        {
            SelectMenu(buttonConfiguration.Name);
        }

        //Funciones Principales
        private void AddWindows()
        {
            WindowController.Controls.Add(new WindowShop());
            WindowController.Controls.Add(new WindowProducts());
        }

        //Botones de la izquierda
        private void SelectMenu(string uiSelected)
        {
            switch (uiSelected)
            {
                case "buttonShop":
                    WindowController.Controls.Find("WindowShop", false)[0].BringToFront();
                    break;
                case "buttonProducts":
                    WindowController.Controls.Find("WindowProducts", false)[0].BringToFront();
                    break;
                case "buttonConfiguration":
                    WindowController.Controls.Find("WindowShop", false)[0].BringToFront();
                    break;
            }
        }
    }
}
