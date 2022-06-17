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
    public partial class PanelShop : UserControl
    {
        public PanelShop()
        {
            InitializeComponent();

            //Cambia la fuente del texto por una nueva *No quiere cambiar desde el controlador*
            dollarText.Font = new Font(dollarText.Font.Name, 22, dollarText.Font.Style, dollarText.Font.Unit);
            textTotal.Font = new Font(textTotal.Font.Name, 16, textTotal.Font.Style, textTotal.Font.Unit);
        }

        private void dollarText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetDollar(float dollar)
        {
            dollarText.Text = dollar.ToString();
        }
    }
}
