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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditPizzaSizes));
            save = new Button();
            cancel = new Button();
            name = new Label();
            comboBox1 = new ComboBox();
            add_flavours = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // save
            // 
            save.BackColor = Color.FromArgb(210, 229, 209);
            save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            save.FlatStyle = FlatStyle.Flat;
            save.Location = new Point(250, 281);
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
            cancel.Location = new Point(39, 281);
            cancel.Name = "cancel";
            cancel.Size = new Size(138, 35);
            cancel.TabIndex = 62;
            cancel.Text = "Cancelar";
            cancel.UseVisualStyleBackColor = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(39, 32);
            name.Name = "name";
            name.Size = new Size(37, 15);
            name.TabIndex = 59;
            name.Text = "Sabor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(317, 23);
            comboBox1.TabIndex = 66;
            // 
            // add_flavours
            // 
            add_flavours.BackColor = Color.FromArgb(159, 210, 249);
            add_flavours.FlatAppearance.BorderColor = Color.FromArgb(66, 153, 249);
            add_flavours.FlatStyle = FlatStyle.Flat;
            add_flavours.Image = (Image)resources.GetObject("add_flavours.Image");
            add_flavours.Location = new Point(362, 50);
            add_flavours.Name = "add_flavours";
            add_flavours.Size = new Size(29, 23);
            add_flavours.TabIndex = 67;
            add_flavours.UseVisualStyleBackColor = false;
            add_flavours.Click += add_flavours_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 134);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 68;
            label1.Text = "Pequeno";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 69;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 163);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 70;
            label2.Text = "Médio";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(109, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 192);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 72;
            label3.Text = "Grande";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(109, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 221);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 74;
            label4.Text = "Gigante";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 110);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 76;
            label5.Text = "Tamanhos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 110);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 77;
            label6.Text = "Valores";
            // 
            // CreateEditPizzaSizes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 330);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(add_flavours);
            Controls.Add(comboBox1);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(name);
            Name = "CreateEditPizzaSizes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sabores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button save;
        private Button cancel;
        private Label name;
        private ComboBox comboBox1;
        private Button add_flavours;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
