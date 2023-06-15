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
            tBoxProductPrice = new TextBox();
            cBoxProductType = new ComboBox();
            cBoxProductUnit = new ComboBox();
            lbl_unity = new Label();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.BorderColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 229, 209);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 212, 167);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(254, 152);
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
            btn_cancel.Location = new Point(40, 152);
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
            tBoxProductName.Size = new Size(165, 23);
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
            lbl_unitary_cost.Location = new Point(229, 23);
            lbl_unitary_cost.Name = "lbl_unitary_cost";
            lbl_unitary_cost.Size = new Size(33, 15);
            lbl_unitary_cost.TabIndex = 96;
            lbl_unitary_cost.Text = "Valor";
            // 
            // tBoxProductPrice
            // 
            tBoxProductPrice.Location = new Point(229, 41);
            tBoxProductPrice.MaxLength = 9;
            tBoxProductPrice.Name = "tBoxProductPrice";
            tBoxProductPrice.Size = new Size(163, 23);
            tBoxProductPrice.TabIndex = 3;
            tBoxProductPrice.TextChanged += tBoxProductPrice_TextChanged;
            // 
            // cBoxProductType
            // 
            cBoxProductType.FormattingEnabled = true;
            cBoxProductType.Location = new Point(40, 97);
            cBoxProductType.Name = "cBoxProductType";
            cBoxProductType.Size = new Size(165, 23);
            cBoxProductType.TabIndex = 2;
            // 
            // cBoxProductUnit
            // 
            cBoxProductUnit.FormattingEnabled = true;
            cBoxProductUnit.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            cBoxProductUnit.Location = new Point(229, 97);
            cBoxProductUnit.Name = "cBoxProductUnit";
            cBoxProductUnit.Size = new Size(163, 23);
            cBoxProductUnit.TabIndex = 5;
            // 
            // lbl_unity
            // 
            lbl_unity.AutoSize = true;
            lbl_unity.Location = new Point(229, 79);
            lbl_unity.Name = "lbl_unity";
            lbl_unity.Size = new Size(51, 15);
            lbl_unity.TabIndex = 102;
            lbl_unity.Text = "Unidade";
            // 
            // CreateEditProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 211);
            Controls.Add(cBoxProductUnit);
            Controls.Add(lbl_unity);
            Controls.Add(cBoxProductType);
            Controls.Add(lbl_unitary_cost);
            Controls.Add(tBoxProductPrice);
            Controls.Add(lbl_type);
            Controls.Add(tBoxProductName);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(lbl_name);
            KeyPreview = true;
            Name = "CreateEditProducts";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Produtos";
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
        private TextBox tBoxProductPrice;
        private ComboBox cBoxProductType;
        private ComboBox cBoxProductUnit;
        private Label lbl_unity;
    }
}