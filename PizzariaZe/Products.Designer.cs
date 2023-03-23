namespace PizzariaZe
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            add_client = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // add_client
            // 
            add_client.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            add_client.Image = (Image)resources.GetObject("add_client.Image");
            add_client.Location = new Point(22, 23);
            add_client.Name = "add_client";
            add_client.Size = new Size(151, 76);
            add_client.TabIndex = 3;
            add_client.Text = "Adicionar Sabores";
            add_client.TextImageRelation = TextImageRelation.ImageAboveText;
            add_client.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(195, 23);
            button1.Name = "button1";
            button1.Size = new Size(151, 76);
            button1.TabIndex = 4;
            button1.Text = "Adicionar Tamanhos";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(366, 23);
            button2.Name = "button2";
            button2.Size = new Size(151, 76);
            button2.TabIndex = 5;
            button2.Text = "Adicionar Opcionais";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(add_client);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            Text = "Pizzas";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button add_client;
        private Button button1;
        private Button button2;
    }
}