namespace ExamenWindowsFormeBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Buscar(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void btn_Insertar(object sender, EventArgs e)
        {
            Insertar insertar = new Insertar();
            insertar.Show();
        }

        private void btn_Eliminar(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.Show();
        }

        private void btn_Actualizar(object sender, EventArgs e)
        {
            Actualizar actualizar = new Actualizar();
            actualizar.Show();
        }
    }
}
