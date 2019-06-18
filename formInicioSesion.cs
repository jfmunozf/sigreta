using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;




namespace SistemaGestion_ProgramasExtension
{
    public partial class formInicioSesion : Form
    {
        public formInicioSesion()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Cadena de conexión a la base de datos
            string connStr = "server=localhost;user=root;database=sigreta;port=3306;password=0te0n2011";

            /* Definición de un objeto para conectarnos a la BD.
               Se le pasa la cadena de conexión anterior como
               parámetro. */
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                //Se abre la conexión al servidor de BD
                conn.Open();

                /* Se define la consulta con un SELECT y se concatena a la consulta
                   el valor introducido en el TextBox txtNombreUsuario */
                string sql = "SELECT contrasena FROM usuarios WHERE email = '" + txtNombreUsuario.Text + "'";

                /* Se define un objeto Command de MySQL y se le pasa como
                   parámetro la conexión a la BD y la consulta 
                   hecha con SELECT */
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                /* En este objeto rdr queda almacenado el resultado
                   de la consulta hecha con SELECT */
                MySqlDataReader rdr = cmd.ExecuteReader();

                //Si la consulta devolvió alguna fila...
                if (rdr.HasRows)
                {
                    //Mientras existan filas que procesar...
                    while (rdr.Read())
                    {
                        /* Si la fila en la posición cero (contraseña)
                         * es igual a lo introducido en el TexBox
                         * txtContrasena...*/
                        if (rdr[0].Equals(txtContrasena.Text))
                        {
                            MessageBox.Show("Inicio de sesión exitoso");
                        } else
                        {
                            MessageBox.Show("Nombre de usuario y/o contraseña incorrectos");
                        }
                    }
                }
                //Se cierra el objeto rdr    
                rdr.Close();
            }
            //Se captura algún error en la conexión a la BD
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No se pudo realizar una conexión exitosa a la base de datos");
                        break;
                    case 1045:
                        MessageBox.Show("Información de autenticación incorrecta en la cadena de conexión");
                        break;
                }
            }
            //Se cierra la conexión a la BD
            conn.Close();            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
