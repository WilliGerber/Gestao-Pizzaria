namespace PizzariaZe
{
    partial class CreateEditClients
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
            email_textBox = new TextBox();
            lbl_Email = new Label();
            celphone_textBox = new TextBox();
            lbl_celphone = new Label();
            cpf_textBox = new TextBox();
            lbl_cpf = new Label();
            name_textBox = new TextBox();
            lbl_name = new Label();
            label1 = new Label();
            lbl_street = new Label();
            street_textBox = new TextBox();
            lbl_neighborhood = new Label();
            neighborhood_textBox = new TextBox();
            lbl_house_number = new Label();
            txt_house_number = new TextBox();
            lbl_adress_complement = new Label();
            adress_complement_textBox = new TextBox();
            lbl_uf = new Label();
            txt_box_uf = new TextBox();
            groupBox1 = new GroupBox();
            txt_box_country = new TextBox();
            lbl_country = new Label();
            txt_box_city = new TextBox();
            lbl_city = new Label();
            msk_text_box_cep = new MaskedTextBox();
            txt_box_id = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(625, 454);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(138, 35);
            btn_save.TabIndex = 9;
            btn_save.Text = "Salvar";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(254, 152, 152);
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 60);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(37, 454);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(138, 35);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(414, 111);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(349, 23);
            email_textBox.TabIndex = 4;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(414, 93);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(41, 15);
            lbl_Email.TabIndex = 49;
            lbl_Email.Text = "E-mail";
            // 
            // celphone_textBox
            // 
            celphone_textBox.Location = new Point(37, 111);
            celphone_textBox.Name = "celphone_textBox";
            celphone_textBox.Size = new Size(349, 23);
            celphone_textBox.TabIndex = 3;
            // 
            // lbl_celphone
            // 
            lbl_celphone.AutoSize = true;
            lbl_celphone.Location = new Point(37, 93);
            lbl_celphone.Name = "lbl_celphone";
            lbl_celphone.Size = new Size(49, 15);
            lbl_celphone.TabIndex = 48;
            lbl_celphone.Text = "Celular*";
            // 
            // cpf_textBox
            // 
            cpf_textBox.Location = new Point(414, 48);
            cpf_textBox.Name = "cpf_textBox";
            cpf_textBox.Size = new Size(349, 23);
            cpf_textBox.TabIndex = 2;
            cpf_textBox.TextChanged += cpf_textBox_TextChanged;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.FlatStyle = FlatStyle.Popup;
            lbl_cpf.Location = new Point(414, 30);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(33, 15);
            lbl_cpf.TabIndex = 29;
            lbl_cpf.Text = "CPF*";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 155);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 56;
            label1.Text = "CEP*";
            // 
            // lbl_street
            // 
            lbl_street.AutoSize = true;
            lbl_street.Location = new Point(28, 16);
            lbl_street.Name = "lbl_street";
            lbl_street.Size = new Size(27, 15);
            lbl_street.TabIndex = 32;
            lbl_street.Text = "Rua";
            // 
            // street_textBox
            // 
            street_textBox.Location = new Point(24, 34);
            street_textBox.Name = "street_textBox";
            street_textBox.Size = new Size(353, 23);
            street_textBox.TabIndex = 10;
            // 
            // lbl_neighborhood
            // 
            lbl_neighborhood.AutoSize = true;
            lbl_neighborhood.Location = new Point(405, 16);
            lbl_neighborhood.Name = "lbl_neighborhood";
            lbl_neighborhood.Size = new Size(38, 15);
            lbl_neighborhood.TabIndex = 45;
            lbl_neighborhood.Text = "Bairro";
            // 
            // neighborhood_textBox
            // 
            neighborhood_textBox.Location = new Point(405, 34);
            neighborhood_textBox.Name = "neighborhood_textBox";
            neighborhood_textBox.Size = new Size(345, 23);
            neighborhood_textBox.TabIndex = 11;
            // 
            // lbl_house_number
            // 
            lbl_house_number.AutoSize = true;
            lbl_house_number.Location = new Point(38, 368);
            lbl_house_number.Name = "lbl_house_number";
            lbl_house_number.Size = new Size(51, 15);
            lbl_house_number.TabIndex = 46;
            lbl_house_number.Text = "Número";
            // 
            // txt_house_number
            // 
            txt_house_number.Location = new Point(37, 386);
            txt_house_number.Name = "txt_house_number";
            txt_house_number.Size = new Size(174, 23);
            txt_house_number.TabIndex = 6;
            // 
            // lbl_adress_complement
            // 
            lbl_adress_complement.AutoSize = true;
            lbl_adress_complement.Location = new Point(242, 368);
            lbl_adress_complement.Name = "lbl_adress_complement";
            lbl_adress_complement.Size = new Size(84, 15);
            lbl_adress_complement.TabIndex = 47;
            lbl_adress_complement.Text = "Complemento";
            // 
            // adress_complement_textBox
            // 
            adress_complement_textBox.Location = new Point(242, 386);
            adress_complement_textBox.Name = "adress_complement_textBox";
            adress_complement_textBox.Size = new Size(521, 23);
            adress_complement_textBox.TabIndex = 7;
            // 
            // lbl_uf
            // 
            lbl_uf.AutoSize = true;
            lbl_uf.Location = new Point(405, 80);
            lbl_uf.Name = "lbl_uf";
            lbl_uf.Size = new Size(21, 15);
            lbl_uf.TabIndex = 54;
            lbl_uf.Text = "UF";
            // 
            // txt_box_uf
            // 
            txt_box_uf.Location = new Point(405, 98);
            txt_box_uf.Name = "txt_box_uf";
            txt_box_uf.Size = new Size(49, 23);
            txt_box_uf.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_box_country);
            groupBox1.Controls.Add(lbl_country);
            groupBox1.Controls.Add(txt_box_city);
            groupBox1.Controls.Add(lbl_city);
            groupBox1.Controls.Add(txt_box_uf);
            groupBox1.Controls.Add(lbl_uf);
            groupBox1.Controls.Add(neighborhood_textBox);
            groupBox1.Controls.Add(lbl_neighborhood);
            groupBox1.Controls.Add(street_textBox);
            groupBox1.Controls.Add(lbl_street);
            groupBox1.Location = new Point(13, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 148);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Endereço";
            // 
            // txt_box_country
            // 
            txt_box_country.Location = new Point(479, 98);
            txt_box_country.Name = "txt_box_country";
            txt_box_country.Size = new Size(271, 23);
            txt_box_country.TabIndex = 14;
            // 
            // lbl_country
            // 
            lbl_country.AutoSize = true;
            lbl_country.Location = new Point(479, 80);
            lbl_country.Name = "lbl_country";
            lbl_country.Size = new Size(28, 15);
            lbl_country.TabIndex = 58;
            lbl_country.Text = "País";
            // 
            // txt_box_city
            // 
            txt_box_city.Location = new Point(24, 98);
            txt_box_city.Name = "txt_box_city";
            txt_box_city.Size = new Size(353, 23);
            txt_box_city.TabIndex = 12;
            // 
            // lbl_city
            // 
            lbl_city.AutoSize = true;
            lbl_city.Location = new Point(28, 80);
            lbl_city.Name = "lbl_city";
            lbl_city.Size = new Size(44, 15);
            lbl_city.TabIndex = 56;
            lbl_city.Text = "Cidade";
            // 
            // msk_text_box_cep
            // 
            msk_text_box_cep.Location = new Point(37, 178);
            msk_text_box_cep.Mask = "00.000-000";
            msk_text_box_cep.Name = "msk_text_box_cep";
            msk_text_box_cep.Size = new Size(126, 23);
            msk_text_box_cep.TabIndex = 5;
            msk_text_box_cep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msk_text_box_cep.Leave += msk_text_box_cep_Leave;
            // 
            // txt_box_id
            // 
            txt_box_id.Location = new Point(414, 178);
            txt_box_id.Name = "txt_box_id";
            txt_box_id.Size = new Size(349, 23);
            txt_box_id.TabIndex = 59;
            txt_box_id.Visible = false;
            // 
            // CreateEditClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(txt_box_id);
            Controls.Add(msk_text_box_cep);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(email_textBox);
            Controls.Add(adress_complement_textBox);
            Controls.Add(lbl_adress_complement);
            Controls.Add(lbl_Email);
            Controls.Add(txt_house_number);
            Controls.Add(celphone_textBox);
            Controls.Add(lbl_house_number);
            Controls.Add(lbl_celphone);
            Controls.Add(cpf_textBox);
            Controls.Add(lbl_cpf);
            Controls.Add(name_textBox);
            Controls.Add(lbl_name);
            Name = "CreateEditClients";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateEditClients";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_save;
        private Button btn_cancel;
        private TextBox email_textBox;
        private Label lbl_Email;
        private TextBox celphone_textBox;
        private Label lbl_celphone;
        private TextBox cpf_textBox;
        private Label lbl_cpf;
        private TextBox name_textBox;
        private Label lbl_name;
        private Label label1;
        private Label lbl_street;
        private TextBox street_textBox;
        private Label lbl_neighborhood;
        private TextBox neighborhood_textBox;
        private Label lbl_house_number;
        private TextBox txt_house_number;
        private Label lbl_adress_complement;
        private TextBox adress_complement_textBox;
        private Label lbl_uf;
        private TextBox txt_box_uf;
        private GroupBox groupBox1;
        private TextBox txt_box_country;
        private Label lbl_country;
        private TextBox txt_box_city;
        private Label lbl_city;
        private MaskedTextBox msk_text_box_cep;
        private TextBox txt_box_id;
    }
}
