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
    public partial class WindowConfiguration : UserControl
    {
        private PanelConfiguration panelConfiguration;
        private PanelEnterprise panelEnterprise;
        private VentanaPrincipal ventanaPrincipal;
        public WindowConfiguration(VentanaPrincipal _ventanaPrincipal)
        {
            InitializeComponent();
            ventanaPrincipal = _ventanaPrincipal;
            panelConfiguration = new PanelConfiguration(ventanaPrincipal);
            panelEnterprise = new PanelEnterprise();
            AddWindows();
        }

        private void viewConfiguration_Click(object sender, EventArgs e)
        {
            SelectWindow(viewConfiguration.Name);
        }

        private void viewEnterprise_Click(object sender, EventArgs e)
        {
            SelectWindow(viewEnterprise.Name);
        }

        private void AddWindows()
        {
            PanelMain.Controls.Add(panelConfiguration);
            PanelMain.Controls.Add(panelEnterprise);
        }

        private void SelectWindow(string uiSelected)
        {
            switch (uiSelected)
            {
                case "viewConfiguration":
                    PanelMain.Controls.Find("PanelConfiguration", false)[0].BringToFront();
                    break;
                case "viewEnterprise":
                    PanelMain.Controls.Find("PanelEnterprise", false)[0].BringToFront();
                    break;
                case "viewOffers":
                    PanelMain.Controls.Find("PanelOfertas", false)[0].BringToFront();
                    break;
            }
        } 
    }
}
