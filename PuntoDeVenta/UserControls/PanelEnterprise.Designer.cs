
namespace PuntoDeVenta.UserControls
{
    partial class PanelEnterprise
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelColorLeft = new Siticone.UI.WinForms.SiticonePanel();
            this.buttonAdd = new Siticone.UI.WinForms.SiticoneButton();
            this.buttonEdit = new Siticone.UI.WinForms.SiticoneButton();
            this.panelControl = new Siticone.UI.WinForms.SiticonePanel();
            this.panelStyleEdit = new Siticone.UI.WinForms.SiticonePanel();
            this.panelMain = new Siticone.UI.WinForms.SiticonePanel();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColorLeft
            // 
            this.panelColorLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(175)))), ((int)(((byte)(147)))));
            this.panelColorLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColorLeft.Location = new System.Drawing.Point(0, 0);
            this.panelColorLeft.Name = "panelColorLeft";
            this.panelColorLeft.ShadowDecoration.Parent = this.panelColorLeft;
            this.panelColorLeft.Size = new System.Drawing.Size(129, 555);
            this.panelColorLeft.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BorderRadius = 15;
            this.buttonAdd.CheckedState.Parent = this.buttonAdd;
            this.buttonAdd.CustomImages.Parent = this.buttonAdd;
            this.buttonAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(175)))), ((int)(((byte)(147)))));
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.HoveredState.Parent = this.buttonAdd;
            this.buttonAdd.Location = new System.Drawing.Point(3, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.ShadowDecoration.Parent = this.buttonAdd;
            this.buttonAdd.Size = new System.Drawing.Size(180, 45);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BorderRadius = 15;
            this.buttonEdit.CheckedState.Parent = this.buttonEdit;
            this.buttonEdit.CustomImages.Parent = this.buttonEdit;
            this.buttonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(175)))), ((int)(((byte)(147)))));
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.HoveredState.Parent = this.buttonEdit;
            this.buttonEdit.Location = new System.Drawing.Point(690, 24);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ShadowDecoration.Parent = this.buttonEdit;
            this.buttonEdit.Size = new System.Drawing.Size(180, 45);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panelStyleEdit);
            this.panelControl.Controls.Add(this.buttonAdd);
            this.panelControl.Controls.Add(this.buttonEdit);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(129, 482);
            this.panelControl.Name = "panelControl";
            this.panelControl.ShadowDecoration.Parent = this.panelControl;
            this.panelControl.Size = new System.Drawing.Size(873, 73);
            this.panelControl.TabIndex = 7;
            // 
            // panelStyleEdit
            // 
            this.panelStyleEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(175)))), ((int)(((byte)(147)))));
            this.panelStyleEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStyleEdit.Location = new System.Drawing.Point(0, 0);
            this.panelStyleEdit.Name = "panelStyleEdit";
            this.panelStyleEdit.ShadowDecoration.Parent = this.panelStyleEdit;
            this.panelStyleEdit.Size = new System.Drawing.Size(873, 18);
            this.panelStyleEdit.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(129, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.ShadowDecoration.Parent = this.panelMain;
            this.panelMain.Size = new System.Drawing.Size(873, 482);
            this.panelMain.TabIndex = 8;
            // 
            // PanelEnterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelColorLeft);
            this.Name = "PanelEnterprise";
            this.Size = new System.Drawing.Size(1002, 555);
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel panelColorLeft;
        private Siticone.UI.WinForms.SiticoneButton buttonAdd;
        private Siticone.UI.WinForms.SiticoneButton buttonEdit;
        private Siticone.UI.WinForms.SiticonePanel panelControl;
        private Siticone.UI.WinForms.SiticonePanel panelMain;
        private Siticone.UI.WinForms.SiticonePanel panelStyleEdit;
    }
}
