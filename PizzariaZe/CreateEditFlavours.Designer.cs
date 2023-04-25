namespace PizzariaZe
{
    partial class CreateEditFlavours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditFlavours));
            add_type = new Button();
            type_comboBox = new ComboBox();
            btn_save = new Button();
            btn_cancel = new Button();
            lbl_type = new Label();
            name_textBox = new TextBox();
            lbl_name = new Label();
            button1 = new Button();
            class_comboBox = new ComboBox();
            lbl_category = new Label();
            checkedListBox1 = new CheckedListBox();
            add_ingredients = new Button();
            lbl_ingredients = new Label();
            SuspendLayout();
            // 
            // add_type
            // 
            add_type.BackColor = Color.FromArgb(159, 210, 249);
            add_type.FlatAppearance.BorderColor = Color.FromArgb(66, 153, 249);
            add_type.FlatStyle = FlatStyle.Flat;
            add_type.Image = (Image)resources.GetObject("add_type.Image");
            add_type.Location = new Point(170, 110);
            add_type.Name = "add_type";
            add_type.Size = new Size(29, 23);
            add_type.TabIndex = 3;
            add_type.UseVisualStyleBackColor = false;
            // 
            // type_comboBox
            // 
            type_comboBox.FormattingEnabled = true;
            type_comboBox.Location = new Point(39, 110);
            type_comboBox.Name = "type_comboBox";
            type_comboBox.Size = new Size(125, 23);
            type_comboBox.TabIndex = 2;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(250, 388);
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
            btn_cancel.Location = new Point(39, 388);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(138, 35);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.FlatStyle = FlatStyle.Popup;
            lbl_type.Location = new Point(39, 92);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new Size(30, 15);
            lbl_type.TabIndex = 61;
            lbl_type.Text = "Tipo";
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(39, 50);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(352, 23);
            name_textBox.TabIndex = 1;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(39, 32);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(45, 15);
            lbl_name.TabIndex = 59;
            lbl_name.Text = "Nome*";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(159, 210, 249);
            button1.FlatAppearance.BorderColor = Color.FromArgb(66, 153, 249);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(362, 110);
            button1.Name = "button1";
            button1.Size = new Size(29, 23);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // class_comboBox
            // 
            class_comboBox.FormattingEnabled = true;
            class_comboBox.ItemHeight = 15;
            class_comboBox.Location = new Point(231, 110);
            class_comboBox.Name = "class_comboBox";
            class_comboBox.Size = new Size(125, 23);
            class_comboBox.TabIndex = 71;
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.FlatStyle = FlatStyle.Popup;
            lbl_category.Location = new Point(231, 92);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(58, 15);
            lbl_category.TabIndex = 70;
            lbl_category.Text = "Categoria";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Items.AddRange(new object[] { "Bacon", "Catupiry", "Frango", "Milho", "Molho Tomate", "Presunto", "Queijo Gorgonzola", "Queijo Muzzarela", "Queijo Prato", "Tomate" });
            checkedListBox1.Location = new Point(39, 188);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(352, 166);
            checkedListBox1.TabIndex = 100;
            // 
            // add_ingredients
            // 
            add_ingredients.BackColor = Color.FromArgb(159, 210, 249);
            add_ingredients.FlatAppearance.BorderColor = Color.FromArgb(66, 153, 249);
            add_ingredients.FlatStyle = FlatStyle.Flat;
            add_ingredients.Image = (Image)resources.GetObject("add_ingredients.Image");
            add_ingredients.Location = new Point(362, 159);
            add_ingredients.Name = "add_ingredients";
            add_ingredients.Size = new Size(29, 23);
            add_ingredients.TabIndex = 6;
            add_ingredients.UseVisualStyleBackColor = false;
            add_ingredients.Click += add_ingredients_Click;
            // 
            // lbl_ingredients
            // 
            lbl_ingredients.AutoSize = true;
            lbl_ingredients.FlatStyle = FlatStyle.Popup;
            lbl_ingredients.Location = new Point(39, 167);
            lbl_ingredients.Name = "lbl_ingredients";
            lbl_ingredients.Size = new Size(72, 15);
            lbl_ingredients.TabIndex = 75;
            lbl_ingredients.Text = "Ingredientes";
            // 
            // CreateEditFlavours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 442);
            Controls.Add(lbl_ingredients);
            Controls.Add(add_ingredients);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(class_comboBox);
            Controls.Add(lbl_category);
            Controls.Add(add_type);
            Controls.Add(type_comboBox);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(lbl_type);
            Controls.Add(name_textBox);
            Controls.Add(lbl_name);
            KeyPreview = true;
            Name = "CreateEditFlavours";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sabores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button add_type;
        private ComboBox type_comboBox;
        private Button btn_save;
        private Button btn_cancel;
        private Label lbl_type;
        private TextBox name_textBox;
        private Label lbl_name;
        private Button button1;
        private ComboBox class_comboBox;
        private Label lbl_category;
        private CheckedListBox checkedListBox1;
        private Button add_ingredients;
        private Label lbl_ingredients;
    }
}