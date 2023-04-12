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
            add_order = new Button();
            add_client = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // add_order
            // 
            add_order.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            add_order.Image = (Image)resources.GetObject("add_order.Image");
            add_order.Location = new Point(466, 71);
            add_order.Name = "add_order";
            add_order.Size = new Size(212, 144);
            add_order.TabIndex = 0;
            add_order.Text = "Adicionar Pedido";
            add_order.TextImageRelation = TextImageRelation.ImageAboveText;
            add_order.UseVisualStyleBackColor = true;
            // 
            // add_client
            // 
            add_client.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            add_client.Image = (Image)resources.GetObject("add_client.Image");
            add_client.Location = new Point(137, 71);
            add_client.Name = "add_client";
            add_client.Size = new Size(212, 144);
            add_client.TabIndex = 1;
            add_client.Text = "Adicionar Cliente";
            add_client.TextImageRelation = TextImageRelation.ImageAboveText;
            add_client.UseVisualStyleBackColor = true;
            add_client.Click += add_client_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(137, 262);
            button1.Name = "button1";
            button1.Size = new Size(212, 144);
            button1.TabIndex = 2;
            button1.Text = "Pedidos Abertos";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(add_client);
            Controls.Add(add_order);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Início";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button add_order;
        private Button add_client;
        private Button button1;
    }
}