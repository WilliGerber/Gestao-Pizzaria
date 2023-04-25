namespace PizzariaZe
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            btn_add_employee = new Button();
            SuspendLayout();
            // 
            // btn_add_employee
            // 
            btn_add_employee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_employee.Image = (Image)resources.GetObject("btn_add_employee.Image");
            btn_add_employee.Location = new Point(25, 23);
            btn_add_employee.Name = "btn_add_employee";
            btn_add_employee.Size = new Size(151, 76);
            btn_add_employee.TabIndex = 1;
            btn_add_employee.Text = "Adicionar Funcionário";
            btn_add_employee.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add_employee.UseVisualStyleBackColor = true;
            btn_add_employee.Click += add_employee_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add_employee);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Employees";
            Text = "Funcionários";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add_employee;
    }
}