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
    public partial class Enterprise : UserControl
    {
        public Enterprise(string _name, string _email, string _rfc)
        {
            InitializeComponent();
            //textBoxName.Font = new Font(textBoxName.Font.Name, 16, textBoxName.Font.Style, textBoxName.Font.Unit);
            textEnterprise.Font = new Font(textEnterprise.Font.Name, 22, textEnterprise.Font.Style, textEnterprise.Font.Unit);
            textEmail.Font = new Font(textEmail.Font.Name, 18, textEmail.Font.Style, textEmail.Font.Unit);
            textRfc.Font = new Font(textRfc.Font.Name, 18, textRfc.Font.Style, textRfc.Font.Unit);


            textEnterprise.Text = _name;
            textEmail.Text = _email;
            textRfc.Text = _rfc;
        }

        public void SetNameEnterprise(string _name)
        {
            textEnterprise.Text = _name;
        }

        public void SetEmail(string _email)
        {
            textEmail.Text = _email;
        }

        public void SetRFC(string _rfc)
        {
            textRfc.Text = _rfc;
        }
    }
}
