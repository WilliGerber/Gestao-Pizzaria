namespace PizzariaZe
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            add_client = new Button();
            SuspendLayout();
            // 
            // add_client
            // 
            add_client.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            add_client.Image = (Image)resources.GetObject("add_client.Image");
            add_client.Location = new Point(22, 23);
            add_client.Name = "add_client";
            add_client.Size = new Size(151, 76);
            add_client.TabIndex = 2;
            add_client.Text = "Adicionar Cliente";
            add_client.TextImageRelation = TextImageRelation.ImageAboveText;
            add_client.UseVisualStyleBackColor = true;
            add_client.Click += add_client_Click;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add_client);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clients";
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button add_client;
    }
}