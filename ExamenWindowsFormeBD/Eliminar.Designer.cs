namespace ExamenWindowsFormeBD
{
    partial class Eliminar
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
            txtIdProducto = new TextBox();
            btnEliminar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(115, 59);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(212, 23);
            txtIdProducto.TabIndex = 6;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(389, 53);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(72, 33);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btn_Eliminar;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 62);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "IdProducto";
            // 
            // Eliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 207);
            Controls.Add(txtIdProducto);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Name = "Eliminar";
            Text = "Eliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProducto;
        private Button btnEliminar;
        private Label label1;
    }
}