
namespace PuntoDeVenta.UserControls
{
    partial class WindowShop
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
            this.viewOffers = new Siticone.UI.WinForms.SiticoneButton();
            this.viewSearch = new Siticone.UI.WinForms.SiticoneButton();
            this.viewShop = new Siticone.UI.WinForms.SiticoneButton();
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
            this.PanelMain.TabIndex = 5;
            // 
            // windowsPanel
            // 
            this.windowsPanel.Controls.Add(this.viewOffers);
            this.windowsPanel.Controls.Add(this.viewSearch);
            this.windowsPanel.Controls.Add(this.viewShop);
            this.windowsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowsPanel.Location = new System.Drawing.Point(0, 0);
            this.windowsPanel.Name = "windowsPanel";
            this.windowsPanel.ShadowDecoration.Parent = this.windowsPanel;
            this.windowsPanel.Size = new System.Drawing.Size(1002, 58);
            this.windowsPanel.TabIndex = 4;
            // 
            // viewOffers
            // 
            this.viewOffers.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.viewOffers.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.viewOffers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewOffers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.viewOffers.CheckedState.Parent = this.viewOffers;
            this.viewOffers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewOffers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.viewOffers.CustomImages.Parent = this.viewOffers;
            this.viewOffers.FillColor = System.Drawing.Color.Transparent;
            this.viewOffers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOffers.ForeColor = System.Drawing.Color.Black;
            this.viewOffers.HoveredState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewOffers.HoveredState.Parent = this.viewOffers;
            this.viewOffers.Location = new System.Drawing.Point(392, 0);
            this.viewOffers.Name = "viewOffers";
            this.viewOffers.ShadowDecoration.Parent = this.viewOffers;
            this.viewOffers.Size = new System.Drawing.Size(196, 58);
            this.viewOffers.TabIndex = 2;
            this.viewOffers.Text = "Ofertas";
            this.viewOffers.Click += new System.EventHandler(this.viewOffers_Click);
            // 
            // viewSearch
            // 
            this.viewSearch.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.viewSearch.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.viewSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewSearch.CheckedState.ForeColor = System.Drawing.Color.White;
            this.viewSearch.CheckedState.Parent = this.viewSearch;
            this.viewSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSearch.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.viewSearch.CustomImages.Parent = this.viewSearch;
            this.viewSearch.FillColor = System.Drawing.Color.Transparent;
            this.viewSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSearch.ForeColor = System.Drawing.Color.Black;
            this.viewSearch.HoveredState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewSearch.HoveredState.Parent = this.viewSearch;
            this.viewSearch.Location = new System.Drawing.Point(196, 0);
            this.viewSearch.Name = "viewSearch";
            this.viewSearch.ShadowDecoration.Parent = this.viewSearch;
            this.viewSearch.Size = new System.Drawing.Size(196, 58);
            this.viewSearch.TabIndex = 1;
            this.viewSearch.Text = "Buscar";
            this.viewSearch.Click += new System.EventHandler(this.viewSearch_Click);
            // 
            // viewShop
            // 
            this.viewShop.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.viewShop.Checked = true;
            this.viewShop.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.viewShop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewShop.CheckedState.ForeColor = System.Drawing.Color.White;
            this.viewShop.CheckedState.Parent = this.viewShop;
            this.viewShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewShop.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.viewShop.CustomImages.Parent = this.viewShop;
            this.viewShop.FillColor = System.Drawing.Color.Transparent;
            this.viewShop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewShop.ForeColor = System.Drawing.Color.Black;
            this.viewShop.HoveredState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewShop.HoveredState.Parent = this.viewShop;
            this.viewShop.Location = new System.Drawing.Point(0, 0);
            this.viewShop.Name = "viewShop";
            this.viewShop.ShadowDecoration.Parent = this.viewShop;
            this.viewShop.Size = new System.Drawing.Size(196, 58);
            this.viewShop.TabIndex = 0;
            this.viewShop.Text = "Tienda";
            this.viewShop.Click += new System.EventHandler(this.viewShop_Click);
            // 
            // WindowShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.windowsPanel);
            this.Name = "WindowShop";
            this.Size = new System.Drawing.Size(1002, 613);
            this.Load += new System.EventHandler(this.WindowShop_Load);
            this.windowsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel PanelMain;
        private Siticone.UI.WinForms.SiticonePanel windowsPanel;
        private Siticone.UI.WinForms.SiticoneButton viewOffers;
        private Siticone.UI.WinForms.SiticoneButton viewSearch;
        private Siticone.UI.WinForms.SiticoneButton viewShop;
    }
}
