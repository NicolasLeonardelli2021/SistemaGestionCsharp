using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SistemaGestion
{
    public class ConstextoUsuario
    {
        public static List<Usuario> ListarUsuarios()
        {


            List<Usuario> lista = new List<Usuario>();

            string connectionString = @"Server=ESCRITORIO; DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM SistemaGestion.dbo.Usuario";

            try
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, connexion))  // Conecta BD
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {  // Ejetular consulta
                            if (dr.HasRows)           // hay Registros? 
                            {
                                while (dr.Read())     // Leelos
                                {                      // Mapea todos los registros
                                    var usuario = new Usuario();
                                    usuario.Id = Convert.ToInt32(dr["Id"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["Apellido"].ToString();
                                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario.Contraseña = dr["contraseña"].ToString();
                                    usuario.Mail = dr["Mail"].ToString();

                                    lista.Add(usuario);
                                }
                            }
                        }
                    }

                    // Opcional
                    connexion.Close();
                }

                return lista;
            }
            catch (Exception ex)

            {
                return null;
            }

        }
    }
}
                   



