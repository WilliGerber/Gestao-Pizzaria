namespace PizzariaZe
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btn_add_order = new Button();
            btn_add_client = new Button();
            btn_opened_orders = new Button();
            SuspendLayout();
            // 
            // btn_add_order
            // 
            btn_add_order.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_order.Image = (Image)resources.GetObject("btn_add_order.Image");
            btn_add_order.Location = new Point(466, 71);
            btn_add_order.Name = "btn_add_order";
            btn_add_order.Size = new Size(212, 144);
            btn_add_order.TabIndex = 0;
            btn_add_order.Text = "Adicionar Pedido";
            btn_add_order.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add_order.UseVisualStyleBackColor = true;
            // 
            // btn_add_client
            // 
            btn_add_client.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_client.Image = (Image)resources.GetObject("btn_add_client.Image");
            btn_add_client.Location = new Point(137, 71);
            btn_add_client.Name = "btn_add_client";
            btn_add_client.Size = new Size(212, 144);
            btn_add_client.TabIndex = 1;
            btn_add_client.Text = "Adicionar Cliente";
            btn_add_client.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add_client.UseVisualStyleBackColor = true;
            btn_add_client.Click += add_client_Click;
            // 
            // btn_opened_orders
            // 
            btn_opened_orders.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_opened_orders.Image = (Image)resources.GetObject("btn_opened_orders.Image");
            btn_opened_orders.Location = new Point(137, 262);
            btn_opened_orders.Name = "btn_opened_orders";
            btn_opened_orders.Size = new Size(212, 144);
            btn_opened_orders.TabIndex = 2;
            btn_opened_orders.Text = "Pedidos Abertos";
            btn_opened_orders.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_opened_orders.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_opened_orders);
            Controls.Add(btn_add_client);
            Controls.Add(btn_add_order);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Início";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add_order;
        private Button btn_add_client;
        private Button btn_opened_orders;
    }
}