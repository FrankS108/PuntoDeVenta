
namespace PuntoDeVenta.UserControls
{
    partial class PanelShop
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dollarsLabel = new Siticone.UI.WinForms.SiticoneLabel();
            this.PanelContent = new Siticone.UI.WinForms.SiticonePanel();
            this.PanelSubContent = new Siticone.UI.WinForms.SiticonePanel();
            this.DataShop = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.id = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelPay = new Siticone.UI.WinForms.SiticonePanel();
            this.textTotal = new Siticone.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.payButton = new Siticone.UI.WinForms.SiticoneButton();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.dollarText = new Siticone.UI.WinForms.SiticoneTextBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneCheckBox4 = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox3 = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox2 = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox1 = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PanelContent.SuspendLayout();
            this.PanelSubContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataShop)).BeginInit();
            this.PanelPay.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dollarsLabel
            // 
            this.dollarsLabel.BackColor = System.Drawing.Color.Transparent;
            this.dollarsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarsLabel.Location = new System.Drawing.Point(65, 24);
            this.dollarsLabel.Name = "dollarsLabel";
            this.dollarsLabel.Size = new System.Drawing.Size(49, 42);
            this.dollarsLabel.TabIndex = 0;
            this.dollarsLabel.Text = "Dlls";
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.PanelSubContent);
            this.PanelContent.Controls.Add(this.siticonePanel2);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.ShadowDecoration.Parent = this.PanelContent;
            this.PanelContent.Size = new System.Drawing.Size(1002, 555);
            this.PanelContent.TabIndex = 8;
            // 
            // PanelSubContent
            // 
            this.PanelSubContent.Controls.Add(this.DataShop);
            this.PanelSubContent.Controls.Add(this.PanelPay);
            this.PanelSubContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSubContent.Location = new System.Drawing.Point(196, 0);
            this.PanelSubContent.Name = "PanelSubContent";
            this.PanelSubContent.ShadowDecoration.Parent = this.PanelSubContent;
            this.PanelSubContent.Size = new System.Drawing.Size(806, 555);
            this.PanelSubContent.TabIndex = 9;
            // 
            // DataShop
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataShop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataShop.BackgroundColor = System.Drawing.Color.White;
            this.DataShop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataShop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataShop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataShop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataShop.ColumnHeadersHeight = 40;
            this.DataShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.count,
            this.price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataShop.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataShop.EnableHeadersVisualStyles = false;
            this.DataShop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataShop.Location = new System.Drawing.Point(0, 0);
            this.DataShop.Name = "DataShop";
            this.DataShop.RowHeadersVisible = false;
            this.DataShop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataShop.Size = new System.Drawing.Size(806, 491);
            this.DataShop.TabIndex = 9;
            this.DataShop.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataShop.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataShop.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataShop.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataShop.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataShop.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataShop.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataShop.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataShop.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataShop.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataShop.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataShop.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataShop.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataShop.ThemeStyle.HeaderStyle.Height = 40;
            this.DataShop.ThemeStyle.ReadOnly = false;
            this.DataShop.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataShop.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataShop.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataShop.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataShop.ThemeStyle.RowsStyle.Height = 22;
            this.DataShop.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataShop.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.FillWeight = 101.5228F;
            this.id.HeaderText = "Select";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.FillWeight = 99.49239F;
            this.name.HeaderText = "Product";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // count
            // 
            this.count.FillWeight = 99.49239F;
            this.count.HeaderText = "Cantidad";
            this.count.Name = "count";
            // 
            // price
            // 
            this.price.FillWeight = 99.49239F;
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // PanelPay
            // 
            this.PanelPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(188)))), ((int)(((byte)(107)))));
            this.PanelPay.BorderColor = System.Drawing.Color.Transparent;
            this.PanelPay.BorderRadius = 20;
            this.PanelPay.BorderThickness = 2;
            this.PanelPay.Controls.Add(this.textTotal);
            this.PanelPay.Controls.Add(this.label2);
            this.PanelPay.Controls.Add(this.payButton);
            this.PanelPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelPay.Location = new System.Drawing.Point(0, 491);
            this.PanelPay.Name = "PanelPay";
            this.PanelPay.ShadowDecoration.Parent = this.PanelPay;
            this.PanelPay.Size = new System.Drawing.Size(806, 64);
            this.PanelPay.TabIndex = 8;
            // 
            // textTotal
            // 
            this.textTotal.BorderRadius = 15;
            this.textTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTotal.DefaultText = "";
            this.textTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTotal.DisabledState.Parent = this.textTotal;
            this.textTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTotal.FocusedState.Parent = this.textTotal;
            this.textTotal.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTotal.HoveredState.Parent = this.textTotal;
            this.textTotal.Location = new System.Drawing.Point(423, 15);
            this.textTotal.Name = "textTotal";
            this.textTotal.PasswordChar = '\0';
            this.textTotal.PlaceholderText = "";
            this.textTotal.SelectedText = "";
            this.textTotal.ShadowDecoration.Parent = this.textTotal;
            this.textTotal.Size = new System.Drawing.Size(197, 36);
            this.textTotal.TabIndex = 2;
            this.textTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTotal.TextChanged += new System.EventHandler(this.textTotal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // payButton
            // 
            this.payButton.BorderRadius = 15;
            this.payButton.CheckedState.Parent = this.payButton;
            this.payButton.CustomImages.Parent = this.payButton;
            this.payButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(175)))), ((int)(((byte)(126)))));
            this.payButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.ForeColor = System.Drawing.Color.White;
            this.payButton.HoveredState.Parent = this.payButton;
            this.payButton.Location = new System.Drawing.Point(636, 6);
            this.payButton.Name = "payButton";
            this.payButton.ShadowDecoration.Parent = this.payButton;
            this.payButton.Size = new System.Drawing.Size(152, 51);
            this.payButton.TabIndex = 0;
            this.payButton.Text = "Pagar";
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(175)))), ((int)(((byte)(147)))));
            this.siticonePanel2.Controls.Add(this.dollarText);
            this.siticonePanel2.Controls.Add(this.siticoneLabel1);
            this.siticonePanel2.Controls.Add(this.siticoneCheckBox4);
            this.siticonePanel2.Controls.Add(this.siticoneCheckBox3);
            this.siticonePanel2.Controls.Add(this.siticoneCheckBox2);
            this.siticonePanel2.Controls.Add(this.siticoneCheckBox1);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(196, 555);
            this.siticonePanel2.TabIndex = 8;
            // 
            // dollarText
            // 
            this.dollarText.BorderRadius = 20;
            this.dollarText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dollarText.DefaultText = "0";
            this.dollarText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dollarText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dollarText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dollarText.DisabledState.Parent = this.dollarText;
            this.dollarText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dollarText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dollarText.FocusedState.Parent = this.dollarText;
            this.dollarText.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dollarText.HoveredState.Parent = this.dollarText;
            this.dollarText.Location = new System.Drawing.Point(13, 76);
            this.dollarText.Name = "dollarText";
            this.dollarText.PasswordChar = '\0';
            this.dollarText.PlaceholderText = "";
            this.dollarText.ReadOnly = true;
            this.dollarText.SelectedText = "";
            this.dollarText.ShadowDecoration.Parent = this.dollarText;
            this.dollarText.Size = new System.Drawing.Size(162, 52);
            this.dollarText.TabIndex = 6;
            this.dollarText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dollarText.TextChanged += new System.EventHandler(this.dollarText_TextChanged);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(61, 36);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(60, 34);
            this.siticoneLabel1.TabIndex = 5;
            this.siticoneLabel1.Text = "Dolar";
            // 
            // siticoneCheckBox4
            // 
            this.siticoneCheckBox4.AutoSize = true;
            this.siticoneCheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox4.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox4.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCheckBox4.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox4.Location = new System.Drawing.Point(25, 491);
            this.siticoneCheckBox4.Name = "siticoneCheckBox4";
            this.siticoneCheckBox4.Size = new System.Drawing.Size(96, 34);
            this.siticoneCheckBox4.TabIndex = 4;
            this.siticoneCheckBox4.Text = "Option";
            this.siticoneCheckBox4.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.siticoneCheckBox4.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox4.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox4.UncheckedState.FillColor = System.Drawing.Color.White;
            this.siticoneCheckBox4.UseVisualStyleBackColor = true;
            // 
            // siticoneCheckBox3
            // 
            this.siticoneCheckBox3.AutoSize = true;
            this.siticoneCheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox3.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox3.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCheckBox3.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox3.Location = new System.Drawing.Point(25, 449);
            this.siticoneCheckBox3.Name = "siticoneCheckBox3";
            this.siticoneCheckBox3.Size = new System.Drawing.Size(96, 34);
            this.siticoneCheckBox3.TabIndex = 3;
            this.siticoneCheckBox3.Text = "Option";
            this.siticoneCheckBox3.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.siticoneCheckBox3.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox3.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox3.UncheckedState.FillColor = System.Drawing.Color.White;
            this.siticoneCheckBox3.UseVisualStyleBackColor = true;
            // 
            // siticoneCheckBox2
            // 
            this.siticoneCheckBox2.AutoSize = true;
            this.siticoneCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox2.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCheckBox2.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox2.Location = new System.Drawing.Point(25, 407);
            this.siticoneCheckBox2.Name = "siticoneCheckBox2";
            this.siticoneCheckBox2.Size = new System.Drawing.Size(96, 34);
            this.siticoneCheckBox2.TabIndex = 2;
            this.siticoneCheckBox2.Text = "Option";
            this.siticoneCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.siticoneCheckBox2.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox2.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.UncheckedState.FillColor = System.Drawing.Color.White;
            this.siticoneCheckBox2.UseVisualStyleBackColor = true;
            // 
            // siticoneCheckBox1
            // 
            this.siticoneCheckBox1.AutoSize = true;
            this.siticoneCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCheckBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox1.Location = new System.Drawing.Point(25, 365);
            this.siticoneCheckBox1.Name = "siticoneCheckBox1";
            this.siticoneCheckBox1.Size = new System.Drawing.Size(96, 34);
            this.siticoneCheckBox1.TabIndex = 1;
            this.siticoneCheckBox1.Text = "Option";
            this.siticoneCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.siticoneCheckBox1.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.siticoneCheckBox1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // PanelShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContent);
            this.Name = "PanelShop";
            this.Size = new System.Drawing.Size(1002, 555);
            this.PanelContent.ResumeLayout(false);
            this.PanelSubContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataShop)).EndInit();
            this.PanelPay.ResumeLayout(false);
            this.PanelPay.PerformLayout();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneLabel dollarsLabel;
        private Siticone.UI.WinForms.SiticonePanel PanelContent;
        private Siticone.UI.WinForms.SiticonePanel PanelSubContent;
        private Siticone.UI.WinForms.SiticoneDataGridView DataShop;
        private Siticone.UI.WinForms.SiticonePanel PanelPay;
        private Siticone.UI.WinForms.SiticoneButton payButton;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneTextBox textTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneCheckBox siticoneCheckBox4;
        private Siticone.UI.WinForms.SiticoneCheckBox siticoneCheckBox3;
        private Siticone.UI.WinForms.SiticoneCheckBox siticoneCheckBox2;
        private Siticone.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private Siticone.UI.WinForms.SiticoneTextBox dollarText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
    }
}
