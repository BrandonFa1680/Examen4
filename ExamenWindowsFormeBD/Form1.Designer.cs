namespace ExamenWindowsFormeBD
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuscar = new Button();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(58, 70);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 57);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btn_Buscar;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(223, 70);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(109, 57);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btn_Insertar;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(394, 70);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(109, 57);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btn_Actualizar;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(223, 176);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 57);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btn_Eliminar;
            // 
            // Form1
            // 
            ClientSize = new Size(572, 346);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(btnBuscar);
            Name = "Form1";
            ResumeLayout(false);
        }

        private Button btnBuscar;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}