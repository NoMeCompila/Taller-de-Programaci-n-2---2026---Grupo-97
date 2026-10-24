using System.Drawing;
using System.Windows.Forms;

namespace MobileSolutions.UILayer
{
    partial class AdminReportControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            tlpHeader = new TableLayoutPanel();
            pnlHeaderTitle = new Panel();
            picTitle = new FontAwesome.Sharp.IconPictureBox();
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlHeaderActions = new Panel();
            btnRefresh = new MaterialSkin.Controls.MaterialButton();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            pnlTabsBar = new Panel();
            btnTabGovernance = new Button();
            btnTabPriceAudit = new Button();
            pnlBodyContainer = new Panel();
            pnlGovernanceView = new Panel();
            pnlAuditGridSection = new Panel();
            dgvCriticalEvents = new DataGridView();
            lblAuditGridTitle = new Label();
            tlpKpis = new TableLayoutPanel();
            pnlPriceAuditView = new Panel();
            dgvPriceAudit = new DataGridView();
            pnlPriceAuditHeader = new Panel();
            lblPriceAuditDescription = new Label();
            lblPriceAuditTitle = new Label();
            tlpHeader.SuspendLayout();
            pnlHeaderTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTitle).BeginInit();
            pnlHeaderActions.SuspendLayout();
            pnlTabsBar.SuspendLayout();
            pnlBodyContainer.SuspendLayout();
            pnlGovernanceView.SuspendLayout();
            pnlAuditGridSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCriticalEvents).BeginInit();
            pnlPriceAuditView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPriceAudit).BeginInit();
            pnlPriceAuditHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 2;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpHeader.Controls.Add(pnlHeaderTitle, 0, 0);
            tlpHeader.Controls.Add(pnlHeaderActions, 1, 0);
            tlpHeader.Dock = DockStyle.Top;
            tlpHeader.Location = new Point(0, 0);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.Size = new Size(1680, 70);
            tlpHeader.TabIndex = 0;
            // 
            // pnlHeaderTitle
            // 
            pnlHeaderTitle.Controls.Add(picTitle);
            pnlHeaderTitle.Controls.Add(lblTitle);
            pnlHeaderTitle.Dock = DockStyle.Fill;
            pnlHeaderTitle.Location = new Point(3, 3);
            pnlHeaderTitle.Name = "pnlHeaderTitle";
            pnlHeaderTitle.Size = new Size(1002, 64);
            pnlHeaderTitle.TabIndex = 0;
            // 
            // picTitle
            // 
            picTitle.BackColor = Color.FromArgb(50, 50, 50);
            picTitle.IconChar = FontAwesome.Sharp.IconChar.ShieldHalved;
            picTitle.IconColor = Color.White;
            picTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTitle.IconSize = 36;
            picTitle.Location = new Point(15, 16);
            picTitle.Name = "picTitle";
            picTitle.Size = new Size(40, 36);
            picTitle.TabIndex = 0;
            picTitle.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(65, 14);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(598, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Gobernanza, Auditoría y Mantenimiento";
            // 
            // pnlHeaderActions
            // 
            pnlHeaderActions.Controls.Add(btnRefresh);
            pnlHeaderActions.Controls.Add(btnLogout);
            pnlHeaderActions.Controls.Add(lblCurrentUser);
            pnlHeaderActions.Dock = DockStyle.Fill;
            pnlHeaderActions.Location = new Point(1011, 3);
            pnlHeaderActions.Name = "pnlHeaderActions";
            pnlHeaderActions.Size = new Size(666, 64);
            pnlHeaderActions.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRefresh.Depth = 0;
            btnRefresh.HighEmphasis = true;
            btnRefresh.Icon = null;
            btnRefresh.Location = new Point(374, 16);
            btnRefresh.Margin = new Padding(4, 6, 4, 6);
            btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.NoAccentTextColor = Color.Empty;
            btnRefresh.Size = new Size(109, 36);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Actualizar";
            btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnRefresh.UseAccentColor = false;
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.Location = new Point(517, 16);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(131, 36);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            lblCurrentUser.Location = new Point(223, 24);
            lblCurrentUser.MouseState = MaterialSkin.MouseState.HOVER;
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(63, 19);
            lblCurrentUser.TabIndex = 2;
            lblCurrentUser.Text = "[Usuario]";
            // 
            // pnlTabsBar
            // 
            pnlTabsBar.BackColor = Color.FromArgb(42, 42, 42);
            pnlTabsBar.Controls.Add(btnTabGovernance);
            pnlTabsBar.Controls.Add(btnTabPriceAudit);
            pnlTabsBar.Dock = DockStyle.Top;
            pnlTabsBar.Location = new Point(0, 70);
            pnlTabsBar.Name = "pnlTabsBar";
            pnlTabsBar.Size = new Size(1680, 44);
            pnlTabsBar.TabIndex = 1;
            // 
            // btnTabGovernance
            // 
            btnTabGovernance.BackColor = Color.FromArgb(25, 118, 210);
            btnTabGovernance.Cursor = Cursors.Hand;
            btnTabGovernance.FlatAppearance.BorderSize = 0;
            btnTabGovernance.FlatStyle = FlatStyle.Flat;
            btnTabGovernance.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnTabGovernance.ForeColor = Color.White;
            btnTabGovernance.Location = new Point(15, 4);
            btnTabGovernance.Name = "btnTabGovernance";
            btnTabGovernance.Size = new Size(320, 36);
            btnTabGovernance.TabIndex = 0;
            btnTabGovernance.Text = "Gobierno & Infraestructura DRP";
            btnTabGovernance.UseVisualStyleBackColor = false;
            // 
            // btnTabPriceAudit
            // 
            btnTabPriceAudit.BackColor = Color.FromArgb(46, 46, 46);
            btnTabPriceAudit.Cursor = Cursors.Hand;
            btnTabPriceAudit.FlatAppearance.BorderSize = 0;
            btnTabPriceAudit.FlatStyle = FlatStyle.Flat;
            btnTabPriceAudit.Font = new Font("Segoe UI", 10.5F);
            btnTabPriceAudit.ForeColor = Color.FromArgb(210, 210, 210);
            btnTabPriceAudit.Location = new Point(345, 4);
            btnTabPriceAudit.Name = "btnTabPriceAudit";
            btnTabPriceAudit.Size = new Size(340, 36);
            btnTabPriceAudit.TabIndex = 1;
            btnTabPriceAudit.Text = "Auditoría de Precios de Productos";
            btnTabPriceAudit.UseVisualStyleBackColor = false;
            // 
            // pnlBodyContainer
            // 
            pnlBodyContainer.Controls.Add(pnlGovernanceView);
            pnlBodyContainer.Controls.Add(pnlPriceAuditView);
            pnlBodyContainer.Dock = DockStyle.Fill;
            pnlBodyContainer.Location = new Point(0, 114);
            pnlBodyContainer.Name = "pnlBodyContainer";
            pnlBodyContainer.Size = new Size(1680, 816);
            pnlBodyContainer.TabIndex = 2;
            // 
            // pnlGovernanceView
            // 
            pnlGovernanceView.Controls.Add(pnlAuditGridSection);
            pnlGovernanceView.Controls.Add(tlpKpis);
            pnlGovernanceView.Dock = DockStyle.Fill;
            pnlGovernanceView.Location = new Point(0, 0);
            pnlGovernanceView.Name = "pnlGovernanceView";
            pnlGovernanceView.Padding = new Padding(15);
            pnlGovernanceView.Size = new Size(1680, 816);
            pnlGovernanceView.TabIndex = 0;
            // 
            // pnlAuditGridSection
            // 
            pnlAuditGridSection.Controls.Add(dgvCriticalEvents);
            pnlAuditGridSection.Controls.Add(lblAuditGridTitle);
            pnlAuditGridSection.Dock = DockStyle.Fill;
            pnlAuditGridSection.Location = new Point(15, 325);
            pnlAuditGridSection.Name = "pnlAuditGridSection";
            pnlAuditGridSection.Padding = new Padding(0, 10, 0, 0);
            pnlAuditGridSection.Size = new Size(1650, 476);
            pnlAuditGridSection.TabIndex = 1;
            // 
            // dgvCriticalEvents
            // 
            dgvCriticalEvents.AllowUserToAddRows = false;
            dgvCriticalEvents.AllowUserToDeleteRows = false;
            dgvCriticalEvents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCriticalEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCriticalEvents.BackgroundColor = Color.FromArgb(42, 42, 42);
            dgvCriticalEvents.BorderStyle = BorderStyle.None;
            dgvCriticalEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCriticalEvents.Location = new Point(2, 40);
            dgvCriticalEvents.MultiSelect = false;
            dgvCriticalEvents.Name = "dgvCriticalEvents";
            dgvCriticalEvents.ReadOnly = true;
            dgvCriticalEvents.RowHeadersVisible = false;
            dgvCriticalEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCriticalEvents.Size = new Size(1646, 425);
            dgvCriticalEvents.TabIndex = 1;
            // 
            // lblAuditGridTitle
            // 
            lblAuditGridTitle.AutoSize = true;
            lblAuditGridTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAuditGridTitle.ForeColor = Color.White;
            lblAuditGridTitle.Location = new Point(2, 12);
            lblAuditGridTitle.Name = "lblAuditGridTitle";
            lblAuditGridTitle.Size = new Size(448, 21);
            lblAuditGridTitle.TabIndex = 0;
            lblAuditGridTitle.Text = "Registro de Actividad Operativa Crítica (Últimos 15 eventos )";
            // 
            // tlpKpis
            // 
            tlpKpis.ColumnCount = 4;
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpis.Dock = DockStyle.Top;
            tlpKpis.Location = new Point(15, 15);
            tlpKpis.Name = "tlpKpis";
            tlpKpis.RowCount = 2;
            tlpKpis.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpis.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpKpis.Size = new Size(1650, 310);
            tlpKpis.TabIndex = 0;
            // 
            // pnlPriceAuditView
            // 
            pnlPriceAuditView.Controls.Add(dgvPriceAudit);
            pnlPriceAuditView.Controls.Add(pnlPriceAuditHeader);
            pnlPriceAuditView.Dock = DockStyle.Fill;
            pnlPriceAuditView.Location = new Point(0, 0);
            pnlPriceAuditView.Name = "pnlPriceAuditView";
            pnlPriceAuditView.Padding = new Padding(15);
            pnlPriceAuditView.Size = new Size(1680, 816);
            pnlPriceAuditView.TabIndex = 1;
            pnlPriceAuditView.Visible = false;
            // 
            // dgvPriceAudit
            // 
            dgvPriceAudit.AllowUserToAddRows = false;
            dgvPriceAudit.AllowUserToDeleteRows = false;
            dgvPriceAudit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPriceAudit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPriceAudit.BackgroundColor = Color.FromArgb(42, 42, 42);
            dgvPriceAudit.BorderStyle = BorderStyle.None;
            dgvPriceAudit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPriceAudit.Location = new Point(15, 80);
            dgvPriceAudit.MultiSelect = false;
            dgvPriceAudit.Name = "dgvPriceAudit";
            dgvPriceAudit.ReadOnly = true;
            dgvPriceAudit.RowHeadersVisible = false;
            dgvPriceAudit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPriceAudit.Size = new Size(1650, 720);
            dgvPriceAudit.TabIndex = 1;
            // 
            // pnlPriceAuditHeader
            // 
            pnlPriceAuditHeader.Controls.Add(lblPriceAuditDescription);
            pnlPriceAuditHeader.Controls.Add(lblPriceAuditTitle);
            pnlPriceAuditHeader.Dock = DockStyle.Top;
            pnlPriceAuditHeader.Location = new Point(15, 15);
            pnlPriceAuditHeader.Name = "pnlPriceAuditHeader";
            pnlPriceAuditHeader.Size = new Size(1650, 60);
            pnlPriceAuditHeader.TabIndex = 0;
            // 
            // lblPriceAuditDescription
            // 
            lblPriceAuditDescription.AutoSize = true;
            lblPriceAuditDescription.Font = new Font("Segoe UI", 9.5F);
            lblPriceAuditDescription.ForeColor = Color.FromArgb(180, 180, 180);
            lblPriceAuditDescription.Location = new Point(2, 33);
            lblPriceAuditDescription.Name = "lblPriceAuditDescription";
            lblPriceAuditDescription.Size = new Size(733, 17);
            lblPriceAuditDescription.TabIndex = 1;
            lblPriceAuditDescription.Text = "Auditoría en tiempo real disparada por el trigger trg_Product_PriceAudit ante modificaciones en precios de compra o venta.";
            // 
            // lblPriceAuditTitle
            // 
            lblPriceAuditTitle.AutoSize = true;
            lblPriceAuditTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblPriceAuditTitle.ForeColor = Color.White;
            lblPriceAuditTitle.Location = new Point(2, 5);
            lblPriceAuditTitle.Name = "lblPriceAuditTitle";
            lblPriceAuditTitle.Size = new Size(449, 25);
            lblPriceAuditTitle.TabIndex = 0;
            lblPriceAuditTitle.Text = "Historial de Cambios de Precios (Trigger SQL Server)";
            // 
            // AdminReportControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(pnlBodyContainer);
            Controls.Add(pnlTabsBar);
            Controls.Add(tlpHeader);
            Name = "AdminReportControl";
            Size = new Size(1680, 930);
            tlpHeader.ResumeLayout(false);
            pnlHeaderTitle.ResumeLayout(false);
            pnlHeaderTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTitle).EndInit();
            pnlHeaderActions.ResumeLayout(false);
            pnlHeaderActions.PerformLayout();
            pnlTabsBar.ResumeLayout(false);
            pnlBodyContainer.ResumeLayout(false);
            pnlGovernanceView.ResumeLayout(false);
            pnlAuditGridSection.ResumeLayout(false);
            pnlAuditGridSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCriticalEvents).EndInit();
            pnlPriceAuditView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPriceAudit).EndInit();
            pnlPriceAuditHeader.ResumeLayout(false);
            pnlPriceAuditHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpHeader;
        private Panel pnlHeaderTitle;
        private FontAwesome.Sharp.IconPictureBox picTitle;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private Panel pnlHeaderActions;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;

        private Panel pnlTabsBar;
        private Button btnTabGovernance;
        private Button btnTabPriceAudit;

        private Panel pnlBodyContainer;

        // Vista 1: Gobierno
        private Panel pnlGovernanceView;
        private TableLayoutPanel tlpKpis;
        private Panel pnlAuditGridSection;
        private Label lblAuditGridTitle;
        private DataGridView dgvCriticalEvents;

        // Vista 2: Precios
        private Panel pnlPriceAuditView;
        private Panel pnlPriceAuditHeader;
        private Label lblPriceAuditTitle;
        private Label lblPriceAuditDescription;
        private DataGridView dgvPriceAudit;
    }
}
