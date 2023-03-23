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
            add_employee = new Button();
            SuspendLayout();
            // 
            // add_employee
            // 
            add_employee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            add_employee.Image = (Image)resources.GetObject("add_employee.Image");
            add_employee.Location = new Point(25, 23);
            add_employee.Name = "add_employee";
            add_employee.Size = new Size(151, 76);
            add_employee.TabIndex = 2;
            add_employee.Text = "Adicionar Funcionário";
            add_employee.TextImageRelation = TextImageRelation.ImageAboveText;
            add_employee.UseVisualStyleBackColor = true;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add_employee);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employees";
            Text = "Funcionários";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button add_employee;
    }
}