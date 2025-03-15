namespace _1Atividade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPlaca = new TextBox();
            btnValidar = new Button();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(296, 152);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(87, 23);
            txtPlaca.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(309, 181);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(60, 28);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(296, 152);
            maskedTextBox1.Mask = "aaa-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(87, 23);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(btnValidar);
            Controls.Add(txtPlaca);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlaca;
        private Button btnValidar;
        private MaskedTextBox maskedTextBox1;
    }
}
