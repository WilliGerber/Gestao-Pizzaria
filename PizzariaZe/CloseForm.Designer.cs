namespace PizzariaZe
{
    partial class CloseForm
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
            lblMsgCloseForm = new Label();
            btnYesCloseForm = new Button();
            btnNoCloseForm = new Button();
            btnMinCloseForm = new Button();
            SuspendLayout();
            // 
            // lblMsgCloseForm
            // 
            lblMsgCloseForm.AutoSize = true;
            lblMsgCloseForm.Location = new Point(17, 10);
            lblMsgCloseForm.Name = "lblMsgCloseForm";
            lblMsgCloseForm.Size = new Size(237, 15);
            lblMsgCloseForm.TabIndex = 0;
            lblMsgCloseForm.Text = "Você deseja realmente encerrar a aplicação?";
            // 
            // btnYesCloseForm
            // 
            btnYesCloseForm.DialogResult = DialogResult.Yes;
            btnYesCloseForm.Location = new Point(12, 45);
            btnYesCloseForm.Name = "btnYesCloseForm";
            btnYesCloseForm.Size = new Size(71, 27);
            btnYesCloseForm.TabIndex = 1;
            btnYesCloseForm.Text = "Sim";
            btnYesCloseForm.UseVisualStyleBackColor = true;
            btnYesCloseForm.Click += btnYesCloseForm_Click;
            // 
            // btnNoCloseForm
            // 
            btnNoCloseForm.DialogResult = DialogResult.No;
            btnNoCloseForm.Location = new Point(99, 45);
            btnNoCloseForm.Name = "btnNoCloseForm";
            btnNoCloseForm.Size = new Size(71, 27);
            btnNoCloseForm.TabIndex = 2;
            btnNoCloseForm.Text = "Não";
            btnNoCloseForm.UseVisualStyleBackColor = true;
            // 
            // btnMinCloseForm
            // 
            btnMinCloseForm.AutoEllipsis = true;
            btnMinCloseForm.DialogResult = DialogResult.OK;
            btnMinCloseForm.Location = new Point(188, 45);
            btnMinCloseForm.Name = "btnMinCloseForm";
            btnMinCloseForm.Size = new Size(71, 27);
            btnMinCloseForm.TabIndex = 3;
            btnMinCloseForm.Text = "Minimizar";
            btnMinCloseForm.UseVisualStyleBackColor = true;
            // 
            // CloseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 86);
            Controls.Add(btnMinCloseForm);
            Controls.Add(btnNoCloseForm);
            Controls.Add(btnYesCloseForm);
            Controls.Add(lblMsgCloseForm);
            Name = "CloseForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirmar Saída";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsgCloseForm;
        private Button btnYesCloseForm;
        private Button btnNoCloseForm;
        private Button btnMinCloseForm;
    }
}