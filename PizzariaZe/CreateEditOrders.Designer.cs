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
            groupBox3 = new GroupBox();
            label9 = new Label();
            label6 = new Label();
            dataGridViewPizzas = new DataGridView();
            valorPizzas = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox_observacao = new TextBox();
            checkedListBox_sabores = new CheckedListBox();
            add_pizza_button = new Button();
            borda_combo_box = new ComboBox();
            tamanho_combo_box = new ComboBox();
            label1 = new Label();
            label7 = new Label();
            textBox_valortotal = new TextBox();
            groupBox4 = new GroupBox();
            label8 = new Label();
            checkedListBox_produtos = new CheckedListBox();
            radioButton_entrega = new RadioButton();
            radioButton_retirada = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPizzas).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(775, 576);
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
            btn_cancel.Location = new Point(517, 576);
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
            celphone_textBox.Leave += celphone_textBox_Leave;
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
            cpf_textBox.Leave += cpf_textBox_Leave;
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
            btn_add_client.Location = new Point(792, 18);
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
            button1.Location = new Point(792, 72);
            button1.Name = "button1";
            button1.Size = new Size(97, 48);
            button1.TabIndex = 123;
            button1.Text = "Editar";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(dataGridViewPizzas);
            groupBox3.Controls.Add(valorPizzas);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox_observacao);
            groupBox3.Controls.Add(checkedListBox_sabores);
            groupBox3.Controls.Add(add_pizza_button);
            groupBox3.Controls.Add(borda_combo_box);
            groupBox3.Controls.Add(tamanho_combo_box);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(643, 309);
            groupBox3.TabIndex = 124;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pizzas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(457, 254);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 144;
            label9.Text = "Valor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 28);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 139;
            label6.Text = "Observações";
            // 
            // dataGridViewPizzas
            // 
            dataGridViewPizzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPizzas.Location = new Point(219, 85);
            dataGridViewPizzas.Name = "dataGridViewPizzas";
            dataGridViewPizzas.RowTemplate.Height = 25;
            dataGridViewPizzas.Size = new Size(418, 109);
            dataGridViewPizzas.TabIndex = 125;
            // 
            // valorPizzas
            // 
            valorPizzas.Location = new Point(457, 272);
            valorPizzas.Name = "valorPizzas";
            valorPizzas.Size = new Size(149, 23);
            valorPizzas.TabIndex = 143;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 67);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 138;
            label5.Text = "Pizzas do Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 137;
            label4.Text = "Sabores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 129;
            label3.Text = "Borda";
            // 
            // textBox_observacao
            // 
            textBox_observacao.Location = new Point(219, 43);
            textBox_observacao.Multiline = true;
            textBox_observacao.Name = "textBox_observacao";
            textBox_observacao.Size = new Size(418, 23);
            textBox_observacao.TabIndex = 138;
            // 
            // checkedListBox_sabores
            // 
            checkedListBox_sabores.FormattingEnabled = true;
            checkedListBox_sabores.Location = new Point(12, 129);
            checkedListBox_sabores.Name = "checkedListBox_sabores";
            checkedListBox_sabores.Size = new Size(201, 166);
            checkedListBox_sabores.TabIndex = 136;
            // 
            // add_pizza_button
            // 
            add_pizza_button.BackColor = SystemColors.ActiveCaption;
            add_pizza_button.BackgroundImageLayout = ImageLayout.None;
            add_pizza_button.FlatStyle = FlatStyle.Popup;
            add_pizza_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            add_pizza_button.Image = (Image)resources.GetObject("add_pizza_button.Image");
            add_pizza_button.Location = new Point(219, 215);
            add_pizza_button.Name = "add_pizza_button";
            add_pizza_button.Size = new Size(46, 34);
            add_pizza_button.TabIndex = 125;
            add_pizza_button.TextImageRelation = TextImageRelation.ImageAboveText;
            add_pizza_button.UseVisualStyleBackColor = false;
            add_pizza_button.Click += add_pizza_button_Click;
            // 
            // borda_combo_box
            // 
            borda_combo_box.FormattingEnabled = true;
            borda_combo_box.Items.AddRange(new object[] { "Não", "Catupiry", "Cheddar", "Chocolate Branco", "Chocolate Preto" });
            borda_combo_box.Location = new Point(12, 85);
            borda_combo_box.Name = "borda_combo_box";
            borda_combo_box.Size = new Size(201, 23);
            borda_combo_box.TabIndex = 128;
            // 
            // tamanho_combo_box
            // 
            tamanho_combo_box.FormattingEnabled = true;
            tamanho_combo_box.Location = new Point(12, 43);
            tamanho_combo_box.Name = "tamanho_combo_box";
            tamanho_combo_box.Size = new Size(201, 23);
            tamanho_combo_box.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 120;
            label1.Text = "Tamanho";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(694, 507);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 131;
            label7.Text = "Valor Total";
            // 
            // textBox_valortotal
            // 
            textBox_valortotal.Location = new Point(691, 525);
            textBox_valortotal.Name = "textBox_valortotal";
            textBox_valortotal.Size = new Size(201, 23);
            textBox_valortotal.TabIndex = 130;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(checkedListBox_produtos);
            groupBox4.Location = new Point(674, 239);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(239, 194);
            groupBox4.TabIndex = 140;
            groupBox4.TabStop = false;
            groupBox4.Text = "Produtos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 29);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 140;
            label8.Text = "Selecione o Produto";
            // 
            // checkedListBox_produtos
            // 
            checkedListBox_produtos.FormattingEnabled = true;
            checkedListBox_produtos.Location = new Point(17, 47);
            checkedListBox_produtos.Name = "checkedListBox_produtos";
            checkedListBox_produtos.Size = new Size(201, 130);
            checkedListBox_produtos.TabIndex = 140;
            checkedListBox_produtos.ItemCheck += checkedListBox_produto_ItemCheck;
            // 
            // radioButton_entrega
            // 
            radioButton_entrega.AutoSize = true;
            radioButton_entrega.Location = new Point(691, 463);
            radioButton_entrega.Name = "radioButton_entrega";
            radioButton_entrega.Size = new Size(65, 19);
            radioButton_entrega.TabIndex = 141;
            radioButton_entrega.TabStop = true;
            radioButton_entrega.Text = "Entrega";
            radioButton_entrega.UseVisualStyleBackColor = true;
            // 
            // radioButton_retirada
            // 
            radioButton_retirada.AutoSize = true;
            radioButton_retirada.Location = new Point(804, 463);
            radioButton_retirada.Name = "radioButton_retirada";
            radioButton_retirada.Size = new Size(68, 19);
            radioButton_retirada.TabIndex = 143;
            radioButton_retirada.TabStop = true;
            radioButton_retirada.Text = "Retirada";
            radioButton_retirada.UseVisualStyleBackColor = true;
            // 
            // CreateEditOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(936, 632);
            Controls.Add(radioButton_retirada);
            Controls.Add(radioButton_entrega);
            Controls.Add(groupBox4);
            Controls.Add(label7);
            Controls.Add(textBox_valortotal);
            Controls.Add(groupBox3);
            Controls.Add(button1);
            Controls.Add(btn_add_client);
            Controls.Add(groupBox1);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateEditOrders";
            Text = "CreateEditOrders";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPizzas).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private GroupBox groupBox3;
        private Label label3;
        private ComboBox borda_combo_box;
        private Button add_pizza_button;
        private DataGridView dataGridViewPizzas;
        private Label label1;
        private ComboBox tamanho_combo_box;
        private Label label7;
        private TextBox textBox_valortotal;
        private Label label4;
        private CheckedListBox checkedListBox_sabores;
        private Label label5;
        private Label label6;
        private TextBox textBox_observacao;
        private GroupBox groupBox4;
        private Label label9;
        private TextBox valorPizzas;
        private Label label8;
        private CheckedListBox checkedListBox_produtos;
        private RadioButton radioButton_entrega;
        private RadioButton radioButton_retirada;
    }
}
