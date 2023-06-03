using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using datos;
using static datos.cls_datos;

namespace negocios
{
    public class cls_negocios
    {
        conex_cls ObjCls = new conex_cls();
        int documento_cliente;
        string nombre_cliente;
        string telefono_cliente;
        string correo_cliente;
        string codigo_postal_cliente;

        int documento_empresa;
        string nombre_empresa;
        string telefono_empresa;
        string correo_empresa;
        string codigo_postal_empresa;

        string direccion;
        double monto;
        int numero_orden;

        string usuario;
        string contraseña;

        public int Documento_cliente
        {
            get => documento_cliente;
            set => documento_cliente = value;
        }
        public string Nombre_cliente
        {
            get => nombre_cliente;
            set => nombre_cliente = value;
        }
        public string Telefono_cliente
        {
            get => telefono_cliente;
            set => telefono_cliente = value;
        }
        public string Correo_cliente
        {
            get => correo_cliente;
            set => correo_cliente = value;
        }
        public string Codigo_postal_cliente
        {
            get => codigo_postal_cliente;
            set => codigo_postal_cliente = value;
        }
        public int Documento_empresa
        {
            get => documento_empresa;
            set => documento_empresa = value;
        }
        public string Nombre_empresa
        {
            get => nombre_empresa;
            set => nombre_empresa = value;
        }
        public string Telefono_empresa
        {
            get => telefono_empresa;
            set => telefono_empresa = value;
        }
        public string Correo_empresa
        {
            get => correo_empresa;
            set => correo_empresa = value;
        }
        public string Codigo_postal_empresa
        {
            get => codigo_postal_empresa;
            set => codigo_postal_empresa = value;
        }
        public string Direccion
        {
            get => direccion;
            set => direccion = value;
        }
        public double Monto
        {
            get => monto;
            set => monto = value;
        }
        public int Numero_orden
        {
            get => numero_orden;
            set => numero_orden = value;
        }
        public string Usuario {
            get => usuario;
            set => usuario = value;
        }
        public string Contraseña {
            get => contraseña;
            set => contraseña = value;
        }

        public bool IngresaUsu()
        {
            bool ingresa = true;

            if (ingresa == true)
            {
                ObjCls.IngUsuario(Usuario, Contraseña);

            }
            return false;

        }

        public DataTable Getusu()
        {
            return ObjCls.GetUsuarios(documento_cliente);
        }

        public bool ingresar_usuario()
        {
            bool ingresa = true;

            if (ingresa == true)
            {
                ObjCls.IngClientes(Documento_cliente, nombre_cliente, telefono_cliente, Correo_cliente, Codigo_postal_cliente);

            }
            return false;

        }

        public bool EliminarCliente()
        {
            bool ini = true;

            if (ini == true)
            {
                ObjCls.EliminarClientes(documento_cliente);
            }
            return true;

        }

        public bool ActualizaCliente()
        {

            bool ini = true;

            if (ini == true)
            {
                ObjCls.ActualizaClientes(Documento_cliente, nombre_cliente, Telefono_cliente, Correo_cliente, Codigo_postal_cliente);

            }
            return false;
        }


        public DataTable GetEmp()
        {
            return ObjCls.GetEmpresa(documento_empresa);
        }

        public DataTable GetCli()
        {
            return ObjCls.GetCliente();
        }

        public bool ingresar_empresa()
        {
            bool ingresa = true;

            if (ingresa == true)
            {
                ObjCls.IngEmpresa(Documento_empresa, nombre_empresa, telefono_empresa, Correo_empresa, Codigo_postal_empresa);

            }
            return false;

        }

        public bool EliminarEmpresa()
        {
            bool ini = true;

            if (ini == true)
            {
                ObjCls.EliminarEmpresa(documento_empresa);
            }
            return true;

        }

        public bool ActualizaEmpresa()
        {

            bool ini = true;

            if (ini == true)
            {
                ObjCls.ActualizaEmpresa(Documento_empresa, nombre_empresa, Telefono_empresa, Correo_empresa, Codigo_postal_empresa);

            }
            return false;
        }

        public Tuple<int, string, string, string, string> GetUsu(int ced)
        {

            return ObjCls.ConsultaUsu(ced);

        }

        public Tuple<int, string> GetEmpresa(int doc)
        {

            return ObjCls.ConsultaEmpresa(doc);

        }

        public bool ingresar_ordenes()
        {
            bool ingresa = true;

            if (ingresa == true)
            {
                ObjCls.IngOrden(documento_cliente, nombre_cliente, documento_empresa, nombre_empresa, Direccion, Monto);

            }
            return false;

        }

        public DataTable GetOrd()
        {
            return ObjCls.GetOrden();
        }

        public DataTable GetEmpre()
        {
            return ObjCls.GetEmpresa();
        }

        public DataTable Getorders()
        {
            return ObjCls.getordenes(documento_cliente);
        }

        public bool ActOrden()
        {

            bool ini = true;

            if (ini == true)
            {
                ObjCls.ActuaOrden(documento_cliente, nombre_cliente, documento_empresa, nombre_empresa, Direccion, Monto);

            }
            return false;
        }

        public DataTable NumeroOrden()
        {
            return ObjCls.ConsOrden(Numero_orden);
        }

        public bool EliminarOrden()
        {
            bool ini = true;

            if (ini == true)
            {
                ObjCls.EliminarOrden(numero_orden);
            }
            return true;

        }
    }
}
