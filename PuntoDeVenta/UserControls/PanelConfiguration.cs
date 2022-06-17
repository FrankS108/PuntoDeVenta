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
    public partial class PanelConfiguration : UserControl
    {
        private VentanaPrincipal ventanaPrincipal;

        public PanelConfiguration(VentanaPrincipal _ventanaPrincipal)
        {
            InitializeComponent();
            ventanaPrincipal = _ventanaPrincipal;
            dollarText.Font = new Font(dollarText.Font.Name, 16, dollarText.Font.Style, dollarText.Font.Unit);
            buttonSave.Font = new Font(buttonSave.Font.Name, 20, buttonSave.Font.Style, buttonSave.Font.Unit);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            float dollar = float.Parse(dollarText.Text.ToString());
            ventanaPrincipal.SetDollar(dollar);
            dollarText.Clear();
        }
    }
}
