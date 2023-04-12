namespace PizzariaZe
{
    partial class Finances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finances));
            add_pizza_sizes = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // add_pizza_sizes
            // 
            add_pizza_sizes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            add_pizza_sizes.Image = (Image)resources.GetObject("add_pizza_sizes.Image");
            add_pizza_sizes.Location = new Point(26, 23);
            add_pizza_sizes.Name = "add_pizza_sizes";
            add_pizza_sizes.Size = new Size(151, 76);
            add_pizza_sizes.TabIndex = 5;
            add_pizza_sizes.Text = "Receitas";
            add_pizza_sizes.TextImageRelation = TextImageRelation.ImageAboveText;
            add_pizza_sizes.UseVisualStyleBackColor = true;
            add_pizza_sizes.Click += add_pizza_sizes_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(183, 23);
            button1.Name = "button1";
            button1.Size = new Size(151, 76);
            button1.TabIndex = 6;
            button1.Text = "Pagamentos";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // Finances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(add_pizza_sizes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Finances";
            Text = "Financeiro";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion
        private Button add_pizza_sizes;
        private Button button1;
    }
}