using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class conexion
    {
        SqlConnection connection;
        SqlCommand comando;
        SqlDataReader lector;

        private static string conectar;
        static conexion()
        {
            conexion.conectar = @"Data source = . ; initial catalog = DonPaulo ; integrated security = true ";
        }
        public conexion()
        {
            this.connection = new SqlConnection(conexion.conectar);
        }

        public bool probarConexion()
        {
            bool validacion = true;
            try
            {
                this.connection.Open();

            }
            catch (Exception)
            {
                validacion = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
            return validacion;
        }

        public bool EliminarProveedor(int idProveedor)
        {
            bool rta = true;

            try
            {
                string sql = $"DELETE FROM Proveedores WHERE id = {idProveedor}";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false; // No se eliminó ningún producto
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }

        public bool EliminarPago(int idPago)
        {
            bool rta = true;

            try
            {
                string sql = $"DELETE FROM Proveedores_Pagos WHERE idpago = {idPago}";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false; // No se eliminó ningún producto
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }


        public bool ModificarProveedor(Proveedor p)
        {
            bool rta = true;

            try
            {
                string sql = $"UPDATE Proveedores SET nombre_Proveedor='{p.Nombre}'" +
                             $"WHERE id={p.Id}";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }

        public bool ModificarPago(Pago p)
        {
            bool rta = true;

            try
            {
                string sql = $"UPDATE Proveedores_Pagos SET proveedor='{p.proveedor}', montopago={p.importe}, fecha='{p.fecha}' " +
               $"WHERE idpago={p.id}";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }

        public bool GuardarProveedor(Proveedor p)
        {
            bool rta = true;

            try
            {
                string sql = $"INSERT INTO Proveedores (nombre_Proveedor) VALUES(";
                sql = sql + $"'{p.Nombre}')";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }


        public bool GuardarProductos(Producto p)
        {
            bool rta = true;

            try
            {
                string sql = $"INSERT INTO PRODUCTOS1 (nombre, categoria, proveedorid, costo, porcentajemayorista, cantidad, codigoBarra) VALUES(";
                sql = sql + $"'{p.Nombre}', '{p.Categoria}', '{p.ProveedorId}', {p.Costo}, {p.PorcentajeMayorista}, {p.Cantidad}, '{p.CodigoBarras}')";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }

        public bool GuardarPago(Pago p)
        {
            bool rta = true;

            try
            {
                string sql = $"INSERT INTO Proveedores_Pagos (proveedor, fecha, montopago) VALUES(";
                sql = sql + $"'{p.proveedor}', '{p.fecha}', {p.importe})";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }

        public bool ModificarProductos(Producto p, string sql)
        {
            bool rta = true;

            try
            {

                if (sql == "porcentaje")
                {
                    sql = $"UPDATE PRODUCTOS1 SET porcentajemayorista={p.PorcentajeMayorista}" +
                           $"WHERE id={p.Id}";
                }
                else
                {
                    if (sql == "proveedor")
                    {
                        sql = $"UPDATE PRODUCTOS1 SET proveedorid='{p.ProveedorId}'" +
                               $"WHERE id={p.Id}";
                    }
                    else
                    {
                        sql = $"UPDATE PRODUCTOS1 SET nombre='{p.Nombre}', categoria='{p.Categoria}', proveedorid='{p.ProveedorId}', " +
                               $"costo={p.Costo}, porcentajemayorista={p.PorcentajeMayorista}, codigoBarra='{p.CodigoBarras}'" +
                               $"WHERE id={p.Id}";
                    }
                }




                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {

                    this.connection.Close();
                }
            }

            return rta;
        }

        public bool ModificarCantidad(Producto p, string desbl, string modulo)
        {
            string sql = "";
            bool rta = true;
            string mensaje = null;  
            Producto original = new Producto();
            this.devolverProducto(original, p.Id);
            if (desbl == "1")
            {
                try
                {
                    sql = $"UPDATE PRODUCTOS1 SET cantidad={p.Cantidad} " +
                                $"WHERE id={p.Id}";

                 
                    mensaje = "'se modifico el stock de " + original.Nombre + "de " + original.Cantidad + " A " + p.Cantidad + " desde " + modulo+"'";

                    InsertarLog("Convert(varchar,getdate())", mensaje, "'ModificarCantidad'");
                    this.comando = new SqlCommand();
                    this.comando.CommandType = CommandType.Text;
                    this.comando.CommandText = sql;
                    this.comando.Connection = this.connection;

                    this.connection.Open();

                    int filasAfectadas = this.comando.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        rta = false;
                    }
                }
                catch (Exception)
                {
                    rta = false;
                }
                finally
                {
                    if (this.connection.State == ConnectionState.Open)
                    {
                        this.connection.Close();
                    }
                }
            }
            return rta;
        }

        public bool InsertarLog (string fecha, string mensaje, string modulo)
        {
            string sql = "";
            bool rta = true;   
                try
                {
                    sql = $"insert into log (fecha,mensaje, modulo) values ({fecha},{mensaje},{modulo})";
                    this.comando = new SqlCommand();
                    this.comando.CommandType = CommandType.Text;
                    this.comando.CommandText = sql;
                    this.comando.Connection = this.connection;

                    this.connection.Open();

                    int filasAfectadas = this.comando.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        rta = false;
                    }
                }
                catch (Exception e)
                {
                    rta = false;
                }
                finally
                {
                    if (this.connection.State == ConnectionState.Open)
                    {
                        this.connection.Close();
                    }
                }
            return rta;
        }


        public bool EliminarProducto(int idProducto)
        {
            bool rta = true;

            try
            {
                string sql = $"DELETE FROM PRODUCTOS1 WHERE id IN ({idProducto})";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false; // No se eliminó ningún producto
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }
        public DataTable RellenarDataGrid(string Tabla, string condicion)
        {
            string sql = $"SELECT * FROM {Tabla} ";

            if (condicion != "")
            {
                sql += condicion;
            }

            this.comando = new SqlCommand();

            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = sql;
            this.comando.Connection = this.connection;

            this.connection.Open();

            SqlDataAdapter datos = new SqlDataAdapter(this.comando); // Pasar el comando como argumento al constructor del SqlDataAdapter
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            int filasAfectadas = this.comando.ExecuteNonQuery();

            this.connection.Close();

            return tabla;
        }

        public void VerProveedores(List<Proveedor> proveedores)
        {
            try
            {
                // Realiza la conexión a la base de datos y crea el comando SQL
                using (SqlConnection connection = new SqlConnection(@"Data source = . ; initial catalog = DonPaulo ; integrated security = true "))
                {
                    connection.Open();

                    // Crea el comando SQL para seleccionar todos los proveedores
                    string sql = "SELECT id, nombre_Proveedor FROM Proveedores";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Ejecuta el comando y lee los datos del proveedor
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Lee el ID y el nombre del proveedor y crea un objeto Proveedor
                                int idProveedor = reader.GetInt32(0);
                                string nombreProveedor = reader.GetString(1);
                                Proveedor proveedor = new Proveedor()
                                {
                                    Id = idProveedor,
                                    Nombre = nombreProveedor
                                };
                                proveedores.Add(proveedor);
                            }
                        }
                    }


                }
            }
            catch (Exception)
            {
                // Manejo de errores, si corresponde
            }
            finally
            {

                this.connection.Close();

            }
        }
        public bool devolverProducto(Producto producto, int idProducto)
        {
            string sqlQuery = "SELECT * FROM PRODUCTOS1 WHERE id = @IdProducto";

            using (SqlConnection connection = new SqlConnection(@"Data source = . ; initial catalog = DonPaulo ; integrated security = true "))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdProducto", idProducto);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            producto.Id = Convert.ToInt32(reader["id"]);
                            producto.Nombre = reader["nombre"].ToString();
                            producto.Categoria = reader["categoria"].ToString();
                            producto.ProveedorId = Convert.ToInt32(reader["proveedorid"]);
                            producto.Costo = Convert.ToSingle(reader["costo"]);
                            producto.PorcentajeMayorista = Convert.ToInt32(reader["porcentajemayorista"]);
                            producto.Cantidad = Convert.ToInt32(reader["cantidad"]);
                            producto.CodigoBarras = reader["codigoBarra"].ToString();
                        }
                        else
                        {
                            // No se encontró el producto con el ID especificado
                            return false;
                        }

                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        // Ocurrió un error durante la obtención del producto
                        return false;
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }

            return true;
        }

        public string ObtenerNombreProveedor(int idProveedor)
        {
            string nombreProveedor = "";

            // Consulta SQL para obtener el nombre del proveedor
            string sql = $"SELECT nombre_Proveedor FROM Proveedores WHERE id = {idProveedor}";

            // Establecer la conexión a la base de datos y crear un objeto SqlCommand
            using (SqlConnection connection = new SqlConnection(@"Data source = . ; initial catalog = DonPaulo ; integrated security = true "))
            {
                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar la consulta y obtener el resultado
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        nombreProveedor = result.ToString();
                    }
                }
                catch (Exception)
                {
                    // Manejar cualquier excepción
                }
            }

            return nombreProveedor;
        }
        public bool VerificarCodigoDeBarrasDisponible(string Cb)
        {
            string connectionString = @"Data source = . ; initial catalog = DonPaulo ; integrated security = true "; // Reemplaza con la cadena de conexión correcta
            string sql = $"SELECT COUNT(*) FROM PRODUCTOS1 WHERE codigoBarra = @codigoBarra";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@codigoBarra", Cb);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    // Si count es igual a 0, el nombre está disponible, de lo contrario, no lo está.
                    return count == 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        //---------------------------------------------------- FUNCIONES ADMIN -------------------------------------------------------------------------------------------------
        //funciones para generar cantidades y codigos de barra random de prueba
        private void ActualizarValores(int id, int cantidad, long codigoBarra)
        {
            string sqlQuery = "UPDATE PRODUCTOS1 SET cantidad = @Cantidad, codigoBarra = @CodigoBarra WHERE id = @IdProducto AND (cantidad IS NULL OR codigoBarra IS NULL)";

            using (SqlConnection connection = new SqlConnection(@"Data source=.; initial catalog=DonPaulo; integrated security=true"))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@CodigoBarra", codigoBarra);
                    command.Parameters.AddWithValue("@IdProducto", id);

                    try
                    {
                        connection.Open();
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            Console.WriteLine($"No se encontró el producto con el ID {id} o ya tiene valores en los campos cantidad y codigoBarra");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error al actualizar valores: " + e.Message);
                    }
                }
            }
        }
        public void AsignarValoresAleatorios()
        {
            string sqlQuery = "SELECT id, cantidad, codigoBarra FROM PRODUCTOS1";

            using (SqlConnection connection = new SqlConnection(@"Data source=.; initial catalog=DonPaulo; integrated security=true"))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Random random = new Random();

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            int cantidad = Convert.IsDBNull(reader["cantidad"]) ? random.Next(1, 301) : Convert.ToInt32(reader["cantidad"]);
                            long codigoBarra = Convert.IsDBNull(reader["codigoBarra"]) ? random.Next(100000000, 1000000000) : Convert.ToInt64(reader["codigoBarra"]);

                            ActualizarValores(id, cantidad, codigoBarra);
                        }

                        reader.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error al asignar valores aleatorios: " + e.Message);
                    }
                }
            }
        }
        //funcion para cambiar categorias
        public void ModificarCategoriasProductos()
        {
            string sqlQuery = "SELECT * FROM PRODUCTOS1";

            using (SqlConnection connection = new SqlConnection(@"Data source = . ; initial catalog = DonPaulo ; integrated security = true "))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        List<Producto> productos = new List<Producto>();

                        while (reader.Read())
                        {
                            Producto producto = new Producto();
                            producto.Id = Convert.ToInt32(reader["id"]);
                            producto.Nombre = reader["nombre"].ToString();
                            producto.Categoria = reader["categoria"].ToString();
                            producto.ProveedorId = Convert.ToInt32(reader["proveedorid"]);
                            producto.Costo = Convert.ToSingle(reader["costo"]);
                            producto.PorcentajeMayorista = Convert.ToInt32(reader["porcentajemayorista"]);
                            producto.Cantidad = Convert.ToInt32(reader["cantidad"]);
                            producto.CodigoBarras = reader["codigoBarra"].ToString();

                            productos.Add(producto);
                        }

                        reader.Close();

                        // Dividir la lista de productos en dos mitades
                        int mitad = productos.Count / 2;

                        // Asignar la categoría "Litros" a la primera mitad de productos
                        for (int i = 0; i < mitad; i++)
                        {
                            productos[i].Categoria = "Litros";
                        }

                        // Asignar la categoría "Unidades" a la segunda mitad de productos
                        for (int i = mitad; i < productos.Count; i++)
                        {
                            productos[i].Categoria = "Unidades";
                        }

                        // Actualizar las categorías en la base de datos
                        foreach (Producto producto in productos)
                        {
                            string updateQuery = $"UPDATE PRODUCTOS1 SET categoria = '{producto.Categoria}' WHERE id = {producto.Id}";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        // Manejar cualquier excepción
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------

        public List<Producto> ObtenerDatosProductos()
        {
            string connectionString = @"Data Source=.;Initial Catalog=DonPaulo;Integrated Security=True";
            string query = "SELECT * FROM PRODUCTOS1";

            List<Producto> productos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.Id = Convert.ToInt32(reader["id"]);
                        producto.Nombre = reader["nombre"].ToString();
                        producto.Categoria = reader["categoria"].ToString();
                        producto.ProveedorId = Convert.ToInt32(reader["proveedorid"]);
                        producto.Costo = Convert.ToSingle(reader["costo"]);
                        producto.PorcentajeMayorista = Convert.ToInt32(reader["porcentajemayorista"]);
                        producto.Cantidad = Convert.ToInt32(reader["cantidad"]);
                        producto.CodigoBarras = reader["codigoBarra"].ToString();

                        productos.Add(producto);
                    }

                    reader.Close();
                }
            }

            return productos;
        }
        public int ObtenerProductoPorCodigoDeBarras(Producto producto, string CodigoBarras)
        {
            int validacion = 0;

            try
            {
                string sql = $"SELECT * FROM PRODUCTOS1 WHERE codigoBarra = '{CodigoBarras}'";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                SqlDataReader reader = this.comando.ExecuteReader();

                if (reader.Read())
                {
                    producto.Id = Convert.ToInt32(reader["id"]);
                    producto.Nombre = reader["nombre"].ToString();
                    producto.Categoria = reader["categoria"].ToString();
                    producto.ProveedorId = Convert.ToInt32(reader["proveedorid"]);
                    producto.Costo = Convert.ToSingle(reader["costo"]);
                    producto.PorcentajeMayorista = Convert.ToInt32(reader["porcentajemayorista"]);
                    producto.CodigoBarras = reader["codigoBarra"].ToString();
                    validacion = 1;
                }

                reader.Close();
            }
            catch (Exception)
            {

                // Manejar la excepción según sea necesario
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return validacion;
        }
        public void InsertarVentaCabecera(string fecha, string hora, float totalVenta, string metodoPago)
        {
            string connectionString = @"Data Source=.;Initial Catalog=DonPaulo;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO [dbo].[VentaCabecera1] ([fecha], [hora], [totalVenta], [metodoPago]) VALUES (@fecha, @hora, @totalVenta, @metodoPago)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@hora", hora);
                    command.Parameters.AddWithValue("@totalVenta", totalVenta);
                    command.Parameters.AddWithValue("@metodoPago", metodoPago);

                    command.ExecuteNonQuery();
                }
            }
        }
        public int ObtenerUltimaVenta()
        {
            int ultimaVenta = 0;

            // Cadena de conexión a la base de datos
            string connectionString = @"Data Source=.;Initial Catalog=DonPaulo;Integrated Security=True";

            // Consulta SQL para obtener el último ID de venta
            string query = "SELECT MAX(idBoleta) FROM VentaCabecera1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ejecutar la consulta y obtener el resultado
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        ultimaVenta = Convert.ToInt32(result);
                    }
                }
            }

            return ultimaVenta;
        }
        public void InsertarVentaDetalle(VentaDetalle ventaDetalle)
        {
            // Cadena de conexión a la base de datos
            string connectionString = @"Data Source=.;Initial Catalog=DonPaulo;Integrated Security=True";

            // Consulta SQL para insertar un nuevo registro en VentasDetalles
            string query = "INSERT INTO VentasDetalles (fecha, idProducto, nombreProducto, cantidad, costo, totalCosto, precio, totalVenta, ganancia, idCabecera) " +
                           "VALUES (@Fecha, @IdProducto, @NombreProducto, @Cantidad, @Costo, @TotalCosto, @Precio, @TotalVenta, @Ganancia, @IdCabecera)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar los parámetros a la consulta SQL
                    command.Parameters.AddWithValue("@Fecha", ventaDetalle.Fecha);
                    command.Parameters.AddWithValue("@IdProducto", ventaDetalle.IdProducto);
                    command.Parameters.AddWithValue("@NombreProducto", ventaDetalle.NombreProducto);
                    command.Parameters.AddWithValue("@Cantidad", ventaDetalle.Cantidad);
                    command.Parameters.AddWithValue("@Costo", ventaDetalle.Costo);
                    command.Parameters.AddWithValue("@TotalCosto", ventaDetalle.TotalCosto);
                    command.Parameters.AddWithValue("@Precio", ventaDetalle.Precio);
                    command.Parameters.AddWithValue("@TotalVenta", ventaDetalle.TotalVenta);
                    command.Parameters.AddWithValue("@Ganancia", ventaDetalle.Ganancia);
                    command.Parameters.AddWithValue("@IdCabecera", ventaDetalle.IdCabecera);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }
            }
        }




        public List<VentaCabecera> CabeceraMetodoPago(string metodoPago)
        {
            List<VentaCabecera> metodopago = new List<VentaCabecera>();
            string connectionString = @"Data source = . ; initial catalog = DonPaulo ; integrated security = true ";

            string query = @"SELECT * FROM [DonPaulo].[dbo].[VentaCabecera1]
                            WHERE metodoPago = @metodoPago";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@metodoPago", metodoPago);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        try
                        {
                            VentaCabecera v1 = new VentaCabecera();
                            v1.Fecha = reader["fecha"].ToString();
                            v1.Hora = reader["hora"].ToString();
                            v1.TotalVenta = Convert.ToSingle(reader["totalVenta"]);
                            v1.MetodoDePago = reader["metodoPago"].ToString();
                            v1.IdBoleta1 = Convert.ToInt32(reader["idBoleta"]);
                            metodopago.Add(v1);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }
                return metodopago;
            }
        }

        public void ObtenerProductosPorIdDetalle(int idDetalle, List<VentaDetalle> VentasDetalle)
        {

            // Cadena de conexión a la base de datos
            string connectionString = @"Data source = . ; initial catalog = DonPaulo ; integrated security = true ";

            // Consulta SQL para obtener los productos por el idDetalle
            string query = @"SELECT idProducto, nombreProducto, cantidad, costo, totalCosto, precio, totalVenta, ganancia, idCabecera
                    FROM VentasDetalles
                    WHERE idDetalle = @IdDetalle";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdDetalle", idDetalle);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VentaDetalle vd = new VentaDetalle();
                            /*  v1.TotalVenta = Convert.ToSingle(reader["totalVenta"]);
                            v1.Hora = reader["metodoPago"].ToString();
                            v1.IdBoleta1 = Convert.ToInt32(reader["idBoleta"]);*/
                            vd.Fecha = reader["fecha"].ToString();
                            vd.IdProducto = Convert.ToInt32(reader["idProducto"]);
                            vd.NombreProducto = reader["nombreProducto"].ToString();
                            vd.Cantidad = Convert.ToInt32(reader["cantidad"]);




                        }
                    }
                }
            }
        }

        public bool Guardargasto(Cgastos G)
        {
            bool rta = true;

            try
            {
                string sql = $"INSERT INTO Gastos (fecha, detalle, monto) VALUES(";
                sql = sql + $"'{G.Fecha}', '{G.Detalle}', {G.Monto})";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }

        public bool ModificarGasto(Cgastos p)
        {
            bool rta = true;

            try
            {
                string sql = $"UPDATE Gastos SET fecha='{p.Fecha}', detalle='{p.Detalle}', monto='{p.Monto}'" +
                             $"WHERE idgasto={p.Id}";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }


        public void EliminarGastoo(int idProducto)
        {
            bool rta = true;

            try
            {
                string sql = $"DELETE FROM Gastos WHERE idgasto IN ({idProducto})";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    // No se eliminó ningún producto
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }


        }

        public string devolverDetalle(string detalle, int idGasto)
        {
            string sqlQuery = "SELECT detalle FROM Gastos WHERE idgasto = @idGasto";

            using (SqlConnection connection = new SqlConnection(@"Data source = . ; initial catalog = DonPaulo ; integrated security = true "))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@idgasto", idGasto);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            detalle = reader["detalle"].ToString();

                        }
                        else
                        {
                            // No se encontró el producto con el ID especificado

                        }

                        reader.Close();
                    }
                    catch (Exception)
                    {
                        // Ocurrió un error durante la obtención del producto

                    }
                    finally
                    {

                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                    return detalle;
                }
            }


        }
        public List<InformeDiario> ObtenerInformeDiario()
        {
            List<InformeDiario> informes = new List<InformeDiario>();
            string connectionString = @"Data source = . ; initial catalog = DonPaulo ; integrated security = true "; // Reemplaza con tu cadena de conexión SQL

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT
                fecha,
                SUM(totalVenta) AS total_ventas,
                SUM(monto_gasto) AS total_gastos,
                SUM(monto_pago) AS total_pagos_proveedores
            FROM
                (
                SELECT fecha, totalVenta, 0 AS monto_gasto, 0 AS monto_pago
                FROM VentasDetalles
                UNION ALL
                SELECT fecha, 0 AS totalVenta, monto AS monto_gasto, 0 AS monto_pago
                FROM gastos
                UNION ALL
                SELECT fecha AS fecha, 0 AS totalVenta, 0 AS monto_gasto, montopago
                FROM Proveedores_Pagos
                ) AS combined_data
            GROUP BY fecha
            ORDER BY fecha;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InformeDiario informe = new InformeDiario
                            {
                                Fecha = reader["fecha"].ToString(),
                                TotalVentas = Convert.ToSingle(reader["total_ventas"]),
                                TotalGastos = Convert.ToSingle(reader["total_gastos"]),
                                TotalPagoProveedores = Convert.ToSingle(reader["total_pagos_proveedores"])
                            };

                            informes.Add(informe);
                        }
                    }
                }
            }

            return informes;
        }
        public bool EliminarVenta(int idventa)
        {
            bool rta = true;
            string mensaje;

            try
            {
                string sql = $"delete from VentasDetalles where idCabecera={idventa} delete from VentaCabecera1 where idBoleta={idventa}";
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    rta = false; // No se eliminó ningún producto
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }

        public bool CreadorLog()
        {
            bool rta = true;

            try
            {
                string sql = "Select * from Log";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false; // No se eliminó ningún producto
                }
            }
            catch (Exception)
            {
                try
                {
                    string sql = "CREATE TABLE [dbo].[Log]([fecha] [datetime] NOT NULL,[mensaje] [varchar](max) NOT NULL,[modulo] [varchar](100) NOT NULL) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]";

                    this.comando = new SqlCommand();
                    this.comando.CommandType = CommandType.Text;
                    this.comando.CommandText = sql;
                    this.comando.Connection = this.connection;

                    int filasAfectadas = this.comando.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        rta = false; // No se eliminó ningún producto
                    }

                }
                catch (Exception e)
                {

                   
                }
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return rta;
        }
    }
}


