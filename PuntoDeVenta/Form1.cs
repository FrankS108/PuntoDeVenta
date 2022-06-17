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
        private WindowShop windowShop;
        private WindowProducts windowProducts;
        private WindowConfiguration windowConfiguration;
        private PanelShop panelShop;

        public VentanaPrincipal()
        {
            InitializeComponent();
            windowShop = new WindowShop();
            windowProducts = new WindowProducts();
            windowConfiguration = new WindowConfiguration(this);
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
            WindowController.Controls.Add(windowShop);
            WindowController.Controls.Add(windowProducts);
            WindowController.Controls.Add(windowConfiguration);
        }

        //Botones de la izquierda
        private void SelectMenu(string uiSelected)
        {
            switch (uiSelected)
            {
                case "buttonShop":
                    WindowController.Controls.Find("windowShop", false)[0].BringToFront();
                    break;
                case "buttonProducts":
                    WindowController.Controls.Find("windowProducts", false)[0].BringToFront();
                    break;
                case "buttonConfiguration":
                    WindowController.Controls.Find("windowConfiguration", false)[0].BringToFront();
                    break;
            }
        }

        public void SetDollar(float dollar)
        {
            windowShop.SetDollarWindowShop(dollar);
        }
    }
}
