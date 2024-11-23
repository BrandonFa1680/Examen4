namespace ExamenBD
{
    partial class Actualizar
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
            btnActualizar = new Button();
            txtStock = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(447, 291);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btn_Actualizar;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(341, 208);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(212, 23);
            txtStock.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 208);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 18;
            label3.Text = "Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(341, 143);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(212, 23);
            txtPrecio.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 146);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 16;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 86);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 14;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(341, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(212, 23);
            txtNombre.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Location = new Point(341, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(212, 23);
            txtId.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 28);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 23;
            label5.Text = "IdProducto";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(281, 291);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btn_Buscar;
            // 
            // Actualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(btnActualizar);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Actualizar";
            Text = "Actualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private TextBox txtStock;
        private Label label3;
        private TextBox txtPrecio;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label5;
        private Button btnBuscar;
    }
}