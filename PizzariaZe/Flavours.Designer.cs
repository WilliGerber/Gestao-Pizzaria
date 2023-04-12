namespace PizzariaZe
{
    partial class Flavours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flavours));
            add_flavours = new Button();
            pizzas_sizes = new Button();
            add_ingredients = new Button();
            SuspendLayout();
            // 
            // add_flavours
            // 
            add_flavours.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            add_flavours.Image = (Image)resources.GetObject("add_flavours.Image");
            add_flavours.Location = new Point(378, 23);
            add_flavours.Name = "add_flavours";
            add_flavours.Size = new Size(151, 76);
            add_flavours.TabIndex = 3;
            add_flavours.Text = "Adicionar Pizzas";
            add_flavours.TextImageRelation = TextImageRelation.ImageAboveText;
            add_flavours.UseVisualStyleBackColor = true;
            add_flavours.Click += add_flavours_Click;
            // 
            // pizzas_sizes
            // 
            pizzas_sizes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            pizzas_sizes.Image = (Image)resources.GetObject("pizzas_sizes.Image");
            pizzas_sizes.Location = new Point(200, 23);
            pizzas_sizes.Name = "pizzas_sizes";
            pizzas_sizes.Size = new Size(151, 76);
            pizzas_sizes.TabIndex = 4;
            pizzas_sizes.Text = "Adicionar Tamanhos";
            pizzas_sizes.TextImageRelation = TextImageRelation.ImageAboveText;
            pizzas_sizes.UseVisualStyleBackColor = true;
            pizzas_sizes.Click += pizzas_sizes_Click;
            // 
            // add_ingredients
            // 
            add_ingredients.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            add_ingredients.Image = (Image)resources.GetObject("add_ingredients.Image");
            add_ingredients.Location = new Point(24, 23);
            add_ingredients.Name = "add_ingredients";
            add_ingredients.Size = new Size(151, 76);
            add_ingredients.TabIndex = 5;
            add_ingredients.Text = "Adicionar Ingredientes";
            add_ingredients.TextImageRelation = TextImageRelation.ImageAboveText;
            add_ingredients.UseVisualStyleBackColor = true;
            add_ingredients.Click += add_ingredients_Click;
            // 
            // Flavours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add_ingredients);
            Controls.Add(pizzas_sizes);
            Controls.Add(add_flavours);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Flavours";
            Text = "Pizzas";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button add_flavours;
        private Button pizzas_sizes;
        private Button add_ingredients;
    }
}