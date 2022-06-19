using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVenta.Clases;

namespace PuntoDeVenta.UserControls
{
    public partial class PanelEnterprise : UserControl
    {
        private Empresa empresaAux = new Empresa();

        public PanelEnterprise()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Add(new PanelInformacionEmpresa(panelMain, panelControl, buttonAdd));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(empresaAux.GetCount());
            if (empresaAux.GetCount() > 0)
            {
                panelMain.Controls.Find("PanelInformacionEmpresa", false)[0].BringToFront();
            }
            
        }
    }
}
