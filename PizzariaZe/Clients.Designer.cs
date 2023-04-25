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
            btn_add_client = new Button();
            SuspendLayout();
            // 
            // btn_add_client
            // 
            btn_add_client.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_client.Image = (Image)resources.GetObject("btn_add_client.Image");
            btn_add_client.Location = new Point(22, 23);
            btn_add_client.Name = "btn_add_client";
            btn_add_client.Size = new Size(151, 76);
            btn_add_client.TabIndex = 1;
            btn_add_client.Text = "Adicionar Cliente";
            btn_add_client.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add_client.UseVisualStyleBackColor = true;
            btn_add_client.Click += add_client_Click;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add_client);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Clients";
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add_client;
    }
}