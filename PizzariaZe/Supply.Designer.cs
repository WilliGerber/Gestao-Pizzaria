namespace PizzariaZe
{
    partial class Supply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supply));
            btn_add_products = new Button();
            dataGridViewDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // btn_add_products
            // 
            btn_add_products.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_products.Image = (Image)resources.GetObject("btn_add_products.Image");
            btn_add_products.Location = new Point(818, 12);
            btn_add_products.Name = "btn_add_products";
            btn_add_products.Size = new Size(151, 76);
            btn_add_products.TabIndex = 0;
            btn_add_products.Text = "Adicionar Produto";
            btn_add_products.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add_products.UseVisualStyleBackColor = true;
            btn_add_products.Click += add_products_Click;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(12, 12);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(797, 468);
            dataGridViewDados.TabIndex = 7;
            // 
            // Supply
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 492);
            Controls.Add(dataGridViewDados);
            Controls.Add(btn_add_products);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Supply";
            Text = "Estoque";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add_products;
        private DataGridView dataGridViewDados;
    }
}