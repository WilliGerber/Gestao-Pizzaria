namespace PizzariaZe
{
    partial class CreateEditPizzaSizes
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
            btn_save = new Button();
            btn_cancel = new Button();
            lbl_flavour = new Label();
            listBoxTamanho = new ComboBox();
            valor_textBox = new TextBox();
            lbl_size_values = new Label();
            listBoxCategoria = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            valor_borda_textBox = new TextBox();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(250, 168);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(138, 35);
            btn_save.TabIndex = 8;
            btn_save.Text = "Salvar";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(254, 152, 152);
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 60);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(39, 168);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(138, 35);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lbl_flavour
            // 
            lbl_flavour.AutoSize = true;
            lbl_flavour.Location = new Point(39, 32);
            lbl_flavour.Name = "lbl_flavour";
            lbl_flavour.Size = new Size(56, 15);
            lbl_flavour.TabIndex = 59;
            lbl_flavour.Text = "Tamanho";
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.Location = new Point(39, 50);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(150, 23);
            listBoxTamanho.TabIndex = 1;
            // 
            // valor_textBox
            // 
            valor_textBox.Location = new Point(39, 112);
            valor_textBox.MaxLength = 9;
            valor_textBox.Name = "valor_textBox";
            valor_textBox.Size = new Size(150, 23);
            valor_textBox.TabIndex = 3;
            valor_textBox.KeyPress += valor_textBox_KeyPress;
            // 
            // lbl_size_values
            // 
            lbl_size_values.AutoSize = true;
            lbl_size_values.Location = new Point(39, 91);
            lbl_size_values.Name = "lbl_size_values";
            lbl_size_values.Size = new Size(33, 15);
            lbl_size_values.TabIndex = 77;
            lbl_size_values.Text = "Valor";
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.Location = new Point(238, 50);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(150, 23);
            listBoxCategoria.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 79;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 91);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 81;
            label2.Text = "Valor Adicional Borda";
            // 
            // valor_borda_textBox
            // 
            valor_borda_textBox.Location = new Point(238, 112);
            valor_borda_textBox.MaxLength = 9;
            valor_borda_textBox.Name = "valor_borda_textBox";
            valor_borda_textBox.Size = new Size(150, 23);
            valor_borda_textBox.TabIndex = 80;
            valor_borda_textBox.KeyPress += valor_borda_textBox_KeyPress;
            // 
            // CreateEditPizzaSizes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 221);
            Controls.Add(label2);
            Controls.Add(valor_borda_textBox);
            Controls.Add(listBoxCategoria);
            Controls.Add(label1);
            Controls.Add(lbl_size_values);
            Controls.Add(valor_textBox);
            Controls.Add(listBoxTamanho);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(lbl_flavour);
            KeyPreview = true;
            Name = "CreateEditPizzaSizes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Valores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_save;
        private Button btn_cancel;
        private Label lbl_flavour;
        private ComboBox listBoxTamanho;
        private TextBox valor_textBox;
        private Label lbl_size_values;
        private ComboBox listBoxCategoria;
        private Label label1;
        private Label label2;
        private TextBox valor_borda_textBox;
    }
}
