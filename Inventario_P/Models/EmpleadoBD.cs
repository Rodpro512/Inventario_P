using Microsoft.Data.SqlClient;

namespace Inventario_P.Models
{
    public class EmpleadoBD
    {
        // Context genérico con constructor vacío o por defecto
        Inventario_P.Context.Context con = new Inventario_P.Context.Context();


        public List<Empleado> ObtenerMovimientos()
        {
            List<Empleado> usersBaseDeDatos = new List<Empleado>();
            string query = "SELECT * FROM Empleados";

            // Abrimos la conexión usando la clase Context
            using (SqlConnection connection = con.OpenConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ID_Empleado = reader.GetInt32(0);
                    string Nombre = reader.GetString(1);
                    string Apellido = reader.GetString(2);
                    int Teléfono = reader.GetInt32(3);
                    string cargo = reader.GetString(4);
                    int carnet = reader.GetInt32(5);
                    string Dirreccion = reader.GetString(6);
                    int ID_usuario = reader.GetInt32(7);

                    // Agregamos cada fila a la lista
                    usersBaseDeDatos.Add(new Empleado
                    {
                        IdEmpleado = ID_Empleado,
                        Nombre = Nombre,
                        Apellido = Apellido,
                        Teléfono = Teléfono,
                        Cargo = cargo,
                        Carnet = carnet,
                        Dirreccion= Dirreccion,
                        IdUsuario= ID_usuario
                    });
                }
            }

            return usersBaseDeDatos;
        }
    }
}
