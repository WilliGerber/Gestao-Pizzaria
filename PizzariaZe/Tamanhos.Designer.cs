namespace PizzariaZe
{
    partial class Tamanhos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tamanhos));
            dataGridViewDados = new DataGridView();
            btn_pizzas_sizes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(11, 12);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(797, 468);
            dataGridViewDados.TabIndex = 7;
            // 
            // btn_pizzas_sizes
            // 
            btn_pizzas_sizes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pizzas_sizes.Image = (Image)resources.GetObject("btn_pizzas_sizes.Image");
            btn_pizzas_sizes.Location = new Point(817, 12);
            btn_pizzas_sizes.Name = "btn_pizzas_sizes";
            btn_pizzas_sizes.Size = new Size(151, 76);
            btn_pizzas_sizes.TabIndex = 8;
            btn_pizzas_sizes.Text = "Adicionar Tamanhos";
            btn_pizzas_sizes.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_pizzas_sizes.UseVisualStyleBackColor = true;
            btn_pizzas_sizes.Click += btn_pizzas_sizes_Click;
            // 
            // Tamanhos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 492);
            Controls.Add(btn_pizzas_sizes);
            Controls.Add(dataGridViewDados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tamanhos";
            Text = "Tamanhos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDados;
        private Button btn_pizzas_sizes;
    }
}