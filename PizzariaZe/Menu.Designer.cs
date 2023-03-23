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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            splitContainer1 = new SplitContainer();
            settings_nav_bar = new Button();
            pictureBox1 = new PictureBox();
            products_nav_bar = new Button();
            employees_nav_bar = new Button();
            clients_nav_bar = new Button();
            supply_nav_bar = new Button();
            orders_nav_bar = new Button();
            finances_nav_bar = new Button();
            dashboard_nav_bar = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(settings_nav_bar);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(products_nav_bar);
            splitContainer1.Panel1.Controls.Add(employees_nav_bar);
            splitContainer1.Panel1.Controls.Add(clients_nav_bar);
            splitContainer1.Panel1.Controls.Add(supply_nav_bar);
            splitContainer1.Panel1.Controls.Add(orders_nav_bar);
            splitContainer1.Panel1.Controls.Add(finances_nav_bar);
            splitContainer1.Panel1.Controls.Add(dashboard_nav_bar);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 174;
            splitContainer1.TabIndex = 0;
            // 
            // settings_nav_bar
            // 
            settings_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            settings_nav_bar.Cursor = Cursors.Hand;
            settings_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            settings_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            settings_nav_bar.FlatStyle = FlatStyle.Flat;
            settings_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            settings_nav_bar.Image = (Image)resources.GetObject("settings_nav_bar.Image");
            settings_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            settings_nav_bar.Location = new Point(3, 410);
            settings_nav_bar.Name = "settings_nav_bar";
            settings_nav_bar.RightToLeft = RightToLeft.No;
            settings_nav_bar.Size = new Size(170, 34);
            settings_nav_bar.TabIndex = 7;
            settings_nav_bar.Text = "Configurações";
            settings_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            settings_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            settings_nav_bar.UseVisualStyleBackColor = false;
            settings_nav_bar.Click += settings_nav_bar_Click;
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
            // products_nav_bar
            // 
            products_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            products_nav_bar.Cursor = Cursors.Hand;
            products_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            products_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            products_nav_bar.FlatStyle = FlatStyle.Flat;
            products_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            products_nav_bar.Image = (Image)resources.GetObject("products_nav_bar.Image");
            products_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            products_nav_bar.Location = new Point(3, 210);
            products_nav_bar.Name = "products_nav_bar";
            products_nav_bar.RightToLeft = RightToLeft.No;
            products_nav_bar.Size = new Size(170, 34);
            products_nav_bar.TabIndex = 6;
            products_nav_bar.Text = "Pizzas";
            products_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            products_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            products_nav_bar.UseVisualStyleBackColor = false;
            products_nav_bar.Click += products_nav_bar_Click;
            // 
            // employees_nav_bar
            // 
            employees_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            employees_nav_bar.Cursor = Cursors.Hand;
            employees_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            employees_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            employees_nav_bar.FlatStyle = FlatStyle.Flat;
            employees_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            employees_nav_bar.Image = (Image)resources.GetObject("employees_nav_bar.Image");
            employees_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            employees_nav_bar.Location = new Point(3, 370);
            employees_nav_bar.Name = "employees_nav_bar";
            employees_nav_bar.RightToLeft = RightToLeft.No;
            employees_nav_bar.Size = new Size(170, 34);
            employees_nav_bar.TabIndex = 5;
            employees_nav_bar.Text = "Funcionários";
            employees_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            employees_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            employees_nav_bar.UseVisualStyleBackColor = false;
            employees_nav_bar.Click += employees_nav_bar_Click;
            // 
            // clients_nav_bar
            // 
            clients_nav_bar.BackColor = Color.FromArgb(167, 212, 167);
            clients_nav_bar.Cursor = Cursors.Hand;
            clients_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            clients_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            clients_nav_bar.FlatStyle = FlatStyle.Flat;
            clients_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            clients_nav_bar.Image = (Image)resources.GetObject("clients_nav_bar.Image");
            clients_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            clients_nav_bar.Location = new Point(3, 330);
            clients_nav_bar.Name = "clients_nav_bar";
            clients_nav_bar.RightToLeft = RightToLeft.No;
            clients_nav_bar.Size = new Size(170, 34);
            clients_nav_bar.TabIndex = 4;
            clients_nav_bar.Text = "Clientes";
            clients_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            clients_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            clients_nav_bar.UseVisualStyleBackColor = false;
            clients_nav_bar.Click += clients_nav_bar_Click;
            // 
            // supply_nav_bar
            // 
            supply_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            supply_nav_bar.Cursor = Cursors.Hand;
            supply_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            supply_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            supply_nav_bar.FlatStyle = FlatStyle.Flat;
            supply_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            supply_nav_bar.Image = (Image)resources.GetObject("supply_nav_bar.Image");
            supply_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            supply_nav_bar.Location = new Point(3, 250);
            supply_nav_bar.Name = "supply_nav_bar";
            supply_nav_bar.RightToLeft = RightToLeft.No;
            supply_nav_bar.Size = new Size(170, 34);
            supply_nav_bar.TabIndex = 3;
            supply_nav_bar.Text = "Estoque";
            supply_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            supply_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            supply_nav_bar.UseVisualStyleBackColor = false;
            supply_nav_bar.Click += supply_nav_bar_Click;
            // 
            // orders_nav_bar
            // 
            orders_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            orders_nav_bar.Cursor = Cursors.Hand;
            orders_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            orders_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            orders_nav_bar.FlatStyle = FlatStyle.Flat;
            orders_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            orders_nav_bar.Image = (Image)resources.GetObject("orders_nav_bar.Image");
            orders_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            orders_nav_bar.Location = new Point(3, 170);
            orders_nav_bar.Name = "orders_nav_bar";
            orders_nav_bar.RightToLeft = RightToLeft.No;
            orders_nav_bar.Size = new Size(170, 34);
            orders_nav_bar.TabIndex = 2;
            orders_nav_bar.Text = "Pedidos";
            orders_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            orders_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            orders_nav_bar.UseVisualStyleBackColor = false;
            orders_nav_bar.Click += orders_nav_bar_Click;
            // 
            // finances_nav_bar
            // 
            finances_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            finances_nav_bar.Cursor = Cursors.Hand;
            finances_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            finances_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            finances_nav_bar.FlatStyle = FlatStyle.Flat;
            finances_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            finances_nav_bar.Image = (Image)resources.GetObject("finances_nav_bar.Image");
            finances_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            finances_nav_bar.Location = new Point(3, 290);
            finances_nav_bar.Name = "finances_nav_bar";
            finances_nav_bar.RightToLeft = RightToLeft.No;
            finances_nav_bar.Size = new Size(170, 34);
            finances_nav_bar.TabIndex = 1;
            finances_nav_bar.Text = "Financeiro";
            finances_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            finances_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            finances_nav_bar.UseVisualStyleBackColor = false;
            finances_nav_bar.Click += finances_nav_bar_Click;
            // 
            // dashboard_nav_bar
            // 
            dashboard_nav_bar.BackColor = Color.FromArgb(210, 229, 202);
            dashboard_nav_bar.BackgroundImageLayout = ImageLayout.None;
            dashboard_nav_bar.Cursor = Cursors.Hand;
            dashboard_nav_bar.FlatAppearance.BorderColor = Color.FromArgb(210, 229, 202);
            dashboard_nav_bar.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            dashboard_nav_bar.FlatStyle = FlatStyle.Flat;
            dashboard_nav_bar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dashboard_nav_bar.Image = (Image)resources.GetObject("dashboard_nav_bar.Image");
            dashboard_nav_bar.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_nav_bar.Location = new Point(3, 130);
            dashboard_nav_bar.Name = "dashboard_nav_bar";
            dashboard_nav_bar.RightToLeft = RightToLeft.No;
            dashboard_nav_bar.Size = new Size(170, 34);
            dashboard_nav_bar.TabIndex = 0;
            dashboard_nav_bar.Text = "Inicio";
            dashboard_nav_bar.TextAlign = ContentAlignment.MiddleLeft;
            dashboard_nav_bar.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboard_nav_bar.UseVisualStyleBackColor = false;
            dashboard_nav_bar.Click += dashboard_nav_bar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Menu";
            Text = "Pizzaria do Zé";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button dashboard_nav_bar;
        private Button finances_nav_bar;
        private Button orders_nav_bar;
        private Button employees_nav_bar;
        private Button clients_nav_bar;
        private Button supply_nav_bar;
        private Button products_nav_bar;
        private Button settings_nav_bar;
        private PictureBox pictureBox1;
    }
}