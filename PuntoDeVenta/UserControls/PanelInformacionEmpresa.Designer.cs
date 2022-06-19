
namespace PuntoDeVenta.UserControls
{
    partial class PanelInformacionEmpresa
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
            this.panelTitle = new Siticone.UI.WinForms.SiticonePanel();
            this.labelRfc = new Siticone.UI.WinForms.SiticoneLabel();
            this.labelEmail = new Siticone.UI.WinForms.SiticoneLabel();
            this.labelName = new Siticone.UI.WinForms.SiticoneLabel();
            this.textBoxRfc = new Siticone.UI.WinForms.SiticoneTextBox();
            this.textBoxEmail = new Siticone.UI.WinForms.SiticoneTextBox();
            this.textBoxName = new Siticone.UI.WinForms.SiticoneTextBox();
            this.buttonSave = new Siticone.UI.WinForms.SiticoneButton();
            this.panelStyle = new Siticone.UI.WinForms.SiticonePanel();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(101)))), ((int)(((byte)(225)))));
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.ShadowDecoration.Parent = this.panelTitle;
            this.panelTitle.Size = new System.Drawing.Size(873, 36);
            this.panelTitle.TabIndex = 6;
            // 
            // labelRfc
            // 
            this.labelRfc.BackColor = System.Drawing.Color.Transparent;
            this.labelRfc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRfc.Location = new System.Drawing.Point(39, 200);
            this.labelRfc.Name = "labelRfc";
            this.labelRfc.Size = new System.Drawing.Size(39, 32);
            this.labelRfc.TabIndex = 12;
            this.labelRfc.Text = "RFC";
            // 
            // labelEmail
            // 
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(39, 132);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 32);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email";
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(39, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 32);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Nombre";
            // 
            // textBoxRfc
            // 
            this.textBoxRfc.BorderRadius = 15;
            this.textBoxRfc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxRfc.DefaultText = "";
            this.textBoxRfc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxRfc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxRfc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxRfc.DisabledState.Parent = this.textBoxRfc;
            this.textBoxRfc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxRfc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxRfc.FocusedState.Parent = this.textBoxRfc;
            this.textBoxRfc.HideSelection = false;
            this.textBoxRfc.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxRfc.HoveredState.Parent = this.textBoxRfc;
            this.textBoxRfc.Location = new System.Drawing.Point(167, 200);
            this.textBoxRfc.Name = "textBoxRfc";
            this.textBoxRfc.PasswordChar = '\0';
            this.textBoxRfc.PlaceholderText = "";
            this.textBoxRfc.SelectedText = "";
            this.textBoxRfc.ShadowDecoration.Parent = this.textBoxRfc;
            this.textBoxRfc.Size = new System.Drawing.Size(361, 36);
            this.textBoxRfc.TabIndex = 9;
            this.textBoxRfc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderRadius = 15;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.DefaultText = "";
            this.textBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEmail.DisabledState.Parent = this.textBoxEmail;
            this.textBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxEmail.FocusedState.Parent = this.textBoxEmail;
            this.textBoxEmail.HideSelection = false;
            this.textBoxEmail.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxEmail.HoveredState.Parent = this.textBoxEmail;
            this.textBoxEmail.Location = new System.Drawing.Point(167, 132);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.PlaceholderText = "";
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.ShadowDecoration.Parent = this.textBoxEmail;
            this.textBoxEmail.Size = new System.Drawing.Size(361, 36);
            this.textBoxEmail.TabIndex = 8;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderRadius = 15;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.Parent = this.textBoxName;
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.FocusedState.Parent = this.textBoxName;
            this.textBoxName.HideSelection = false;
            this.textBoxName.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.HoveredState.Parent = this.textBoxName;
            this.textBoxName.Location = new System.Drawing.Point(167, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.SelectedText = "";
            this.textBoxName.ShadowDecoration.Parent = this.textBoxName;
            this.textBoxName.Size = new System.Drawing.Size(361, 36);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(101)))), ((int)(((byte)(225)))));
            this.buttonSave.CheckedState.Parent = this.buttonSave;
            this.buttonSave.CustomImages.Parent = this.buttonSave;
            this.buttonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(101)))), ((int)(((byte)(225)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.HoveredState.Parent = this.buttonSave;
            this.buttonSave.Location = new System.Drawing.Point(672, 200);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.ShadowDecoration.Parent = this.buttonSave;
            this.buttonSave.Size = new System.Drawing.Size(180, 45);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelStyle
            // 
            this.panelStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(101)))), ((int)(((byte)(225)))));
            this.panelStyle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStyle.Location = new System.Drawing.Point(0, 272);
            this.panelStyle.Name = "panelStyle";
            this.panelStyle.ShadowDecoration.Parent = this.panelStyle;
            this.panelStyle.Size = new System.Drawing.Size(873, 39);
            this.panelStyle.TabIndex = 14;
            // 
            // PanelInformacionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelStyle);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.labelRfc);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxRfc);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Name = "PanelInformacionEmpresa";
            this.Size = new System.Drawing.Size(873, 311);
            this.Load += new System.EventHandler(this.PanelInformacionEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel panelTitle;
        private Siticone.UI.WinForms.SiticoneLabel labelRfc;
        private Siticone.UI.WinForms.SiticoneLabel labelEmail;
        private Siticone.UI.WinForms.SiticoneLabel labelName;
        private Siticone.UI.WinForms.SiticoneTextBox textBoxRfc;
        private Siticone.UI.WinForms.SiticoneTextBox textBoxEmail;
        private Siticone.UI.WinForms.SiticoneTextBox textBoxName;
        private Siticone.UI.WinForms.SiticoneButton buttonSave;
        private Siticone.UI.WinForms.SiticonePanel panelStyle;
    }
}
