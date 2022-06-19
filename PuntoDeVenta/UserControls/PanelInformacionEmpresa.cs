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
    public partial class PanelInformacionEmpresa : UserControl
    {
        private Panel panelMain;
        private Panel panelControl;
        private Empresa empresa;
        private Enterprise enterprise;
        private Siticone.UI.WinForms.SiticoneButton buttonAdd;

        public PanelInformacionEmpresa(Panel _panelMain,Panel _panelControl, Siticone.UI.WinForms.SiticoneButton _buttonAdd)
        {
            InitializeComponent();
            panelMain = _panelMain;
            panelControl = _panelControl;
            buttonAdd = _buttonAdd;
            textBoxName.Font = new Font(textBoxName.Font.Name, 16, textBoxName.Font.Style, textBoxName.Font.Unit);
            textBoxEmail.Font = new Font(textBoxEmail.Font.Name, 16, textBoxEmail.Font.Style, textBoxEmail.Font.Unit);
            textBoxRfc.Font = new Font(textBoxRfc.Font.Name, 16, textBoxRfc.Font.Style, textBoxRfc.Font.Unit);
        }

        private void PanelInformacionEmpresa_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0 && textBoxEmail.Text.Length > 0 && textBoxRfc.Text.Length > 0)
            {
                if (empresa != null)
                {
                    enterprise.SetNameEnterprise(textBoxName.Text);
                    enterprise.SetEmail(textBoxEmail.Text);
                    enterprise.SetRFC(textBoxRfc.Text);
                    panelMain.Controls.Find("Enterprise", false)[0].BringToFront();
                }
                else
                {
                    enterprise = new Enterprise(textBoxName.Text, textBoxEmail.Text, textBoxRfc.Text);
                    empresa = new Empresa(textBoxName.Text, textBoxEmail.Text, textBoxRfc.Text);
                    panelMain.Controls.Add(enterprise);
                    panelMain.Controls.Find("Enterprise", false)[0].BringToFront();
                    panelControl.Controls.Remove(buttonAdd);
                }
            }
        }
    }
}
