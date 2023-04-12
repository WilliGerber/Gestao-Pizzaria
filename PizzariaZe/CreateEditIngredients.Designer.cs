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
            type = new Label();
            name_textBox = new TextBox();
            name = new Label();
            comboBox1 = new ComboBox();
            no = new RadioButton();
            yes = new RadioButton();
            label1 = new Label();
            radioButton1 = new RadioButton();
            save = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // type
            // 
            type.AutoSize = true;
            type.FlatStyle = FlatStyle.Popup;
            type.Location = new Point(37, 90);
            type.Name = "type";
            type.Size = new Size(30, 15);
            type.TabIndex = 29;
            type.Text = "Tipo";
            // 
            // name_textBox
            // 
            name_textBox.Location = new Point(37, 48);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(349, 23);
            name_textBox.TabIndex = 28;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(37, 30);
            name.Name = "name";
            name.Size = new Size(40, 15);
            name.TabIndex = 27;
            name.Text = "Nome";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(349, 23);
            comboBox1.TabIndex = 53;
            // 
            // no
            // 
            no.AutoSize = true;
            no.Location = new Point(37, 173);
            no.Name = "no";
            no.Size = new Size(135, 19);
            no.TabIndex = 55;
            no.TabStop = true;
            no.Text = "Somente Ingrediente";
            no.UseVisualStyleBackColor = true;
            // 
            // yes
            // 
            yes.AutoSize = true;
            yes.Location = new Point(37, 198);
            yes.Name = "yes";
            yes.Size = new Size(125, 19);
            yes.TabIndex = 56;
            yes.TabStop = true;
            yes.Text = "Somente Adicional";
            yes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Location = new Point(37, 155);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 57;
            label1.Text = "Adicional?";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(37, 223);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(147, 19);
            radioButton1.TabIndex = 58;
            radioButton1.TabStop = true;
            radioButton1.Text = "Adicional e Ingrediente";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            save.BackColor = Color.FromArgb(210, 229, 209);
            save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            save.FlatStyle = FlatStyle.Flat;
            save.Location = new Point(248, 286);
            save.Name = "save";
            save.Size = new Size(138, 35);
            save.TabIndex = 52;
            save.Text = "Salvar";
            save.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            cancel.BackColor = Color.FromArgb(254, 152, 152);
            cancel.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 60);
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.Location = new Point(37, 286);
            cancel.Name = "cancel";
            cancel.Size = new Size(138, 35);
            cancel.TabIndex = 51;
            cancel.Text = "Cancelar";
            cancel.UseVisualStyleBackColor = false;
            // 
            // CreateEditIngredients
            // 
            AcceptButton = save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancel;
            ClientSize = new Size(431, 346);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(yes);
            Controls.Add(no);
            Controls.Add(comboBox1);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(type);
            Controls.Add(name_textBox);
            Controls.Add(name);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateEditIngredients";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ingredientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label type;
        private TextBox name_textBox;
        private Label name;
        private ComboBox comboBox1;
        private RadioButton no;
        private RadioButton yes;
        private Label label1;
        private RadioButton radioButton1;
        private Button save;
        private Button cancel;
    }
}