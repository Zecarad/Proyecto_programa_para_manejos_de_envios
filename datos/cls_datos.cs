using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace datos
{
    public class cls_datos
    {
        public class conex_cls
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand ObjConex = new SqlCommand();
            SqlDataAdapter adaptador;
            DataTable tbl_usuarios;
            DataTable tbl_ORD;

            public DataTable GetUsuarios(int documento_cliente)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                    adaptador = new SqlDataAdapter("select * from CLIENTELA WHERE DOCUMENTO_CLIENTE= '" + documento_cliente + "'", conexion);
                    tbl_usuarios = new DataTable();
                    conexion.Open();
                    adaptador.Fill(tbl_usuarios);
                }

                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    conexion.Close();
                }
                return tbl_usuarios;
            }

            public void IngClientes(int documento_cliente, string nombre, string telefono, string correo, string codigopos)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                    SqlParameter p_documento = new SqlParameter("@DOCUMENTO_CLIENTE", SqlDbType.Int);
                    p_documento.Value = documento_cliente;

                    SqlParameter p_nombre = new SqlParameter("@NOMBRE_CLIENTE", SqlDbType.VarChar);
                    p_nombre.Value = nombre;

                    SqlParameter p_telefono = new SqlParameter("@TELEFONO_CLIENTE", SqlDbType.VarChar);
                    p_telefono.Value = telefono;

                    SqlParameter p_correo = new SqlParameter("@CORREO_CLIENTE", SqlDbType.VarChar);
                    p_correo.Value = correo;

                    SqlParameter p_codpos = new SqlParameter("@CODIGO_POSTAL_CLIENTE", SqlDbType.VarChar);
                    p_codpos.Value = codigopos;

                    ObjConex.Parameters.Add(p_documento);
                    ObjConex.Parameters.Add(p_nombre);
                    ObjConex.Parameters.Add(p_correo);
                    ObjConex.Parameters.Add(p_telefono);
                    ObjConex.Parameters.Add(p_codpos);


                    ObjConex.CommandType = CommandType.StoredProcedure;
                    ObjConex.CommandText = "SP_INGRESAR_CLIENTE";
                    conexion.Open();
                    ObjConex.Connection = conexion;

                    ObjConex.ExecuteNonQuery();
                    conexion.Close();
                    ObjConex.Parameters.Clear();


                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
                finally
                {

                }

            }

            public void EliminarClientes(int documento)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");

                    SqlParameter p_doc = new SqlParameter("@DOCUMENTO_CLIENTE", SqlDbType.Int);
                    p_doc.Value = documento;


                    ObjConex.Parameters.Add(p_doc);

                    ObjConex.CommandType = CommandType.StoredProcedure;
                    ObjConex.CommandText = "SP_ELIMINAR_CLIENTES";
                    conexion.Open();
                    ObjConex.Connection = conexion;
                    ObjConex.ExecuteNonQuery();
                    conexion.Close();
                    ObjConex.Parameters.Clear();


                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
                finally
                {

                }

            }
            public void ActualizaClientes(int documento_cliente, string nombre, string telefono, string correo, string codigopos)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                    
                    SqlParameter p_documento = new SqlParameter("@DOCUMENTO_CLIENTE", SqlDbType.Int);
                    p_documento.Value = documento_cliente;

                    SqlParameter p_nombre = new SqlParameter("@NOMBRE_CLIENTE", SqlDbType.VarChar);
                    p_nombre.Value = nombre;

                    SqlParameter p_telefono = new SqlParameter("@TELEFONO_CLIENTE", SqlDbType.VarChar);
                    p_telefono.Value = telefono;

                    SqlParameter p_correo = new SqlParameter("@CORREO_CLIENTE", SqlDbType.VarChar);
                    p_correo.Value = correo;

                    SqlParameter p_codpos = new SqlParameter("@CODIGO_POSTAL_CLIENTE", SqlDbType.VarChar);
                    p_codpos.Value = codigopos;

                    ObjConex.Parameters.Add(p_documento);
                    ObjConex.Parameters.Add(p_nombre);
                    ObjConex.Parameters.Add(p_correo);
                    ObjConex.Parameters.Add(p_telefono);
                    ObjConex.Parameters.Add(p_codpos);


                    ObjConex.CommandType = CommandType.StoredProcedure;
                    ObjConex.CommandText = "SP_ACTUALIZAR_CLIENTE";
                    conexion.Open();
                    ObjConex.Connection = conexion;
                    ObjConex.ExecuteNonQuery();
                    conexion.Close();
                    ObjConex.Parameters.Clear();

                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
                finally
                {

                }

            }

            public DataTable GetEmpresa(int documento_empresa)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                    adaptador = new SqlDataAdapter("select * from EMPRESA WHERE DOCUMENTO_EMPRESA= '" + documento_empresa + "'", conexion);
                    tbl_usuarios = new DataTable();
                    conexion.Open();
                    adaptador.Fill(tbl_usuarios);
                }

                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    conexion.Close();
                }
                return tbl_usuarios;
            }

            public void IngEmpresa(int documento_empresa, string nombre, string telefono, string correo, string codigopos)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                    SqlParameter p_documento = new SqlParameter("@DOCUMENTO_EMPRESA", SqlDbType.Int);
                    p_documento.Value = documento_empresa;

                    SqlParameter p_nombre = new SqlParameter("@NOMBRE_EMPRESA", SqlDbType.VarChar);
                    p_nombre.Value = nombre;

                    SqlParameter p_telefono = new SqlParameter("@TELEFONO_EMPRESA", SqlDbType.VarChar);
                    p_telefono.Value = telefono;

                    SqlParameter p_correo = new SqlParameter("@CORREO_EMPRESA", SqlDbType.VarChar);
                    p_correo.Value = correo;

                    SqlParameter p_codpos = new SqlParameter("@CODIGO_POSTAL_EMPRESA", SqlDbType.VarChar);
                    p_codpos.Value = codigopos;

                    ObjConex.Parameters.Add(p_documento);
                    ObjConex.Parameters.Add(p_nombre);
                    ObjConex.Parameters.Add(p_correo);
                    ObjConex.Parameters.Add(p_telefono);
                    ObjConex.Parameters.Add(p_codpos);


                    ObjConex.CommandType = CommandType.StoredProcedure;
                    ObjConex.CommandText = "SP_INGRESAR_EMPRESA";
                    conexion.Open();
                    ObjConex.Connection = conexion;

                    ObjConex.ExecuteNonQuery();
                    conexion.Close();
                    ObjConex.Parameters.Clear();


                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
                finally
                {

                }

            }

            public void EliminarEmpresa(int documento)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");

                    SqlParameter p_doc = new SqlParameter("@DOCUMENTO_EMPRESA", SqlDbType.Int);
                    p_doc.Value = documento;


                    ObjConex.Parameters.Add(p_doc); 

                    ObjConex.CommandType = CommandType.StoredProcedure;
                    ObjConex.CommandText = "SP_ELIMINAR_EMPRESA";
                    conexion.Open();
                    ObjConex.Connection = conexion;
                    ObjConex.ExecuteNonQuery();
                    conexion.Close();
                    ObjConex.Parameters.Clear();


                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
                finally
                {

                }

            }
            public void ActualizaEmpresa(int documento_empresa, string nombre, string telefono, string correo, string codigopos)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");

                    SqlParameter p_documento = new SqlParameter("@DOCUMENTO_EMPRESA", SqlDbType.Int);
                    p_documento.Value = documento_empresa;

                    SqlParameter p_nombre = new SqlParameter("@NOMBRE_EMPRESA", SqlDbType.VarChar);
                    p_nombre.Value = nombre;

                    SqlParameter p_telefono = new SqlParameter("@TELEFONO_EMPRESA", SqlDbType.VarChar);
                    p_telefono.Value = telefono;

                    SqlParameter p_correo = new SqlParameter("@CORREO_EMPRESA", SqlDbType.VarChar);
                    p_correo.Value = correo;

                    SqlParameter p_codpos = new SqlParameter("@CODIGO_POSTAL_EMPRESA", SqlDbType.VarChar);
                    p_codpos.Value = codigopos;

                    ObjConex.Parameters.Add(p_documento);
                    ObjConex.Parameters.Add(p_nombre);
                    ObjConex.Parameters.Add(p_correo);
                    ObjConex.Parameters.Add(p_telefono);
                    ObjConex.Parameters.Add(p_codpos);


                    ObjConex.CommandType = CommandType.StoredProcedure;
                    ObjConex.CommandText = "SP_ACTUALIZAR_EMPRESA";
                    conexion.Open();
                    ObjConex.Connection = conexion;
                    ObjConex.ExecuteNonQuery();
                    conexion.Close();
                    ObjConex.Parameters.Clear();

                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
                finally
                {

                }

            }
            public Tuple<int, string, string, string, string> ConsultaUsu(int ced)
            {


                int cedula = 0;
                string nombre = "null";
                string telefono = "null";
                string correo = "null";
                string codigopos = "null";
                conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                adaptador = new SqlDataAdapter("select * from CLIENTELA WHERE DOCUMENTO_CLIENTE= '" + ced + "'", conexion);

                SqlParameter id = new SqlParameter("@ID_CLIENTE", SqlDbType.Int);
                id.Value = ced;

                ObjConex.Parameters.Add(id);

                conexion.Open();

                ObjConex.CommandType = CommandType.StoredProcedure;
                ObjConex.CommandText = "SP_SELECCIONAR_CLIENTE";

                ObjConex.Connection = conexion;
                SqlDataReader revisar = ObjConex.ExecuteReader();

                if (revisar.Read())
                {
                    cedula = int.Parse(revisar["DOCUMENTO_CLIENTE"].ToString());
                    nombre = revisar["NOMBRE_CLIENTE"].ToString();
                    telefono = revisar["TELEFONO_CLIENTE"].ToString();
                    correo = revisar["CORREO_CLIENTE"].ToString();
                    codigopos = revisar["CODIGO_POSTAL_CLIENTE"].ToString();
                }
                conexion.Close();
                ObjConex.Parameters.Clear();
                return Tuple.Create(cedula, nombre, telefono, correo, codigopos);


            }

            public Tuple<int, string> ConsultaEmpresa(int document)
            {

                int doc= 0;
                string nombre = "null";

                conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                adaptador = new SqlDataAdapter("select * from EMPRESA WHERE DOCUMENTO_EMPRESA= '" + document + "'", conexion);

                SqlParameter id = new SqlParameter("@DOCUMETO_EMPRESA", SqlDbType.Int);
                id.Value = document;

                ObjConex.Parameters.Add(id);

                conexion.Open();

                ObjConex.CommandType = CommandType.StoredProcedure;
                ObjConex.CommandText = "SP_SELEC_EMPRESA  ";

                ObjConex.Connection = conexion;
                SqlDataReader revi = ObjConex.ExecuteReader();

                if (revi.Read())
                {
                    doc = int.Parse(revi["DOCUMENTO_EMPRESA"].ToString());
                    nombre = revi["NOMBRE_EMPRESA"].ToString();

                }
                conexion.Close();
                ObjConex.Parameters.Clear();
                return Tuple.Create(doc, nombre);


            }

            public void IngOrden(int documento_cliente, string nombre_cliente, int documento_empresa, string nombre_empresa, string direccion, double monto)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");

                    SqlParameter p_documento_c = new SqlParameter("@DOCUMENTO_CLIENTE", SqlDbType.Int);
                    p_documento_c.Value = documento_cliente;

                    SqlParameter p_nombre_c = new SqlParameter("@NOMBRE_CLIENTE", SqlDbType.VarChar);
                    p_nombre_c.Value = nombre_cliente;

                    SqlParameter p_documento_e = new SqlParameter("@DOCUMENTO_EMPRESA", SqlDbType.Int);
                    p_documento_e.Value = documento_empresa;

                    SqlParameter p_nombre_e = new SqlParameter("@NOMBRE_EMPRESA", SqlDbType.VarChar);
                    p_nombre_e.Value = nombre_empresa;

                    SqlParameter p_direccion = new SqlParameter("@DIRECCION", SqlDbType.VarChar);
                    p_direccion.Value = direccion;

                    SqlParameter p_monto = new SqlParameter("@MONTO_TOTAL", SqlDbType.Money);
                    p_monto.Value = monto;


                    ObjConex.Parameters.Add(p_documento_c);
                    ObjConex.Parameters.Add(p_nombre_c);
                    ObjConex.Parameters.Add(p_documento_e);
                    ObjConex.Parameters.Add(p_nombre_e);
                    ObjConex.Parameters.Add(p_direccion);
                    ObjConex.Parameters.Add(p_monto);


                    ObjConex.CommandType = CommandType.StoredProcedure;
                    ObjConex.CommandText = "SP_INGRESAR_ORDENES";
                    conexion.Open();
                    ObjConex.Connection = conexion;

                    ObjConex.ExecuteNonQuery();
                    conexion.Close();
                    ObjConex.Parameters.Clear();


                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
                finally
                {

                }
            }
            public DataTable GetOrden()
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                    adaptador = new SqlDataAdapter("select * from ORDENES", conexion);
                    tbl_ORD = new DataTable();
                    conexion.Open();
                    adaptador.Fill(tbl_ORD);
                }

                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    conexion.Close();
                }
                return tbl_ORD;
            }

            public DataTable getordenes(int documento_cliente)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                    adaptador = new SqlDataAdapter("select * from ORDENES WHERE DOCUMENTO_CLIENTE= '" + documento_cliente + "'", conexion);
                    tbl_usuarios = new DataTable();
                    conexion.Open();
                    adaptador.Fill(tbl_usuarios);
                }

                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    conexion.Close();
                }
                return tbl_usuarios;
            }
            public void ActuaOrden(int documento_cliente, string nombre_cliente, int documento_empresa, string nombre_empresa, string direccion, double monto)
            {
                try
                {
                    SqlParameter p_documento_c = new SqlParameter("@DOCUMENTO_CLIENTE", SqlDbType.Int);
                    p_documento_c.Value = documento_cliente;

                    SqlParameter p_nombre_c = new SqlParameter("@NOMBRE_CLIENTE", SqlDbType.VarChar);
                    p_nombre_c.Value = nombre_cliente;

                    SqlParameter p_documento_e = new SqlParameter("@DOCUMENTO_EMPRESA", SqlDbType.Int);
                    p_documento_e.Value = documento_empresa;

                    SqlParameter p_nombre_e = new SqlParameter("@NOMBRE_EMPRESA", SqlDbType.VarChar);
                    p_nombre_e.Value = nombre_empresa;

                    SqlParameter p_direccion = new SqlParameter("@DIRECCION", SqlDbType.VarChar);
                    p_direccion.Value = direccion;

                    SqlParameter p_monto = new SqlParameter("@MONTO_TOTAL", SqlDbType.Money);
                    p_monto.Value = monto;


                    ObjConex.Parameters.Add(p_documento_c);
                    ObjConex.Parameters.Add(p_nombre_c);
                    ObjConex.Parameters.Add(p_documento_e);
                    ObjConex.Parameters.Add(p_nombre_e);
                    ObjConex.Parameters.Add(p_direccion);
                    ObjConex.Parameters.Add(p_monto);


                    ObjConex.CommandType = CommandType.StoredProcedure;
                    ObjConex.CommandText = "SP_ACTUALIZAR_ORDENES";
                    conexion.Open();
                    ObjConex.Connection = conexion;
                    ObjConex.ExecuteNonQuery();
                    conexion.Close();
                    ObjConex.Parameters.Clear();

                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
                finally
                {

                }


            }
            public DataTable ConsOrden(int documento_orden)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                    adaptador = new SqlDataAdapter("select * from ORDENES WHERE NUM_ORDEN= '" + documento_orden + "'", conexion);
                    tbl_usuarios = new DataTable();
                    conexion.Open();
                    adaptador.Fill(tbl_usuarios);
                }

                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    conexion.Close();
                }
                return tbl_usuarios;
            }
            public void EliminarOrden(int orden)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");

                    SqlParameter p_doc = new SqlParameter("@Num_Orden", SqlDbType.Int);
                    p_doc.Value = orden;


                    ObjConex.Parameters.Add(p_doc);

                    ObjConex.CommandType = CommandType.StoredProcedure;
                    ObjConex.CommandText = "SP_ELIMINAR_ORDENES";
                    conexion.Open();
                    ObjConex.Connection = conexion;
                    ObjConex.ExecuteNonQuery();
                    conexion.Close();
                    ObjConex.Parameters.Clear();


                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
                finally
                {

                }

            }
            public void IngUsuario(string usuario, string contraseña)
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                   
                    SqlParameter p_usuario = new SqlParameter("@USUARIO", SqlDbType.VarChar);
                    p_usuario.Value = usuario;

                    SqlParameter p_contraseña = new SqlParameter("@CONTRASEÑA", SqlDbType.VarChar);
                    p_contraseña.Value = contraseña;



                    ObjConex.Parameters.Add(p_usuario);
                    ObjConex.Parameters.Add(p_contraseña);

                    ObjConex.CommandType = CommandType.StoredProcedure;
                    ObjConex.CommandText = "SP_INGRESAR_USUARIO";
                    conexion.Open();
                    ObjConex.Connection = conexion;

                    ObjConex.ExecuteNonQuery();
                    conexion.Close();
                    ObjConex.Parameters.Clear();


                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
                finally
                {

                }

            }
            public DataTable GetEmpresa()
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                    adaptador = new SqlDataAdapter("select * from Empresa", conexion);
                    tbl_ORD = new DataTable();
                    conexion.Open();
                    adaptador.Fill(tbl_ORD);
                }

                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    conexion.Close();
                }
                return tbl_ORD;
            }
            public DataTable GetCliente()
            {
                try
                {
                    conexion.ConnectionString = ("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
                    adaptador = new SqlDataAdapter("select * from Clientela", conexion);
                    tbl_ORD = new DataTable();
                    conexion.Open();
                    adaptador.Fill(tbl_ORD);
                }

                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    conexion.Close();
                }
                return tbl_ORD;
            }

        }
    }
}

