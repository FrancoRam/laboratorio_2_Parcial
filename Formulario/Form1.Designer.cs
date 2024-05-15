namespace Formulario
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
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            btnAtender = new Button();
            btnSalir = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 25;
            lstMedicos.Location = new Point(41, 46);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(562, 529);
            lstMedicos.TabIndex = 0;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 25;
            lstPacientes.Location = new Point(723, 46);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(562, 529);
            lstPacientes.TabIndex = 1;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(1358, 90);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(246, 82);
            btnAtender.TabIndex = 2;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1358, 780);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(246, 82);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(41, 610);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1244, 252);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 890);
            Controls.Add(richTextBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Name = "Form1";
            Text = "Atencion de pacientes";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Button btnAtender;
        private Button btnSalir;
        private RichTextBox richTextBox1;
    }
}