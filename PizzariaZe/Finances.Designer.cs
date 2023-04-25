namespace PizzariaZe
{
    partial class Finances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finances));
            btn_revenues = new Button();
            btn_payments = new Button();
            SuspendLayout();
            // 
            // btn_revenues
            // 
            btn_revenues.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_revenues.Image = (Image)resources.GetObject("btn_revenues.Image");
            btn_revenues.Location = new Point(26, 23);
            btn_revenues.Name = "btn_revenues";
            btn_revenues.Size = new Size(151, 76);
            btn_revenues.TabIndex = 1;
            btn_revenues.Text = "Receitas";
            btn_revenues.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_revenues.UseVisualStyleBackColor = true;
            btn_revenues.Click += add_pizza_sizes_Click;
            // 
            // btn_payments
            // 
            btn_payments.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_payments.Image = (Image)resources.GetObject("btn_payments.Image");
            btn_payments.Location = new Point(183, 23);
            btn_payments.Name = "btn_payments";
            btn_payments.Size = new Size(151, 76);
            btn_payments.TabIndex = 2;
            btn_payments.Text = "Pagamentos";
            btn_payments.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_payments.UseVisualStyleBackColor = true;
            // 
            // Finances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_payments);
            Controls.Add(btn_revenues);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Finances";
            Text = "Financeiro";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_revenues;
        private Button btn_payments;
    }
}