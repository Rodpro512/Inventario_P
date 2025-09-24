using Microsoft.Data.SqlClient;
using System.Linq;

namespace Inventario_P.Models
{
    public class ProductoDB
    {

        // Context genérico con constructor vacío o por defecto
        Inventario_P.Context.Context con = new Inventario_P.Context.Context();


        public List<Producto> ObtenerProductos()
        {
            List<Producto> usersBaseDeDatos = new List<Producto>();
            string query = "SELECT * FROM Producto";

            // Abrimos la conexión usando la clase Context
            using (SqlConnection connection = con.OpenConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ID_Producto = reader.GetInt32(0);
                    string Nombre = reader.GetString(1);
                    int Codigo = reader.GetInt32(2);
                    int ID_marca = reader.GetInt32(3);
                    int ID_categoria = reader.GetInt32(4);
                    int Cantidad = reader.GetInt32(5);
                    string Descripcion = reader.GetString(6);
                    DateTime FechaHora = reader.GetDateTime(7);
                    DateOnly Fecha = DateOnly.FromDateTime(FechaHora);
                    String Foto = reader.GetString(8);

                    // Agregamos cada fila a la lista
                    usersBaseDeDatos.Add(new Producto
                    {
                        IdProducto = ID_Producto,
                        Nombre = Nombre,
                        Codigo = Codigo,
                        IdMarca = ID_marca,
                        IdCategoria = ID_categoria,
                        Cantidad = Cantidad,
                        Descripcion = Descripcion,
                        Fecha = Fecha
                    });
                }
            }

            return usersBaseDeDatos;
        }
    }
}
