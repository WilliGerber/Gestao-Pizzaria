namespace PizzariaZe
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            splitContainer1 = new SplitContainer();
            btn_settings_nav_bar = new Button();
            pictureBox1 = new PictureBox();
            btn_products_nav_bar = new Button();
            btn_employees_nav_bar = new Button();
            btn_clients_nav_bar = new Button();
            btn_supply_nav_bar = new Button();
            btn_orders_nav_bar = new Button();
            btn_finances_nav_bar = new Button();
            btn_dashboard_nav_bar = new Button();
            contextMenuStripPrincipal = new ContextMenuStrip(components);
            startToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            pizzasToolStripMenuItem = new ToolStripMenuItem();
            supplyToolStripMenuItem = new ToolStripMenuItem();
            financesToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStripSystem = new ContextMenuStrip(components);
            openAppToolStripMenuItemSystemTray = new ToolStripMenuItem();
            exitToolStripMenuItemSystemTray = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStripPrincipal.SuspendLayout();
            contextMenuStripSystem.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(210, 229, 202);
            splitContainer1.Panel1.Controls.Add(btn_settings_nav_bar);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(btn_products_nav_bar);
            splitContainer1.Panel1.Controls.Add(btn_employees_nav_bar);
            splitContainer1.Panel1.Controls.Add(btn_clients_nav_bar);
            splitContainer1.Panel1.Controls.Add(btn_supply_nav_bar);
            splitContainer1.Panel1.Controls.Add(btn_orders_nav_bar);
            splitContainer1.Panel1.Controls.Add(btn_finances_nav_bar);
            splitContainer1.Panel1.Controls.Add(btn_dashboard_nav_bar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.ContextMenuStrip = contextMenuStripPrincipal;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 174;
            splitContainer1.TabIndex = 0;
            // 
            // btn_settings_nav_bar
            // 
            btn_settings_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            btn_settings_nav_bar.Cursor = Cursors.Hand;
            btn_settings_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            btn_settings_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_settings_nav_bar.FlatStyle = FlatStyle.Flat;
            btn_settings_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_settings_nav_bar.Image = (Image)resources.GetObject("btn_settings_nav_bar.Image");
            btn_settings_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_settings_nav_bar.Location = new Point(3, 410);
            btn_settings_nav_bar.Name = "btn_settings_nav_bar";
            btn_settings_nav_bar.RightToLeft = RightToLeft.No;
            btn_settings_nav_bar.Size = new Size(170, 34);
            btn_settings_nav_bar.TabIndex = 7;
            btn_settings_nav_bar.Text = "Configurações";
            btn_settings_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            btn_settings_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_settings_nav_bar.UseVisualStyleBackColor = false;
            btn_settings_nav_bar.Click += settings_nav_bar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 124);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_products_nav_bar
            // 
            btn_products_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            btn_products_nav_bar.Cursor = Cursors.Hand;
            btn_products_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            btn_products_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_products_nav_bar.FlatStyle = FlatStyle.Flat;
            btn_products_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_products_nav_bar.Image = (Image)resources.GetObject("btn_products_nav_bar.Image");
            btn_products_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_products_nav_bar.Location = new Point(3, 210);
            btn_products_nav_bar.Name = "btn_products_nav_bar";
            btn_products_nav_bar.RightToLeft = RightToLeft.No;
            btn_products_nav_bar.Size = new Size(170, 34);
            btn_products_nav_bar.TabIndex = 2;
            btn_products_nav_bar.Text = "Pizzas";
            btn_products_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            btn_products_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_products_nav_bar.UseVisualStyleBackColor = false;
            btn_products_nav_bar.Click += products_nav_bar_Click;
            // 
            // btn_employees_nav_bar
            // 
            btn_employees_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            btn_employees_nav_bar.Cursor = Cursors.Hand;
            btn_employees_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            btn_employees_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_employees_nav_bar.FlatStyle = FlatStyle.Flat;
            btn_employees_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_employees_nav_bar.Image = (Image)resources.GetObject("btn_employees_nav_bar.Image");
            btn_employees_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_employees_nav_bar.Location = new Point(3, 370);
            btn_employees_nav_bar.Name = "btn_employees_nav_bar";
            btn_employees_nav_bar.RightToLeft = RightToLeft.No;
            btn_employees_nav_bar.Size = new Size(170, 34);
            btn_employees_nav_bar.TabIndex = 6;
            btn_employees_nav_bar.Text = "Funcionários";
            btn_employees_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            btn_employees_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_employees_nav_bar.UseVisualStyleBackColor = false;
            btn_employees_nav_bar.Click += employees_nav_bar_Click;
            // 
            // btn_clients_nav_bar
            // 
            btn_clients_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            btn_clients_nav_bar.Cursor = Cursors.Hand;
            btn_clients_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            btn_clients_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_clients_nav_bar.FlatStyle = FlatStyle.Flat;
            btn_clients_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clients_nav_bar.Image = (Image)resources.GetObject("btn_clients_nav_bar.Image");
            btn_clients_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clients_nav_bar.Location = new Point(3, 330);
            btn_clients_nav_bar.Name = "btn_clients_nav_bar";
            btn_clients_nav_bar.RightToLeft = RightToLeft.No;
            btn_clients_nav_bar.Size = new Size(170, 34);
            btn_clients_nav_bar.TabIndex = 5;
            btn_clients_nav_bar.Text = "Clientes";
            btn_clients_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            btn_clients_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_clients_nav_bar.UseVisualStyleBackColor = false;
            btn_clients_nav_bar.Click += clients_nav_bar_Click;
            // 
            // btn_supply_nav_bar
            // 
            btn_supply_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            btn_supply_nav_bar.Cursor = Cursors.Hand;
            btn_supply_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            btn_supply_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_supply_nav_bar.FlatStyle = FlatStyle.Flat;
            btn_supply_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_supply_nav_bar.Image = (Image)resources.GetObject("btn_supply_nav_bar.Image");
            btn_supply_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_supply_nav_bar.Location = new Point(3, 250);
            btn_supply_nav_bar.Name = "btn_supply_nav_bar";
            btn_supply_nav_bar.RightToLeft = RightToLeft.No;
            btn_supply_nav_bar.Size = new Size(170, 34);
            btn_supply_nav_bar.TabIndex = 3;
            btn_supply_nav_bar.Text = "Estoque";
            btn_supply_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            btn_supply_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_supply_nav_bar.UseVisualStyleBackColor = false;
            btn_supply_nav_bar.Click += supply_nav_bar_Click;
            // 
            // btn_orders_nav_bar
            // 
            btn_orders_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            btn_orders_nav_bar.Cursor = Cursors.Hand;
            btn_orders_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            btn_orders_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_orders_nav_bar.FlatStyle = FlatStyle.Flat;
            btn_orders_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_orders_nav_bar.Image = (Image)resources.GetObject("btn_orders_nav_bar.Image");
            btn_orders_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_orders_nav_bar.Location = new Point(3, 170);
            btn_orders_nav_bar.Name = "btn_orders_nav_bar";
            btn_orders_nav_bar.RightToLeft = RightToLeft.No;
            btn_orders_nav_bar.Size = new Size(170, 34);
            btn_orders_nav_bar.TabIndex = 1;
            btn_orders_nav_bar.Text = "Pedidos";
            btn_orders_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            btn_orders_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_orders_nav_bar.UseVisualStyleBackColor = false;
            btn_orders_nav_bar.Click += orders_nav_bar_Click;
            // 
            // btn_finances_nav_bar
            // 
            btn_finances_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            btn_finances_nav_bar.Cursor = Cursors.Hand;
            btn_finances_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            btn_finances_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_finances_nav_bar.FlatStyle = FlatStyle.Flat;
            btn_finances_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_finances_nav_bar.Image = (Image)resources.GetObject("btn_finances_nav_bar.Image");
            btn_finances_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_finances_nav_bar.Location = new Point(3, 290);
            btn_finances_nav_bar.Name = "btn_finances_nav_bar";
            btn_finances_nav_bar.RightToLeft = RightToLeft.No;
            btn_finances_nav_bar.Size = new Size(170, 34);
            btn_finances_nav_bar.TabIndex = 4;
            btn_finances_nav_bar.Text = "Financeiro";
            btn_finances_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            btn_finances_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_finances_nav_bar.UseVisualStyleBackColor = false;
            btn_finances_nav_bar.Click += finances_nav_bar_Click;
            // 
            // btn_dashboard_nav_bar
            // 
            btn_dashboard_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            btn_dashboard_nav_bar.BackgroundImageLayout = ImageLayout.None;
            btn_dashboard_nav_bar.Cursor = Cursors.Hand;
            btn_dashboard_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            btn_dashboard_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_dashboard_nav_bar.FlatStyle = FlatStyle.Flat;
            btn_dashboard_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dashboard_nav_bar.Image = (Image)resources.GetObject("btn_dashboard_nav_bar.Image");
            btn_dashboard_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard_nav_bar.Location = new Point(3, 130);
            btn_dashboard_nav_bar.Name = "btn_dashboard_nav_bar";
            btn_dashboard_nav_bar.RightToLeft = RightToLeft.No;
            btn_dashboard_nav_bar.Size = new Size(170, 34);
            btn_dashboard_nav_bar.TabIndex = 0;
            btn_dashboard_nav_bar.Text = "Inicio";
            btn_dashboard_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dashboard_nav_bar.UseVisualStyleBackColor = false;
            btn_dashboard_nav_bar.Click += dashboard_nav_bar_Click;
            // 
            // contextMenuStripPrincipal
            // 
            contextMenuStripPrincipal.Items.AddRange(new ToolStripItem[] { startToolStripMenuItem, ordersToolStripMenuItem, pizzasToolStripMenuItem, supplyToolStripMenuItem, financesToolStripMenuItem, clientsToolStripMenuItem, employeesToolStripMenuItem, settingsToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            contextMenuStripPrincipal.Size = new Size(152, 202);
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(151, 22);
            startToolStripMenuItem.Text = "Início";
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(151, 22);
            ordersToolStripMenuItem.Text = "Pedidos";
            // 
            // pizzasToolStripMenuItem
            // 
            pizzasToolStripMenuItem.Name = "pizzasToolStripMenuItem";
            pizzasToolStripMenuItem.Size = new Size(151, 22);
            pizzasToolStripMenuItem.Text = "Pizzas";
            // 
            // supplyToolStripMenuItem
            // 
            supplyToolStripMenuItem.Name = "supplyToolStripMenuItem";
            supplyToolStripMenuItem.Size = new Size(151, 22);
            supplyToolStripMenuItem.Text = "Estoque";
            // 
            // financesToolStripMenuItem
            // 
            financesToolStripMenuItem.Name = "financesToolStripMenuItem";
            financesToolStripMenuItem.Size = new Size(151, 22);
            financesToolStripMenuItem.Text = "Financeiro";
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(151, 22);
            clientsToolStripMenuItem.Text = "Clientes";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(151, 22);
            employeesToolStripMenuItem.Text = "Funcionários";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(151, 22);
            settingsToolStripMenuItem.Text = "Configurações";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(151, 22);
            exitToolStripMenuItem.Text = "Sair";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.ContextMenuStrip = contextMenuStripSystem;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria do Zé";
            // 
            // contextMenuStripSystem
            // 
            contextMenuStripSystem.Items.AddRange(new ToolStripItem[] { openAppToolStripMenuItemSystemTray, exitToolStripMenuItemSystemTray, sobreToolStripMenuItem });
            contextMenuStripSystem.Name = "contextMenuStripSystem";
            contextMenuStripSystem.Size = new Size(156, 70);
            contextMenuStripSystem.Opening += contextMenuStripSystem_Opening;
            // 
            // openAppToolStripMenuItemSystemTray
            // 
            openAppToolStripMenuItemSystemTray.Name = "openAppToolStripMenuItemSystemTray";
            openAppToolStripMenuItemSystemTray.Size = new Size(180, 22);
            openAppToolStripMenuItemSystemTray.Text = "Abrir Aplicação";
            openAppToolStripMenuItemSystemTray.Click += openAppToolStripMenuItemSystemTray_Click;
            // 
            // exitToolStripMenuItemSystemTray
            // 
            exitToolStripMenuItemSystemTray.Name = "exitToolStripMenuItemSystemTray";
            exitToolStripMenuItemSystemTray.Size = new Size(180, 22);
            exitToolStripMenuItemSystemTray.Text = "Encerrar";
            exitToolStripMenuItemSystemTray.Click += exitToolStripMenuItemSystemTray_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(180, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            KeyPreview = true;
            Name = "Menu";
            Text = "Pizzaria do Zé";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStripPrincipal.ResumeLayout(false);
            contextMenuStripSystem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public SplitContainer splitContainer1;
        private Button btn_dashboard_nav_bar;
        private Button btn_finances_nav_bar;
        private Button btn_orders_nav_bar;
        private Button btn_employees_nav_bar;
        private Button btn_clients_nav_bar;
        private Button btn_supply_nav_bar;
        private Button btn_products_nav_bar;
        private Button btn_settings_nav_bar;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStripPrincipal;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem pizzasToolStripMenuItem;
        private ToolStripMenuItem supplyToolStripMenuItem;
        private ToolStripMenuItem financesToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStripSystem;
        private ToolStripMenuItem openAppToolStripMenuItemSystemTray;
        private ToolStripMenuItem exitToolStripMenuItemSystemTray;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}
