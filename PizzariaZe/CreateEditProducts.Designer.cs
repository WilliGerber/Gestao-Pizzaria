namespace PizzariaZe
{
    partial class CreateEditProducts
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
            lbl_name = new Label();
            tBoxProductName = new TextBox();
            lbl_type = new Label();
            lbl_unitary_cost = new Label();
            tBoxProductCost = new TextBox();
            lbl_product_quantity = new Label();
            tBoxProductQntBought = new TextBox();
            cBoxProductType = new ComboBox();
            panel1 = new Panel();
            cBoxProductUnit = new ComboBox();
            tBoxProductUnitQnt = new TextBox();
            lbl_sale_price = new Label();
            lbl_unity = new Label();
            tBoxProductPrice = new TextBox();
            lbl_package_quantity = new Label();
            lbl_product_info = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(254, 272);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(138, 35);
            btn_save.TabIndex = 9;
            btn_save.Text = "Salvar";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(254, 152, 152);
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 60);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(40, 272);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(138, 35);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(40, 23);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(45, 15);
            lbl_name.TabIndex = 78;
            lbl_name.Text = "Nome*";
            // 
            // tBoxProductName
            // 
            tBoxProductName.Location = new Point(40, 41);
            tBoxProductName.Name = "tBoxProductName";
            tBoxProductName.Size = new Size(352, 23);
            tBoxProductName.TabIndex = 1;
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Location = new Point(40, 79);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new Size(30, 15);
            lbl_type.TabIndex = 94;
            lbl_type.Text = "Tipo";
            // 
            // lbl_unitary_cost
            // 
            lbl_unitary_cost.AutoSize = true;
            lbl_unitary_cost.Location = new Point(166, 79);
            lbl_unitary_cost.Name = "lbl_unitary_cost";
            lbl_unitary_cost.Size = new Size(83, 15);
            lbl_unitary_cost.TabIndex = 96;
            lbl_unitary_cost.Text = "Custo Unitario";
            // 
            // tBoxProductCost
            // 
            tBoxProductCost.Location = new Point(166, 97);
            tBoxProductCost.MaxLength = 9;
            tBoxProductCost.Name = "tBoxProductCost";
            tBoxProductCost.Size = new Size(100, 23);
            tBoxProductCost.TabIndex = 3;
            tBoxProductCost.TextChanged += tBoxProductCost_TextChanged;
            // 
            // lbl_product_quantity
            // 
            lbl_product_quantity.AutoSize = true;
            lbl_product_quantity.Location = new Point(292, 79);
            lbl_product_quantity.Name = "lbl_product_quantity";
            lbl_product_quantity.Size = new Size(69, 15);
            lbl_product_quantity.TabIndex = 98;
            lbl_product_quantity.Text = "Quantidade";
            // 
            // tBoxProductQntBought
            // 
            tBoxProductQntBought.Location = new Point(292, 97);
            tBoxProductQntBought.Name = "tBoxProductQntBought";
            tBoxProductQntBought.Size = new Size(100, 23);
            tBoxProductQntBought.TabIndex = 4;
            // 
            // cBoxProductType
            // 
            cBoxProductType.FormattingEnabled = true;
            cBoxProductType.Location = new Point(40, 97);
            cBoxProductType.Name = "cBoxProductType";
            cBoxProductType.Size = new Size(100, 23);
            cBoxProductType.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cBoxProductUnit);
            panel1.Controls.Add(tBoxProductUnitQnt);
            panel1.Controls.Add(lbl_sale_price);
            panel1.Controls.Add(lbl_unity);
            panel1.Controls.Add(tBoxProductPrice);
            panel1.Controls.Add(lbl_package_quantity);
            panel1.Location = new Point(40, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 89);
            panel1.TabIndex = 100;
            // 
            // cBoxProductUnit
            // 
            cBoxProductUnit.FormattingEnabled = true;
            cBoxProductUnit.Location = new Point(9, 35);
            cBoxProductUnit.Name = "cBoxProductUnit";
            cBoxProductUnit.Size = new Size(100, 23);
            cBoxProductUnit.TabIndex = 5;
            // 
            // tBoxProductUnitQnt
            // 
            tBoxProductUnitQnt.Location = new Point(125, 35);
            tBoxProductUnitQnt.Name = "tBoxProductUnitQnt";
            tBoxProductUnitQnt.Size = new Size(100, 23);
            tBoxProductUnitQnt.TabIndex = 6;
            // 
            // lbl_sale_price
            // 
            lbl_sale_price.AutoSize = true;
            lbl_sale_price.Location = new Point(241, 17);
            lbl_sale_price.Name = "lbl_sale_price";
            lbl_sale_price.Size = new Size(88, 15);
            lbl_sale_price.TabIndex = 106;
            lbl_sale_price.Text = "Preço de Venda";
            // 
            // lbl_unity
            // 
            lbl_unity.AutoSize = true;
            lbl_unity.Location = new Point(9, 17);
            lbl_unity.Name = "lbl_unity";
            lbl_unity.Size = new Size(51, 15);
            lbl_unity.TabIndex = 102;
            lbl_unity.Text = "Unidade";
            // 
            // tBoxProductPrice
            // 
            tBoxProductPrice.Location = new Point(241, 35);
            tBoxProductPrice.MaxLength = 9;
            tBoxProductPrice.Name = "tBoxProductPrice";
            tBoxProductPrice.Size = new Size(100, 23);
            tBoxProductPrice.TabIndex = 7;
            tBoxProductPrice.TextChanged += tBoxProductPrice_TextChanged;
            // 
            // lbl_package_quantity
            // 
            lbl_package_quantity.AutoSize = true;
            lbl_package_quantity.Location = new Point(125, 17);
            lbl_package_quantity.Name = "lbl_package_quantity";
            lbl_package_quantity.Size = new Size(69, 15);
            lbl_package_quantity.TabIndex = 104;
            lbl_package_quantity.Text = "Quantidade";
            // 
            // lbl_product_info
            // 
            lbl_product_info.AutoSize = true;
            lbl_product_info.Location = new Point(40, 140);
            lbl_product_info.Name = "lbl_product_info";
            lbl_product_info.Size = new Size(136, 15);
            lbl_product_info.TabIndex = 101;
            lbl_product_info.Text = "Informações do Produto";
            // 
            // CreateEditProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 330);
            Controls.Add(lbl_product_info);
            Controls.Add(panel1);
            Controls.Add(cBoxProductType);
            Controls.Add(lbl_product_quantity);
            Controls.Add(tBoxProductQntBought);
            Controls.Add(lbl_unitary_cost);
            Controls.Add(tBoxProductCost);
            Controls.Add(lbl_type);
            Controls.Add(tBoxProductName);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(lbl_name);
            KeyPreview = true;
            Name = "CreateEditProducts";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Produtos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_save;
        private Button btn_cancel;
        private Label lbl_name;
        private TextBox tBoxProductName;
        private Label lbl_type;
        private Label lbl_unitary_cost;
        private TextBox tBoxProductCost;
        private Label lbl_product_quantity;
        private TextBox tBoxProductQntBought;
        private ComboBox cBoxProductType;
        private Panel panel1;
        private ComboBox cBoxProductUnit;
        private TextBox tBoxProductUnitQnt;
        private Label lbl_sale_price;
        private Label lbl_unity;
        private TextBox tBoxProductPrice;
        private Label lbl_package_quantity;
        private Label lbl_product_info;
    }
}