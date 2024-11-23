namespace ExamenWindowsFormeBD
{
    partial class Buscar
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
            label1 = new Label();
            btnBuscar = new Button();
            txtIdProducto = new TextBox();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 71);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "IdProducto";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(403, 62);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(72, 33);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btn_Buscar;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(129, 68);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(212, 23);
            txtIdProducto.TabIndex = 3;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(44, 137);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(554, 245);
            dgvProductos.TabIndex = 4;
            // 
            // Buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 429);
            Controls.Add(dgvProductos);
            Controls.Add(txtIdProducto);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Name = "Buscar";
            Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBuscar;
        private TextBox txtIdProducto;
        private DataGridView dgvProductos;
    }
}