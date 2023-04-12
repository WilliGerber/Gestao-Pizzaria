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
            save = new Button();
            cancel = new Button();
            type = new Label();
            name_textBox = new TextBox();
            name = new Label();
            button1 = new Button();
            class_comboBox = new ComboBox();
            categ = new Label();
            checkedListBox1 = new CheckedListBox();
            add_ingredients = new Button();
            label1 = new Label();
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
            add_type.TabIndex = 65;
            add_type.UseVisualStyleBackColor = false;
            // 
            // type_comboBox
            // 
            type_comboBox.FormattingEnabled = true;
            type_comboBox.Location = new Point(39, 110);
            type_comboBox.Name = "type_comboBox";
            type_comboBox.Size = new Size(125, 23);
            type_comboBox.TabIndex = 64;
            // 
            // save
            // 
            save.BackColor = Color.FromArgb(210, 229, 209);
            save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            save.FlatStyle = FlatStyle.Flat;
            save.Location = new Point(250, 388);
            save.Name = "save";
            save.Size = new Size(138, 35);
            save.TabIndex = 63;
            save.Text = "Salvar";
            save.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            cancel.BackColor = Color.FromArgb(254, 152, 152);
            cancel.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 60);
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.Location = new Point(39, 388);
            cancel.Name = "cancel";
            cancel.Size = new Size(138, 35);
            cancel.TabIndex = 62;
            cancel.Text = "Cancelar";
            cancel.UseVisualStyleBackColor = false;
            // 
            // type
            // 
            type.AutoSize = true;
            type.FlatStyle = FlatStyle.Popup;
            type.Location = new Point(39, 92);
            type.Name = "type";
            type.Size = new Size(30, 15);
            type.TabIndex = 61;
            type.Text = "Tipo";
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(39, 50);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(352, 23);
            name_textBox.TabIndex = 60;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(39, 32);
            name.Name = "name";
            name.Size = new Size(40, 15);
            name.TabIndex = 59;
            name.Text = "Nome";
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
            button1.TabIndex = 72;
            button1.UseVisualStyleBackColor = false;
            // 
            // class_comboBox
            // 
            class_comboBox.FormattingEnabled = true;
            class_comboBox.Location = new Point(231, 110);
            class_comboBox.Name = "class_comboBox";
            class_comboBox.Size = new Size(125, 23);
            class_comboBox.TabIndex = 71;
            // 
            // categ
            // 
            categ.AutoSize = true;
            categ.FlatStyle = FlatStyle.Popup;
            categ.Location = new Point(231, 92);
            categ.Name = "categ";
            categ.Size = new Size(58, 15);
            categ.TabIndex = 70;
            categ.Text = "Categoria";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Items.AddRange(new object[] { "Bacon", "Catupiry", "Frango", "Milho", "Molho Tomate", "Presunto", "Queijo Gorgonzola", "Queijo Muzzarela", "Queijo Prato", "Tomate" });
            checkedListBox1.Location = new Point(39, 188);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(352, 166);
            checkedListBox1.TabIndex = 73;
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
            add_ingredients.TabIndex = 74;
            add_ingredients.UseVisualStyleBackColor = false;
            add_ingredients.Click += add_ingredients_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Location = new Point(39, 167);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 75;
            label1.Text = "Ingredientes";
            // 
            // CreateEditFlavours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 442);
            Controls.Add(label1);
            Controls.Add(add_ingredients);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(class_comboBox);
            Controls.Add(categ);
            Controls.Add(add_type);
            Controls.Add(type_comboBox);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(type);
            Controls.Add(name_textBox);
            Controls.Add(name);
            Name = "CreateEditFlavours";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sabores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button add_type;
        private ComboBox type_comboBox;
        private Button save;
        private Button cancel;
        private Label type;
        private TextBox name_textBox;
        private Label name;
        private Button button1;
        private ComboBox class_comboBox;
        private Label categ;
        private CheckedListBox checkedListBox1;
        private Button add_ingredients;
        private Label label1;
    }
}