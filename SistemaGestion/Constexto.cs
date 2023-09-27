﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public static class Constexto
    {
        public static void crearProducto(Producto producto)
        {
            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario)" +
                "VALUES(@Descipcion,@Costo,@PrecioVenta, @Stock, @IdUsuario);";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

                        comando.ExecuteNonQuery();
                    }
                    connection.Close();
                };

            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public static void ModificarProducto(Producto producto)
        {
            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "UPDATE SET Descripciones = @Descripcion,Costo = @Costo,PrecioVenta = @PrecioVenta,  Stock = @Stock, IdUsuario = @IdUsuario)" +
                "WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });


                        comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

                        comando.ExecuteNonQuery();
                    }
                    connection.Close();
                };
            }
            catch (Exception ex)
            {

                throw;
            }
            

        }

        public static void EliminarProducto(Producto producto)
        {
            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "DELETE FROM Producto WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });

                        comando.ExecuteNonQuery();
                    }
                    connection.Close();
                };
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public static List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();
            List<Usuario> lista2 = new List<Usuario>();

            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario\r\n  FROM SistemaGestion.dbo.Producto";
            string queryUsuario = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM SistemaGestion.dbo.Usuario";

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
                                    var producto = new Producto();
                                    producto.Id = Convert.ToInt32(dr["Id"]);
                                    producto.Descripciones = dr["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                    producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(dr["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(dr["Id"]);

                                    lista.Add(producto);
                                }
                            }
                        }
                    }

                    using (SqlCommand comando = new SqlCommand(queryUsuario, connexion))  // Conecta BD
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {  // Ejetular consulta
                            if (dr.HasRows)           // hay Registros? 
                            {
                                while (dr.Read())     // Leelos
                                {                      // Mapea todos los registros
                                    var Usuario = new Usuario();
                                    //Usuario.Id = Convert.ToInt32(dr["Id"]);
                                    Usuario.Nombre = dr["Nombre"].ToString();
                                    Usuario.Apellido = dr["Apellido"].ToString();
                                    Usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                    Usuario.Contraseña = dr["Contraseña"].ToString();
                                    Usuario.Mail = dr["Mail"].ToString();

                                    lista2.Add(Usuario);
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

