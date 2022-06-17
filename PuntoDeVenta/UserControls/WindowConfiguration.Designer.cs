
namespace PuntoDeVenta.UserControls
{
    partial class WindowConfiguration
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
            this.PanelMain = new Siticone.UI.WinForms.SiticonePanel();
            this.windowsPanel = new Siticone.UI.WinForms.SiticonePanel();
            this.viewConfiguration = new Siticone.UI.WinForms.SiticoneButton();
            this.windowsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 58);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.ShadowDecoration.Parent = this.PanelMain;
            this.PanelMain.Size = new System.Drawing.Size(1002, 555);
            this.PanelMain.TabIndex = 7;
            // 
            // windowsPanel
            // 
            this.windowsPanel.Controls.Add(this.viewConfiguration);
            this.windowsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowsPanel.Location = new System.Drawing.Point(0, 0);
            this.windowsPanel.Name = "windowsPanel";
            this.windowsPanel.ShadowDecoration.Parent = this.windowsPanel;
            this.windowsPanel.Size = new System.Drawing.Size(1002, 58);
            this.windowsPanel.TabIndex = 6;
            // 
            // viewConfiguration
            // 
            this.viewConfiguration.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.viewConfiguration.Checked = true;
            this.viewConfiguration.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.viewConfiguration.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewConfiguration.CheckedState.ForeColor = System.Drawing.Color.White;
            this.viewConfiguration.CheckedState.Parent = this.viewConfiguration;
            this.viewConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewConfiguration.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.viewConfiguration.CustomImages.Parent = this.viewConfiguration;
            this.viewConfiguration.FillColor = System.Drawing.Color.Transparent;
            this.viewConfiguration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewConfiguration.ForeColor = System.Drawing.Color.Black;
            this.viewConfiguration.HoveredState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewConfiguration.HoveredState.Parent = this.viewConfiguration;
            this.viewConfiguration.Location = new System.Drawing.Point(0, 0);
            this.viewConfiguration.Name = "viewConfiguration";
            this.viewConfiguration.ShadowDecoration.Parent = this.viewConfiguration;
            this.viewConfiguration.Size = new System.Drawing.Size(196, 58);
            this.viewConfiguration.TabIndex = 0;
            this.viewConfiguration.Text = "Configuración";
            this.viewConfiguration.Click += new System.EventHandler(this.viewConfiguration_Click);
            // 
            // WindowConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.windowsPanel);
            this.Name = "WindowConfiguration";
            this.Size = new System.Drawing.Size(1002, 613);
            this.windowsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel PanelMain;
        private Siticone.UI.WinForms.SiticonePanel windowsPanel;
        private Siticone.UI.WinForms.SiticoneButton viewConfiguration;
    }
}
