namespace PizzariaZe
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            btn_add_order = new Button();
            SuspendLayout();
            // 
            // btn_add_order
            // 
            btn_add_order.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_order.Image = (Image)resources.GetObject("btn_add_order.Image");
            btn_add_order.Location = new Point(12, 12);
            btn_add_order.Name = "btn_add_order";
            btn_add_order.Size = new Size(151, 76);
            btn_add_order.TabIndex = 3;
            btn_add_order.Text = "Adicionar Pedido";
            btn_add_order.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add_order.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add_order);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            Text = "Pedidos";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add_order;
    }
}