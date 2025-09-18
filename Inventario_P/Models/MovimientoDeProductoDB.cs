using Microsoft.Data.SqlClient;
using Inventario_P.Models;
using System;
using System.Collections.Generic;
using Inventario_P.Context;

namespace Inventario_P.Models
{
    public class MovimientoDeProductoDB
    {

        // Context genérico con constructor vacío o por defecto
        Inventario_P.Context.Context con = new Inventario_P.Context.Context();


        public List<MovimientoDeProducto> ObtenerMovimientos()
        {
            List<MovimientoDeProducto> usersBaseDeDatos = new List<MovimientoDeProducto>();
            string query = "SELECT * FROM Movimiento_de_Productos";

            // Abrimos la conexión usando la clase Context
            using (SqlConnection connection = con.OpenConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ID_producto = reader.GetInt32(1);
                    int ID_Moviento = reader.GetInt32(0);
                    int ID_usuario = reader.GetInt32(2);
                    int Cantidad = reader.GetInt32(3);
                    DateTime FechaHora = reader.GetDateTime(4);
                    DateOnly Fecha = DateOnly.FromDateTime(FechaHora);
                    String Tipo = reader.GetString(5);

                    // Agregamos cada fila a la lista
                    usersBaseDeDatos.Add(new MovimientoDeProducto
                    {
                        IdMoviento = ID_Moviento,
                        IdProducto = ID_producto,
                        IdUsuario = ID_usuario,
                        Cantidad = Cantidad,
                        Fecha = Fecha,
                        Tipo = Tipo
                    });
                }
            }

            return usersBaseDeDatos;
        }
    }
}
