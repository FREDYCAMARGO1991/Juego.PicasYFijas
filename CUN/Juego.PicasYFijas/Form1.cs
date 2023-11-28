using System.Drawing;
using System.Linq;

namespace Juego.PicasYFijas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Numero aleatorio de 4 dígitos
            Random Random = new Random();
            txtValorSistema.Text = Random.Next(1000, 9999).ToString();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Proceso(txtValorSistema.Text, txtValorUsuario.Text);
        }

        public void Proceso(string ValorSistema, string ValorUsuario)
        {
            //Validaciones esto debe estar en una funcion separada
            lblResultado.Text = "";
            if (string.IsNullOrEmpty(ValorSistema))
            {
                lblResultado.Text = "Debe generar un número en el campo de sistema";
                return;
            }

            if (ValorSistema.Length != 4)
            {
                lblResultado.Text = "Debe generar un número de 4 dígitos en el campo de sistema";
                return;
            }

            if (string.IsNullOrEmpty(ValorUsuario))
            {
                lblResultado.Text = "Debe agregar un número en el campo de jugador";
                return;
            }

            if (ValorUsuario.Length != 4)
            {
                lblResultado.Text = "Debe agregar un número de 4 dígitos en el campo de jugador";
                return;
            }

            // ValorSistemaDividido
            List<int> ValorSistemaDividido = new List<int>();

            ValorSistemaDividido.Add(Convert.ToInt32(txtValorSistema.Text.Substring(0, 1)));
            ValorSistemaDividido.Add(Convert.ToInt32(txtValorSistema.Text.Substring(1, 1)));
            ValorSistemaDividido.Add(Convert.ToInt32(txtValorSistema.Text.Substring(2, 1)));
            ValorSistemaDividido.Add(Convert.ToInt32(txtValorSistema.Text.Substring(3, 1)));

            // ValorUsuarioDividido
            List<int> ValorUsuarioDividido = new List<int>();

            ValorUsuarioDividido.Add(Convert.ToInt32(txtValorUsuario.Text.Substring(0, 1)));
            ValorUsuarioDividido.Add(Convert.ToInt32(txtValorUsuario.Text.Substring(1, 1)));
            ValorUsuarioDividido.Add(Convert.ToInt32(txtValorUsuario.Text.Substring(2, 1)));
            ValorUsuarioDividido.Add(Convert.ToInt32(txtValorUsuario.Text.Substring(3, 1)));

            //Nota este proceso se puede simplificar en una funcion que acepte un texto y retorne un lista de numeros

            //Cantidad de asiertos y posiciones variables
            int CantidadPicas = 0;

            //Cantidad de asiertos y posiciones fijaS
            int CantidadFijas = 0;

            //Calculo de picas y fijas usando c# tambien se puede usar regex
            for (int i = 0; i < ValorSistemaDividido.Count(); i++)
            {
                if (ValorSistemaDividido[i] == ValorUsuarioDividido[i])
                {
                    CantidadFijas = CantidadFijas + 1;
                    continue;
                }

                if (ValorSistemaDividido.Contains(ValorUsuarioDividido[i]))
                {
                    CantidadPicas = CantidadPicas + 1;
                    continue;
                }
            }
            //Este calculo de picas y fijas debe estar en una funcion separada

            //Resultado
            string resultado = string.Format("Cantidad de Picas = {0}\nCantidad de Fijas = {1}", CantidadPicas, CantidadFijas);

            //Gana quien tenga las 4 fijas
            //Nota: Este proceso debe ser dinamico segun la cantidad dinamica de numeros generados
            //para que pueda el juego ser parametrizable y funcione con mas numeros
            if (CantidadFijas == ValorSistema.Length)
            {
                resultado = resultado + "\nGanaste!!!";
            }
            else
            {
                resultado = resultado + "\nSigue intentando";
            }

            lblResultado.Text = resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsVisible = txtValorSistema.Visible;
            if (IsVisible) 
                txtValorSistema.Visible = false;
            else
                txtValorSistema.Visible = true;
        }
    }
}
