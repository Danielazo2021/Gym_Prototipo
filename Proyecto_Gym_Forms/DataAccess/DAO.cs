using Microsoft.Data.SqlClient;
using Proyecto_Gym_Forms.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gym_Forms.DataAccess
{
    public class DAO :IDAO
    {
     
        SqlConnection cnn = new SqlConnection(Properties.Resources.conexionBD);
              

        public bool agregarAlumno(Alumno alumno)
        {
            bool confirmacion = false;
            try
            {
                SqlCommand cmdMaestro = new SqlCommand();
                cnn.Open();
                cmdMaestro.Connection = cnn;
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.CommandText = "PA_Ingresar_Alumno";
                cmdMaestro.Parameters.AddWithValue("@dni", alumno.dni);
                cmdMaestro.Parameters.AddWithValue("@nombre", alumno.nombre);
                cmdMaestro.Parameters.AddWithValue("@apellido", alumno.apellido);
                cmdMaestro.Parameters.AddWithValue("@edad", alumno.edad);
                cmdMaestro.Parameters.AddWithValue("@sexo", alumno.sexo);
                cmdMaestro.Parameters.AddWithValue("@observaciones", alumno.observaciones);
                cmdMaestro.Parameters.AddWithValue("@fechaDeAlta", alumno.fechaAlta);

                cmdMaestro.ExecuteNonQuery();
                confirmacion = true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return confirmacion;


        }

        public bool actualizarAlumno(Alumno alumno)
        {
            bool confirmacion = false;
            try
            {
                SqlCommand cmdMaestro = new SqlCommand();
                cnn.Open();
                cmdMaestro.Connection = cnn;
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.CommandText = "PA_Actualizar_Alumno";
                cmdMaestro.Parameters.AddWithValue("@dni", alumno.dni);
                cmdMaestro.Parameters.AddWithValue("@nombre", alumno.nombre);
                cmdMaestro.Parameters.AddWithValue("@apellido", alumno.apellido);
                cmdMaestro.Parameters.AddWithValue("@edad", alumno.edad);
                cmdMaestro.Parameters.AddWithValue("@sexo", alumno.sexo);
                cmdMaestro.Parameters.AddWithValue("@observaciones", alumno.observaciones);

                cmdMaestro.ExecuteNonQuery();
                confirmacion = true;

            }
            catch (Exception e)
            {                
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return confirmacion;
        }
              

       

        public Alumno consultaAlumno(int dni)
        {
           Alumno resultado=new Alumno();
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_buscar_por_dni", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable tabla = new DataTable();

                cmd.Parameters.AddWithValue("@dni", dni);  
                tabla.Load(cmd.ExecuteReader());
               
                if(tabla.Rows.Count > 0)
                {
                    DataRow row = tabla.Rows[0];
                    resultado.dni = Convert.ToInt32(row["dni"]);
                    resultado.nombre = row["nombre"].ToString();
                    resultado.apellido = row["apellido"].ToString();
                    resultado.edad = Convert.ToInt32(row["edad"]);
                    resultado.sexo = row["sexo"].ToString();
                    resultado.observaciones = row["observaciones"].ToString();                

                }
                cnn.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return resultado;
        }

        public DataTable consultaAlumno(string nombre)
        {
            DataTable tabla = new DataTable();
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_buscar_por_nombre_Solo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", nombre);
                tabla.Load(cmd.ExecuteReader());
                cnn.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return tabla;
        }
        public DataTable consultaAlumno(string nombre, string apellido)
        {
            DataTable tabla = new DataTable();
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_buscar_por_apellido_y_nombre", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                tabla.Load(cmd.ExecuteReader());
                cnn.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return tabla;
        }
        public DataTable consultarAlumno(int dni)
        {
            DataTable tabla = new DataTable();
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_buscar_por_dni", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);             
                tabla.Load(cmd.ExecuteReader());
                cnn.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return tabla;
        }

        public bool cobrarCuota(DatosCuotas datosCuotas)
        {
            bool confirmacion = false;
            try
            {
                SqlCommand cmdMaestro = new SqlCommand();
                cnn.Open();
                cmdMaestro.Connection = cnn;
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.CommandText = "PA_Cobrar_Cuota";
                cmdMaestro.Parameters.AddWithValue("@dni", datosCuotas.alumno.dni);
                cmdMaestro.Parameters.AddWithValue("@fechaDeInicio", datosCuotas.fechaInicio);
                cmdMaestro.Parameters.AddWithValue("@fechaVencimiento", datosCuotas.fechaVencimiento);
                cmdMaestro.Parameters.AddWithValue("@valorDeCuota", datosCuotas.valorCuota);
                cmdMaestro.Parameters.AddWithValue("@responsableDelCobro", datosCuotas.responsableDeCobro);
                cmdMaestro.Parameters.AddWithValue("@observaciones", datosCuotas.observaciones);
                cmdMaestro.Parameters.AddWithValue("@formaDePago", datosCuotas.formaDePago);
                cmdMaestro.Parameters.AddWithValue("@fechaDelPago", datosCuotas.fechaDelPago);

                cmdMaestro.ExecuteNonQuery();
                confirmacion = true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return confirmacion;
        }
        public DataTable consultarCuotas(DateTime fecha)
        {
            DataTable tabla = new DataTable();
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_Cuotas_Cobradas_Por_Fecha", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha", fecha);
                
                tabla.Load(cmd.ExecuteReader());

                cnn.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return tabla;
        }

      

        public DataTable buscarProximosVencimientos(DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_Vencimiento_Por_Fecha", cnn);
                cmd.CommandType = CommandType.StoredProcedure;                

                cmd.Parameters.AddWithValue("@desde", desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);
                tabla.Load(cmd.ExecuteReader());
               
                cnn.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return tabla;

        }

        public bool validarLogin(Login login)
        {
            bool status = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("PA_Validar_Login", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable tabla = new DataTable();

                cmd.Parameters.AddWithValue("@usuario", login.Usuario);
                cmd.Parameters.AddWithValue("@password", login.Password);
                tabla.Load(cmd.ExecuteReader());

                if (tabla.Rows.Count > 0)
                {
                    status = true;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return status;
        }

    }
}
