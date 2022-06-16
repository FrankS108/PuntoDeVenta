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
            AddPanelsShop();
        }

        private void viewShop_Click(object sender, EventArgs e)
        {
            Console.WriteLine(viewShop.Name);
            SelectOptionShop(viewShop.Name);
        }

        private void searchShop_Click(object sender, EventArgs e)
        {
            SelectOptionShop(viewSearch.Name);
        }

        private void viewOffers_Click(object sender, EventArgs e)
        {
            SelectOptionShop(viewOffers.Name);
        }

        private void AddPanelsShop()
        {
            PanelMain.Controls.Add(new PanelShop());
            PanelMain.Controls.Add(new PanelSearch());
            PanelMain.Controls.Add(new PanelOfertas());
        }

        private void SelectOptionShop(string uiSelected)
        {
            switch (uiSelected)
            {
                case "viewShop":
                    PanelMain.Controls.Find("PanelShop", false)[0].BringToFront();
                    break;
                case "viewSearch":
                    PanelMain.Controls.Find("PanelSearch", false)[0].BringToFront();
                    break;
                case "viewOffers":
                    PanelMain.Controls.Find("PanelOfertas", false)[0].BringToFront();
                    break;
            }
        }
    }
}
