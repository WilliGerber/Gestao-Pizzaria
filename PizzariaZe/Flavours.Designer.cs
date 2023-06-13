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
            btn_add_flavours = new Button();
            btn_pizzas_sizes = new Button();
            btn_ingredients = new Button();
            pannelContent = new Panel();
            SuspendLayout();
            // 
            // btn_add_flavours
            // 
            btn_add_flavours.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_flavours.Image = (Image)resources.GetObject("btn_add_flavours.Image");
            btn_add_flavours.Location = new Point(181, 12);
            btn_add_flavours.Name = "btn_add_flavours";
            btn_add_flavours.Size = new Size(151, 76);
            btn_add_flavours.TabIndex = 3;
            btn_add_flavours.Text = "Adicionar Pizzas";
            btn_add_flavours.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add_flavours.UseVisualStyleBackColor = true;
            btn_add_flavours.Click += add_flavours_Click;
            // 
            // btn_pizzas_sizes
            // 
            btn_pizzas_sizes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pizzas_sizes.Image = (Image)resources.GetObject("btn_pizzas_sizes.Image");
            btn_pizzas_sizes.Location = new Point(347, 12);
            btn_pizzas_sizes.Name = "btn_pizzas_sizes";
            btn_pizzas_sizes.Size = new Size(151, 76);
            btn_pizzas_sizes.TabIndex = 2;
            btn_pizzas_sizes.Text = "Adicionar Tamanhos";
            btn_pizzas_sizes.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_pizzas_sizes.UseVisualStyleBackColor = true;
            btn_pizzas_sizes.Click += pizzas_sizes_Click;
            // 
            // btn_ingredients
            // 
            btn_ingredients.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ingredients.Image = (Image)resources.GetObject("btn_ingredients.Image");
            btn_ingredients.Location = new Point(12, 12);
            btn_ingredients.Name = "btn_ingredients";
            btn_ingredients.Size = new Size(151, 76);
            btn_ingredients.TabIndex = 5;
            btn_ingredients.Text = "Ingredientes";
            btn_ingredients.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_ingredients.UseVisualStyleBackColor = true;
            btn_ingredients.Click += btn_ingredients_Click;
            // 
            // pannelContent
            // 
            pannelContent.Location = new Point(4, 107);
            pannelContent.Name = "pannelContent";
            pannelContent.Size = new Size(962, 381);
            pannelContent.TabIndex = 4;
            // 
            // Flavours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 492);
            Controls.Add(btn_ingredients);
            Controls.Add(pannelContent);
            Controls.Add(btn_pizzas_sizes);
            Controls.Add(btn_add_flavours);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Flavours";
            Text = "Pizzas";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add_flavours;
        private Button btn_pizzas_sizes;
        private Button btn_ingredients;
        private Panel pannelContent;
    }
}