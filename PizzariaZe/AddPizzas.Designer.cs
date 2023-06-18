namespace PizzariaZe
{
    partial class AddPizzas
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
            label3 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            tamanho_combo_box = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            btn_save = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 81);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 133;
            label3.Text = "Borda";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(25, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 23);
            comboBox2.TabIndex = 132;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 131;
            label1.Text = "Tamanho";
            // 
            // tamanho_combo_box
            // 
            tamanho_combo_box.FormattingEnabled = true;
            tamanho_combo_box.Location = new Point(25, 48);
            tamanho_combo_box.Name = "tamanho_combo_box";
            tamanho_combo_box.Size = new Size(201, 23);
            tamanho_combo_box.TabIndex = 130;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(247, 48);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(201, 256);
            checkedListBox1.TabIndex = 134;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 30);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 135;
            label2.Text = "Sabores";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(310, 403);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(138, 35);
            btn_save.TabIndex = 137;
            btn_save.Text = "Salvar";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(254, 152, 152);
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 60);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(25, 403);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(138, 35);
            btn_cancel.TabIndex = 136;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // AddPizzas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(tamanho_combo_box);
            Name = "AddPizzas";
            Text = "Adicionar Pizzas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox comboBox2;
        private Label label1;
        private ComboBox tamanho_combo_box;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Button btn_save;
        private Button btn_cancel;
    }
}