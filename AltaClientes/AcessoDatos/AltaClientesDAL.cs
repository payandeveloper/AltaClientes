﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;




namespace AltaClientes.AcessoDatos
{
    class AltaClientesDAL
    {
        #region Elementos

        /// <summary>
        /// Objeto de la instancia Odbc, para la conexión a SQL Server.
        /// </summary>
        private AccesoSqlServer accesoSqlServer;

        #endregion Elementos
        #region Constructor

        /// <summary>
        /// Constructor para instanciar el objeto odbc con la cadena de conexión a SQL Server. 
        /// </summary>
        public AltaClientesDAL()
        {
            accesoSqlServer = new AccesoSqlServer(Program.CadenaConexionSqlServer);
        }

        #endregion Constructor

        /// <summary>
        /// Método para consultar los usuarios.
        /// </summary>
        /// <returns>Regresa un DataTable con la lista de usuarios.</returns>
        public DataTable ConsultarUsuarios()
        {
            String query = String.Empty;
            DataTable dtUsuarios;

            try
            {
                dtUsuarios = new DataTable();
                query = "EXEC prueba.dbo.proc_BuscarDatosCliente @codigo = 0";

                if (accesoSqlServer.Open())
                {
                    dtUsuarios = accesoSqlServer.ExecuteDataTable(query);
                }


            }
            catch (Exception ex)
            {
                dtUsuarios = null;
                MessageBox.Show("Error al consultar usuarios",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                //Error.Guardar(accesoSqlServer.SqlConexion,
                //              "MAPER001",
                //              "AsignarUsuarioDAL",
                //              "ConsultarUsuarios",
                //              "proc_MaPer001CargaCatalogos",
                //              "0",
                //              ex.Message);
            }
            finally
            {
                accesoSqlServer.Close();
            }

            return dtUsuarios;
        }

        /// <summary>
        /// Método para agregar un usuario a la Base de Datos.
        /// </summary>
        /// <param name="u">Entidad usuario con los datos a guardar</param>
        /// <returns>Regresa true si guardó el registro, false si ocurrió un error.</returns>
        public Boolean GuardarCliente(int num, string nombre, int telefono, string fechanac,string domicilio, int numeroint )
        {
            Boolean resultado = false;
            string query = String.Empty;

            try
            {
                if (accesoSqlServer.Open())
                {
                    query = String.Format($"EXEC prueba.dbo.proc_GuardarClientes @numCliente = {num} ," +
                                        $" @nomCliente = '{nombre}', @telefono = '{telefono}',@fechaNac = '{fechanac}', @domicilio = '{domicilio}', @interior ='{numeroint}'");
                    
                    resultado = Convert.ToBoolean(accesoSqlServer.ExecuteQuery(query));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error al guardar usuario",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                //Error.Guardar(accesoSqlServer.SqlConexion,
                //              "MAPER001",
                //              "AsignarUsuarioDAL",
                //              "GuardarUsuario",
                //              "proc_MaPer001GuardarUsuarios",
                //              "0",
                //              ex.Message);
            }
            finally
            {
                accesoSqlServer.Close();
            }

            return resultado;

        }
        public Boolean ActualizarCliente(int codigo, string nombre, int telefono, string fechanac, string domicilio, int numeroint)
        {
            Boolean resultado = false;
            string query = String.Empty;

            try
            {
                if (accesoSqlServer.Open())
                {
                    query = String.Format($"EXEC prueba.dbo.proc_ActualizarClientes @codigo = {codigo} ," +
                                        $" @nombrecliente = '{nombre}', @telefono = '{telefono}',@fechanacimiento = '{fechanac}', @domicilio = '{domicilio}', @numinterior ='{numeroint}'");
                    
                    resultado = Convert.ToBoolean(accesoSqlServer.ExecuteQuery(query));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                //Error.Guardar(accesoSqlServer.SqlConexion,
                //              "MAPER001",
                //              "AsignarUsuarioDAL",
                //              "GuardarUsuario",
                //              "proc_MaPer001GuardarUsuarios",
                //              "0",
                //              ex.Message);
            }
            finally
            {
                accesoSqlServer.Close();
            }

            return resultado;

        }
        public Boolean DeshabilitaCliente(int codigo)
        {
            Boolean resultado = false;
            string query = String.Empty;

            try
            {
                if (accesoSqlServer.Open())
                {
                    query = String.Format($"EXEC prueba.dbo.proc_DeshabilitarClientes @codigo = {codigo}");

                    resultado = Convert.ToBoolean(accesoSqlServer.ExecuteQuery(query));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar usuario",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                //Error.Guardar(accesoSqlServer.SqlConexion,
                //              "MAPER001",
                //              "AsignarUsuarioDAL",
                //              "GuardarUsuario",
                //              "proc_MaPer001GuardarUsuarios",
                //              "0",
                //              ex.Message);
            }
            finally
            {
                accesoSqlServer.Close();
            }

            return resultado;

        }




    }
}
