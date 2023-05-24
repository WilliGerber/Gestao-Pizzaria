namespace PizzariaZe
{
    partial class Ingredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingredients));
            btn_add_ingredients = new Button();
            dataGridViewDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // btn_add_ingredients
            // 
            btn_add_ingredients.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_ingredients.Image = (Image)resources.GetObject("btn_add_ingredients.Image");
            btn_add_ingredients.Location = new Point(818, 12);
            btn_add_ingredients.Name = "btn_add_ingredients";
            btn_add_ingredients.Size = new Size(151, 76);
            btn_add_ingredients.TabIndex = 2;
            btn_add_ingredients.Text = "Adicionar Ingredientes";
            btn_add_ingredients.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add_ingredients.UseVisualStyleBackColor = true;
            btn_add_ingredients.Click += btn_add_ingredients_Click;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(12, 12);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(797, 468);
            dataGridViewDados.TabIndex = 3;
            // 
            // Ingredients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 492);
            Controls.Add(dataGridViewDados);
            Controls.Add(btn_add_ingredients);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ingredients";
            Text = "Ingredients";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add_ingredients;
        private DataGridView dataGridViewDados;
    }
}