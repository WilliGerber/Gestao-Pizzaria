namespace PizzariaZe
{
    partial class CreateEditIngredients
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
            lbl_type = new Label();
            name_textBox = new TextBox();
            lbl_name = new Label();
            comboBox1 = new ComboBox();
            lbl_only_as_ingredient = new RadioButton();
            lbl_only_as_aditional = new RadioButton();
            lbl_is_aditional = new Label();
            lbl_aditional_and_ingredient = new RadioButton();
            btn_save = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.FlatStyle = FlatStyle.Popup;
            lbl_type.Location = new Point(37, 90);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new Size(30, 15);
            lbl_type.TabIndex = 29;
            lbl_type.Text = "Tipo";
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(37, 48);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(349, 23);
            name_textBox.TabIndex = 1;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(37, 30);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(45, 15);
            lbl_name.TabIndex = 27;
            lbl_name.Text = "Nome*";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(349, 23);
            comboBox1.TabIndex = 2;
            // 
            // lbl_only_as_ingredient
            // 
            lbl_only_as_ingredient.AutoSize = true;
            lbl_only_as_ingredient.Location = new Point(37, 173);
            lbl_only_as_ingredient.Name = "lbl_only_as_ingredient";
            lbl_only_as_ingredient.Size = new Size(135, 19);
            lbl_only_as_ingredient.TabIndex = 3;
            lbl_only_as_ingredient.TabStop = true;
            lbl_only_as_ingredient.Text = "Somente Ingrediente";
            lbl_only_as_ingredient.UseVisualStyleBackColor = true;
            // 
            // lbl_only_as_aditional
            // 
            lbl_only_as_aditional.AutoSize = true;
            lbl_only_as_aditional.Location = new Point(37, 198);
            lbl_only_as_aditional.Name = "lbl_only_as_aditional";
            lbl_only_as_aditional.Size = new Size(125, 19);
            lbl_only_as_aditional.TabIndex = 4;
            lbl_only_as_aditional.TabStop = true;
            lbl_only_as_aditional.Text = "Somente Adicional";
            lbl_only_as_aditional.UseVisualStyleBackColor = true;
            // 
            // lbl_is_aditional
            // 
            lbl_is_aditional.AutoSize = true;
            lbl_is_aditional.FlatStyle = FlatStyle.Popup;
            lbl_is_aditional.Location = new Point(37, 155);
            lbl_is_aditional.Name = "lbl_is_aditional";
            lbl_is_aditional.Size = new Size(62, 15);
            lbl_is_aditional.TabIndex = 57;
            lbl_is_aditional.Text = "Adicional?";
            // 
            // lbl_aditional_and_ingredient
            // 
            lbl_aditional_and_ingredient.AutoSize = true;
            lbl_aditional_and_ingredient.Location = new Point(37, 223);
            lbl_aditional_and_ingredient.Name = "lbl_aditional_and_ingredient";
            lbl_aditional_and_ingredient.Size = new Size(147, 19);
            lbl_aditional_and_ingredient.TabIndex = 5;
            lbl_aditional_and_ingredient.TabStop = true;
            lbl_aditional_and_ingredient.Text = "Adicional e Ingrediente";
            lbl_aditional_and_ingredient.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(248, 286);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(138, 35);
            btn_save.TabIndex = 7;
            btn_save.Text = "Salvar";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(254, 152, 152);
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 60);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(37, 286);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(138, 35);
            btn_cancel.TabIndex = 6;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // CreateEditIngredients
            // 
            AcceptButton = btn_save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_cancel;
            ClientSize = new Size(431, 346);
            Controls.Add(lbl_aditional_and_ingredient);
            Controls.Add(lbl_is_aditional);
            Controls.Add(lbl_only_as_aditional);
            Controls.Add(lbl_only_as_ingredient);
            Controls.Add(comboBox1);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(lbl_type);
            Controls.Add(name_textBox);
            Controls.Add(lbl_name);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateEditIngredients";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ingredientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_type;
        private TextBox name_textBox;
        private Label lbl_name;
        private ComboBox comboBox1;
        private RadioButton lbl_only_as_ingredient;
        private RadioButton lbl_only_as_aditional;
        private Label lbl_is_aditional;
        private RadioButton lbl_aditional_and_ingredient;
        private Button btn_save;
        private Button btn_cancel;
    }
}