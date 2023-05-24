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
            checkBox_language_restart = new CheckBox();
            comboBox_language = new ComboBox();
            label1 = new Label();
            lbl_language_region = new Label();
            lbl_db = new Label();
            panel2 = new Panel();
            txt_box_connection_string = new TextBox();
            lbl_connection_string = new Label();
            cmb_box_provider = new ComboBox();
            lbl_provider = new Label();
            btn_save_settings_Click = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBox_language_restart);
            panel1.Controls.Add(comboBox_language);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 104);
            panel1.TabIndex = 0;
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
            // lbl_db
            // 
            lbl_db.AutoSize = true;
            lbl_db.BackColor = SystemColors.Control;
            lbl_db.FlatStyle = FlatStyle.Flat;
            lbl_db.Location = new Point(17, 145);
            lbl_db.Name = "lbl_db";
            lbl_db.Size = new Size(92, 15);
            lbl_db.TabIndex = 102;
            lbl_db.Text = "Banco de Dados";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_box_connection_string);
            panel2.Controls.Add(lbl_connection_string);
            panel2.Controls.Add(cmb_box_provider);
            panel2.Controls.Add(lbl_provider);
            panel2.Location = new Point(12, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 146);
            panel2.TabIndex = 101;
            // 
            // txt_box_connection_string
            // 
            txt_box_connection_string.Location = new Point(22, 96);
            txt_box_connection_string.Name = "txt_box_connection_string";
            txt_box_connection_string.Size = new Size(729, 23);
            txt_box_connection_string.TabIndex = 4;
            // 
            // lbl_connection_string
            // 
            lbl_connection_string.AutoSize = true;
            lbl_connection_string.BackColor = SystemColors.Control;
            lbl_connection_string.FlatStyle = FlatStyle.Flat;
            lbl_connection_string.Location = new Point(22, 78);
            lbl_connection_string.Name = "lbl_connection_string";
            lbl_connection_string.Size = new Size(104, 15);
            lbl_connection_string.TabIndex = 3;
            lbl_connection_string.Text = "String de Conexão";
            // 
            // cmb_box_provider
            // 
            cmb_box_provider.FormattingEnabled = true;
            cmb_box_provider.Items.AddRange(new object[] { "MySql.Data.MySqlClient", "Sql.Data.SqlClient" });
            cmb_box_provider.Location = new Point(23, 41);
            cmb_box_provider.Name = "cmb_box_provider";
            cmb_box_provider.Size = new Size(367, 23);
            cmb_box_provider.TabIndex = 0;
            // 
            // lbl_provider
            // 
            lbl_provider.AutoSize = true;
            lbl_provider.BackColor = SystemColors.Control;
            lbl_provider.FlatStyle = FlatStyle.Flat;
            lbl_provider.Location = new Point(23, 23);
            lbl_provider.Name = "lbl_provider";
            lbl_provider.Size = new Size(54, 15);
            lbl_provider.TabIndex = 1;
            lbl_provider.Text = "Provider:";
            // 
            // btn_save_settings_Click
            // 
            btn_save_settings_Click.BackColor = Color.FromArgb(210, 229, 209);
            btn_save_settings_Click.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save_settings_Click.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save_settings_Click.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save_settings_Click.FlatStyle = FlatStyle.Flat;
            btn_save_settings_Click.Location = new Point(12, 305);
            btn_save_settings_Click.Name = "btn_save_settings_Click";
            btn_save_settings_Click.Size = new Size(776, 35);
            btn_save_settings_Click.TabIndex = 2;
            btn_save_settings_Click.Text = "Salvar";
            btn_save_settings_Click.UseVisualStyleBackColor = false;
            btn_save_settings_Click.Click += btn_save_settings_Click_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_db);
            Controls.Add(panel2);
            Controls.Add(btn_save_settings_Click);
            Controls.Add(lbl_language_region);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Settings";
            Text = "Configurações";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox_language_restart;
        private ComboBox comboBox_language;
        private Label label1;
        private Label lbl_language_region;
        private Label lbl_db;
        private Panel panel2;
        private Button btn_save_settings_Click;
        private CheckBox checkBox1;
        private ComboBox cmb_box_provider;
        private Label lbl_provider;
        private TextBox txt_box_connection_string;
        private Label lbl_connection_string;
    }
}