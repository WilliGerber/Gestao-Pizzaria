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
            btn_save = new Button();
            btn_cancel = new Button();
            lbl_flavour = new Label();
            comboBox1 = new ComboBox();
            add_flavours = new Button();
            lbl_size_small = new Label();
            PizzaP = new TextBox();
            PizzaM = new TextBox();
            lbl_size_medium = new Label();
            PizzaG = new TextBox();
            lbl_size_big = new Label();
            PizzaGG = new TextBox();
            lbl_size_giant = new Label();
            lbl_sizes = new Label();
            lbl_size_values = new Label();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(250, 281);
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
            btn_cancel.Location = new Point(39, 281);
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
            lbl_flavour.Size = new Size(37, 15);
            lbl_flavour.TabIndex = 59;
            lbl_flavour.Text = "Sabor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(317, 23);
            comboBox1.TabIndex = 1;
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
            add_flavours.TabIndex = 2;
            add_flavours.UseVisualStyleBackColor = false;
            add_flavours.Click += add_flavours_Click;
            // 
            // lbl_size_small
            // 
            lbl_size_small.AutoSize = true;
            lbl_size_small.Location = new Point(39, 134);
            lbl_size_small.Name = "lbl_size_small";
            lbl_size_small.Size = new Size(54, 15);
            lbl_size_small.TabIndex = 68;
            lbl_size_small.Text = "Pequeno";
            // 
            // PizzaP
            // 
            PizzaP.Location = new Point(109, 131);
            PizzaP.MaxLength = 9;
            PizzaP.Name = "PizzaP";
            PizzaP.Size = new Size(100, 23);
            PizzaP.TabIndex = 3;
            PizzaP.TextChanged += PizzaP_TextChanged;
            // 
            // PizzaM
            // 
            PizzaM.Location = new Point(109, 160);
            PizzaM.MaxLength = 9;
            PizzaM.Name = "PizzaM";
            PizzaM.Size = new Size(100, 23);
            PizzaM.TabIndex = 4;
            PizzaM.TextChanged += PizzaM_TextChanged;
            // 
            // lbl_size_medium
            // 
            lbl_size_medium.AutoSize = true;
            lbl_size_medium.Location = new Point(39, 163);
            lbl_size_medium.Name = "lbl_size_medium";
            lbl_size_medium.Size = new Size(41, 15);
            lbl_size_medium.TabIndex = 70;
            lbl_size_medium.Text = "Médio";
            // 
            // PizzaG
            // 
            PizzaG.Location = new Point(109, 189);
            PizzaG.MaxLength = 9;
            PizzaG.Name = "PizzaG";
            PizzaG.Size = new Size(100, 23);
            PizzaG.TabIndex = 5;
            PizzaG.TextChanged += PizzaG_TextChanged;
            // 
            // lbl_size_big
            // 
            lbl_size_big.AutoSize = true;
            lbl_size_big.Location = new Point(39, 192);
            lbl_size_big.Name = "lbl_size_big";
            lbl_size_big.Size = new Size(45, 15);
            lbl_size_big.TabIndex = 72;
            lbl_size_big.Text = "Grande";
            // 
            // PizzaGG
            // 
            PizzaGG.Location = new Point(109, 218);
            PizzaGG.MaxLength = 9;
            PizzaGG.Name = "PizzaGG";
            PizzaGG.Size = new Size(100, 23);
            PizzaGG.TabIndex = 6;
            PizzaGG.TextChanged += PizzaGG_TextChanged;
            // 
            // lbl_size_giant
            // 
            lbl_size_giant.AutoSize = true;
            lbl_size_giant.Location = new Point(39, 221);
            lbl_size_giant.Name = "lbl_size_giant";
            lbl_size_giant.Size = new Size(48, 15);
            lbl_size_giant.TabIndex = 74;
            lbl_size_giant.Text = "Gigante";
            // 
            // lbl_sizes
            // 
            lbl_sizes.AutoSize = true;
            lbl_sizes.Location = new Point(39, 110);
            lbl_sizes.Name = "lbl_sizes";
            lbl_sizes.Size = new Size(61, 15);
            lbl_sizes.TabIndex = 76;
            lbl_sizes.Text = "Tamanhos";
            // 
            // lbl_size_values
            // 
            lbl_size_values.AutoSize = true;
            lbl_size_values.Location = new Point(109, 110);
            lbl_size_values.Name = "lbl_size_values";
            lbl_size_values.Size = new Size(44, 15);
            lbl_size_values.TabIndex = 77;
            lbl_size_values.Text = "Valores";
            // 
            // CreateEditPizzaSizes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 330);
            Controls.Add(lbl_size_values);
            Controls.Add(lbl_sizes);
            Controls.Add(PizzaGG);
            Controls.Add(lbl_size_giant);
            Controls.Add(PizzaG);
            Controls.Add(lbl_size_big);
            Controls.Add(PizzaM);
            Controls.Add(lbl_size_medium);
            Controls.Add(PizzaP);
            Controls.Add(lbl_size_small);
            Controls.Add(add_flavours);
            Controls.Add(comboBox1);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(lbl_flavour);
            KeyPreview = true;
            Name = "CreateEditPizzaSizes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sabores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_save;
        private Button btn_cancel;
        private Label lbl_flavour;
        private ComboBox comboBox1;
        private Button add_flavours;
        private Label lbl_size_small;
        private TextBox PizzaP;
        private TextBox PizzaM;
        private Label lbl_size_medium;
        private TextBox PizzaG;
        private Label lbl_size_big;
        private TextBox PizzaGG;
        private Label lbl_size_giant;
        private Label lbl_sizes;
        private Label lbl_size_values;
    }
}
