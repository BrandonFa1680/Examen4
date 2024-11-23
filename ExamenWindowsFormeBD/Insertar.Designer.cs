namespace ExamenWindowsFormeBD
{
    partial class Insertar
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
            txtNombre = new TextBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            txtStock = new TextBox();
            label3 = new Label();
            btnInsertar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(212, 23);
            txtNombre.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(139, 102);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(212, 23);
            txtPrecio.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 105);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Precio";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(139, 167);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(212, 23);
            txtStock.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 167);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Stock";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(170, 255);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btn_Insertar;
            // 
            // Insertar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 355);
            Controls.Add(btnInsertar);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Insertar";
            Text = "Insertar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private TextBox txtPrecio;
        private Label label2;
        private TextBox txtStock;
        private Label label3;
        private Button btnInsertar;
    }
}