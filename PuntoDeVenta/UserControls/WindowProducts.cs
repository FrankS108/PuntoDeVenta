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
    public partial class WindowProducts : UserControl
    {
        public WindowProducts()
        {
            InitializeComponent();
            AddWindows();
        }

        private void WindowProducts_Load(object sender, EventArgs e)
        {

        }

        private void AddWindows()
        {
            PanelMain.Controls.Add(new PanelSearch());
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

        private void viewSearch_Click(object sender, EventArgs e)
        {
            SelectWindow(viewSearch.Name);
        }
    }
}
