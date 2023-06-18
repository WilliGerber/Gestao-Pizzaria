namespace PizzariaZe
{
    partial class CreateEditOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditOrders));
            btn_save = new Button();
            btn_cancel = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            nome_textBox = new TextBox();
            lbl_name = new Label();
            celphone_textBox = new TextBox();
            lbl_celphone = new Label();
            cpf_textBox = new TextBox();
            lbl_cpf = new Label();
            adress_complement_textBox = new TextBox();
            lbl_adress_complement = new Label();
            txt_house_number = new TextBox();
            lbl_house_number = new Label();
            neighborhood_textBox = new TextBox();
            lbl_neighborhood = new Label();
            street_textBox = new TextBox();
            lbl_street = new Label();
            btn_add_client = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(264, 492);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(138, 35);
            btn_save.TabIndex = 108;
            btn_save.Text = "Salvar";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(254, 152, 152);
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 60);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(24, 492);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(138, 35);
            btn_cancel.TabIndex = 107;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(adress_complement_textBox);
            groupBox1.Controls.Add(lbl_adress_complement);
            groupBox1.Controls.Add(txt_house_number);
            groupBox1.Controls.Add(lbl_house_number);
            groupBox1.Controls.Add(neighborhood_textBox);
            groupBox1.Controls.Add(lbl_neighborhood);
            groupBox1.Controls.Add(street_textBox);
            groupBox1.Controls.Add(lbl_street);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 221);
            groupBox1.TabIndex = 121;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nome_textBox);
            groupBox2.Controls.Add(lbl_name);
            groupBox2.Controls.Add(celphone_textBox);
            groupBox2.Controls.Add(lbl_celphone);
            groupBox2.Controls.Add(cpf_textBox);
            groupBox2.Controls.Add(lbl_cpf);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(762, 75);
            groupBox2.TabIndex = 121;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar";
            // 
            // nome_textBox
            // 
            nome_textBox.Location = new Point(6, 46);
            nome_textBox.Name = "nome_textBox";
            nome_textBox.Size = new Size(237, 23);
            nome_textBox.TabIndex = 109;
            nome_textBox.Leave += nome_textBox_Leave;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(6, 28);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(45, 15);
            lbl_name.TabIndex = 115;
            lbl_name.Text = "Nome*";
            // 
            // celphone_textBox
            // 
            celphone_textBox.Location = new Point(258, 46);
            celphone_textBox.Name = "celphone_textBox";
            celphone_textBox.Size = new Size(237, 23);
            celphone_textBox.TabIndex = 111;
            // 
            // lbl_celphone
            // 
            lbl_celphone.AutoSize = true;
            lbl_celphone.Location = new Point(258, 28);
            lbl_celphone.Name = "lbl_celphone";
            lbl_celphone.Size = new Size(49, 15);
            lbl_celphone.TabIndex = 119;
            lbl_celphone.Text = "Celular*";
            // 
            // cpf_textBox
            // 
            cpf_textBox.Location = new Point(511, 46);
            cpf_textBox.Name = "cpf_textBox";
            cpf_textBox.Size = new Size(240, 23);
            cpf_textBox.TabIndex = 110;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.FlatStyle = FlatStyle.Popup;
            lbl_cpf.Location = new Point(511, 28);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(33, 15);
            lbl_cpf.TabIndex = 116;
            lbl_cpf.Text = "CPF*";
            // 
            // adress_complement_textBox
            // 
            adress_complement_textBox.Location = new Point(226, 172);
            adress_complement_textBox.Name = "adress_complement_textBox";
            adress_complement_textBox.Size = new Size(521, 23);
            adress_complement_textBox.TabIndex = 114;
            // 
            // lbl_adress_complement
            // 
            lbl_adress_complement.AutoSize = true;
            lbl_adress_complement.Location = new Point(226, 154);
            lbl_adress_complement.Name = "lbl_adress_complement";
            lbl_adress_complement.Size = new Size(84, 15);
            lbl_adress_complement.TabIndex = 118;
            lbl_adress_complement.Text = "Complemento";
            // 
            // txt_house_number
            // 
            txt_house_number.Location = new Point(21, 172);
            txt_house_number.Name = "txt_house_number";
            txt_house_number.Size = new Size(174, 23);
            txt_house_number.TabIndex = 113;
            // 
            // lbl_house_number
            // 
            lbl_house_number.AutoSize = true;
            lbl_house_number.Location = new Point(22, 154);
            lbl_house_number.Name = "lbl_house_number";
            lbl_house_number.Size = new Size(51, 15);
            lbl_house_number.TabIndex = 117;
            lbl_house_number.Text = "Número";
            // 
            // neighborhood_textBox
            // 
            neighborhood_textBox.Location = new Point(402, 118);
            neighborhood_textBox.Name = "neighborhood_textBox";
            neighborhood_textBox.Size = new Size(345, 23);
            neighborhood_textBox.TabIndex = 11;
            // 
            // lbl_neighborhood
            // 
            lbl_neighborhood.AutoSize = true;
            lbl_neighborhood.Location = new Point(402, 100);
            lbl_neighborhood.Name = "lbl_neighborhood";
            lbl_neighborhood.Size = new Size(38, 15);
            lbl_neighborhood.TabIndex = 45;
            lbl_neighborhood.Text = "Bairro";
            // 
            // street_textBox
            // 
            street_textBox.Location = new Point(21, 118);
            street_textBox.Name = "street_textBox";
            street_textBox.Size = new Size(353, 23);
            street_textBox.TabIndex = 10;
            // 
            // lbl_street
            // 
            lbl_street.AutoSize = true;
            lbl_street.Location = new Point(25, 100);
            lbl_street.Name = "lbl_street";
            lbl_street.Size = new Size(27, 15);
            lbl_street.TabIndex = 32;
            lbl_street.Text = "Rua";
            // 
            // btn_add_client
            // 
            btn_add_client.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_client.Image = (Image)resources.GetObject("btn_add_client.Image");
            btn_add_client.Location = new Point(792, 12);
            btn_add_client.Name = "btn_add_client";
            btn_add_client.Size = new Size(97, 48);
            btn_add_client.TabIndex = 122;
            btn_add_client.Text = "Cliente";
            btn_add_client.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add_client.UseVisualStyleBackColor = true;
            btn_add_client.Click += btn_add_client_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(792, 66);
            button1.Name = "button1";
            button1.Size = new Size(97, 48);
            button1.TabIndex = 123;
            button1.Text = "Editar";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // CreateEditOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 551);
            Controls.Add(button1);
            Controls.Add(btn_add_client);
            Controls.Add(groupBox1);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Name = "CreateEditOrders";
            Text = "CreateEditOrders";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_save;
        private Button btn_cancel;
        private GroupBox groupBox1;
        private TextBox neighborhood_textBox;
        private Label lbl_neighborhood;
        private TextBox street_textBox;
        private Label lbl_street;
        private TextBox adress_complement_textBox;
        private Label lbl_adress_complement;
        private TextBox txt_house_number;
        private TextBox celphone_textBox;
        private Label lbl_house_number;
        private Label lbl_celphone;
        private TextBox cpf_textBox;
        private Label lbl_cpf;
        private TextBox nome_textBox;
        private Label lbl_name;
        private GroupBox groupBox2;
        private Button btn_add_client;
        private Button button1;
    }
}