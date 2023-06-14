namespace PizzariaZe
{
    partial class Sabores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sabores));
            dataGridViewDados = new DataGridView();
            btn_add_flavours = new Button();
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
            dataGridViewDados.TabIndex = 5;
            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            // 
            // btn_add_flavours
            // 
            btn_add_flavours.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_flavours.Image = (Image)resources.GetObject("btn_add_flavours.Image");
            btn_add_flavours.Location = new Point(817, 12);
            btn_add_flavours.Name = "btn_add_flavours";
            btn_add_flavours.Size = new Size(151, 76);
            btn_add_flavours.TabIndex = 4;
            btn_add_flavours.Text = "Adicionar Sabores";
            btn_add_flavours.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add_flavours.UseVisualStyleBackColor = true;
            btn_add_flavours.Click += btn_add_flavours_Click;
            // 
            // Sabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 492);
            Controls.Add(dataGridViewDados);
            Controls.Add(btn_add_flavours);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sabores";
            Text = "Sabores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDados;
        private Button btn_add_flavours;
    }
}