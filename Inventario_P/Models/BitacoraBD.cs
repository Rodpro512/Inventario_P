using Microsoft.Data.SqlClient;
using Inventario_P.Models;
using System;
using System.Collections.Generic;
using Inventario_P.Context;
using System.Linq;

namespace Inventario_P.Models
{
    public class BitacoraBD
    {
        // Context genérico con constructor vacío o por defecto
        Inventario_P.Context.Context con = new Inventario_P.Context.Context();

        public List<Bitacora> ObtenerBitacoras()
        {
            List<Bitacora> usersBaseDeDatos = new List<Bitacora>();
            string query = "SELECT ID_login, ID_usuario, Fecha, Accion FROM Bitacora";

            // Abrimos la conexión usando la clase Context
            using (SqlConnection connection = con.OpenConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ID_login = reader.GetInt32(0);
                    int ID_usuario = reader.GetInt32(1);
                    DateTime FechaHora = reader.GetDateTime(2);
                    string Accion = reader.GetString(3);

                    // Agregamos cada fila a la lista
                    usersBaseDeDatos.Add(new Bitacora
                    {
                        IdLogin = ID_login,
                        IdUsuario = ID_usuario,
                        Fecha = FechaHora, 
                        Accion = Accion
                    });
                }
            }

            return usersBaseDeDatos;
        }
    }
}
