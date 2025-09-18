using Microsoft.Data.SqlClient;
using Inventario_P.Models;
using System;
using System.Collections.Generic;
using Inventario_P.Context;

namespace Inventario_P.Models
{
    public class BitacoraBD
    {
        // Context genérico con constructor vacío o por defecto
        Inventario_P.Context.Context con = new Inventario_P.Context.Context();


        public List<Bitacora> ObtenerMovimientos()
        {
            List<Bitacora> usersBaseDeDatos = new List<Bitacora>();
            string query = "SELECT * FROM Movimiento_de_Productos";

            // Abrimos la conexión usando la clase Context
            using (SqlConnection connection = con.OpenConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ID_login = reader.GetInt32(0);
                    int ID_usuario = reader.GetInt32(1);
                    DateTime Fecha = reader.GetDateTime(2);
                    string Accion = reader.GetString(3);

                    // Agregamos cada fila a la lista
                    usersBaseDeDatos.Add(new Bitacora
                    {
                        IdLogin = ID_login,
                        IdUsuario = ID_usuario,
                        Fecha = Fecha,
                        Accion = Accion
                    });
                }
            }

            return usersBaseDeDatos;
        }
    }
}
