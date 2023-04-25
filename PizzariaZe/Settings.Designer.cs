namespace PizzariaZe
{
    partial class Settings
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
            panel1 = new Panel();
            btn_save = new Button();
            checkBox_language_restart = new CheckBox();
            comboBox_language = new ComboBox();
            label1 = new Label();
            lbl_language_region = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(checkBox_language_restart);
            panel1.Controls.Add(comboBox_language);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 104);
            panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(633, 64);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(138, 35);
            btn_save.TabIndex = 2;
            btn_save.Text = "Salvar";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_language_restart
            // 
            checkBox_language_restart.AutoSize = true;
            checkBox_language_restart.Location = new Point(187, 44);
            checkBox_language_restart.Name = "checkBox_language_restart";
            checkBox_language_restart.Size = new Size(298, 19);
            checkBox_language_restart.TabIndex = 1;
            checkBox_language_restart.Text = "Reiniciar para aplicar o novo idioma imediatamente";
            checkBox_language_restart.UseVisualStyleBackColor = true;
            // 
            // comboBox_language
            // 
            comboBox_language.FormattingEnabled = true;
            comboBox_language.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBox_language.Location = new Point(23, 41);
            comboBox_language.Name = "comboBox_language";
            comboBox_language.Size = new Size(144, 23);
            comboBox_language.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Idioma/Região";
            // 
            // lbl_language_region
            // 
            lbl_language_region.AutoSize = true;
            lbl_language_region.BackColor = SystemColors.Control;
            lbl_language_region.FlatStyle = FlatStyle.Flat;
            lbl_language_region.Location = new Point(17, 21);
            lbl_language_region.Name = "lbl_language_region";
            lbl_language_region.Size = new Size(85, 15);
            lbl_language_region.TabIndex = 100;
            lbl_language_region.Text = "Idioma/Região";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_language_region);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Settings";
            Text = "Configurações";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox_language_restart;
        private ComboBox comboBox_language;
        private Label label1;
        private Label lbl_language_region;
        private Button btn_save;
    }
}