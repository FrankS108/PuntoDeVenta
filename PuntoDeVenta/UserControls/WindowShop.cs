using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.UserControls
{
    public partial class WindowShop : UserControl
    {
        public WindowShop()
        {
            InitializeComponent();
            AddWindows();
        }

        private void WindowShop_Load(object sender, EventArgs e)
        {

        }

        private void viewShop_Click(object sender, EventArgs e)
        {
            SelectWindow(viewShop.Name);
        }

        private void viewSearch_Click(object sender, EventArgs e)
        {
            SelectWindow(viewSearch.Name);
        }

        private void viewOffers_Click(object sender, EventArgs e)
        {
            SelectWindow(viewOffers.Name);
        }

        private void AddWindows()
        {
            PanelMain.Controls.Add(new PanelShop());
            PanelMain.Controls.Add(new PanelSearch());
            PanelMain.Controls.Add(new PanelOfertas());
        }

        private void SelectWindow(string uiSelected)
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
