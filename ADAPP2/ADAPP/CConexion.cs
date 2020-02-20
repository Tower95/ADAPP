using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;

using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ADAPP
{
    //hi this is a try on hid gud.
    class CConexion
    //192.168.0.11
    {
        string CadenaConexion = "server = 192.168.0.11; port  = 3306; userid = user; password =12345; database = proyecto1;";
        MySqlConnection conexionDB;
        MySqlCommand cmd;
        MySqlDataReader reader;
        protected static CConexion instance;
        public static CConexion Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CConexion();
                }
                return instance;
            }
        }

        /// <summary>
        /// Este metodo abre la conexion con la DB.
        /// </summary>
        /// 
        public void Open()
        {
            conexionDB = new MySqlConnection(CadenaConexion);
            conexionDB.Open();
        }
        /// <summary>
        /// Este metodo cierra la conexion con la DB.
        /// </summary>
        public void close()
        {
            conexionDB.Close();
        }
        

   
        /// <summary>
        /// Este meto concede el acceso a el programa
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool Ingreso(string Usuario, string Password)
        {
            Open();
           
            cmd = new MySqlCommand("sp_login", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", Usuario);
            cmd.Parameters.AddWithValue("@contra", Password);
           
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["pass"].ToString() == Password)
                {
                    close();
                    return true;
                }
            }
            close();
            return false;
        }
        /// <summary>
        /// Este metodo Actulisa el ciclo escolar
        /// </summary>
        /// <param name="Año"></param>
        /// <returns></returns>
        public void ActualizarCiclo( )
        {
            Open();
            string Ano = DateTime.Now.Year.ToString();
            cmd = new MySqlCommand("########", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ano", Ano);
            cmd.ExecuteNonQuery();
            close();
            
        }
        /// <summary>
        /// Este metodo Captura un nueveo Alumno en la base de datos.
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Apellidos"></param>
        /// <param name="Grupo"></param>
        public void IngesarAlumno(string Nombre,string Id_alumno, string Apellidos, int Grupo)
        {
            Open();

            cmd = new MySqlCommand("sp_agregar_alumno", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Alumno", Id_alumno);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Apellidos", Apellidos);
            cmd.Parameters.AddWithValue("@Id_Grupo", Grupo);

            cmd.ExecuteNonQuery();
            close();
        }
        /// <summary>
        /// Este metodo Crea un Grupo
        /// </summary>
        /// <param name="Nombre_grupo"></param>
        /// <param name="Id_Ciclo"></param>
        public void CrearGrupo(string Nombre_grupo, string Id_Ciclo)
        {
            Open();

            cmd = new MySqlCommand("sp_crear_grupo", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre_Grupo", Nombre_grupo);
            cmd.Parameters.AddWithValue("@Id_Ciclo", Id_Ciclo);
            
            cmd.ExecuteNonQuery();
            close();
        }
        /// <summary>
        /// Este metodo Recupera todos los ciclos de la base de datos
        /// </summary>
        /// <param name="Ciclos"></param>
        /// <returns></returns>
        public bool TraerCiclos(List<CCiclo> Ciclos)
        {
            Open();

            cmd = new MySqlCommand("sp_ciclos", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Ciclos.Add(new CCiclo(
                    Convert.ToInt16(reader["Id_Ciclo"]),
                                    reader["Id_Periodo"].ToString(),
                                    reader["Ano"].ToString()
                    ));

            }
            close();
            return false;

        }/// <summary>
        /// Este metodo Agrega Grupos a un usuario
        /// </summary>
        /// <param name="NombreGrupo"></param>
        /// <param name="Id_ciclo"></param>
        public void AgregarGrupo(string NombreGrupo, int Id_ciclo )
        {
            Open();

            cmd = new MySqlCommand("sp_grupo_agregar", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre_Grupo", NombreGrupo);
            cmd.Parameters.AddWithValue("@Id_Ciclo", Id_ciclo);

            cmd.ExecuteNonQuery();
            close();
        }
        /// <summary>
        /// Este metodo busca las materias de un usuario.
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="materias"></param>
        public void OptenerMaterias(string Usuario, List<CMaterias> materias)
        {
            Open();

            cmd = new MySqlCommand("sp_usuario_materia", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                materias.Add(new CMaterias(
                    Convert.ToInt16(reader["Id_Materia"]),
                                    reader["Nombre_Mat"].ToString(),
                    Convert.ToInt16(reader["Horas_totales"]),
                    Convert.ToInt16(reader["Id_Ciclo"]),
                                    reader["Id_Usuario"].ToString()
                    ));

            }
            close();
        }
        /// <summary>
        /// Este metodo optine las materias en base al ID del grupo
        /// </summary>
        /// <param name="Id_Grupo"></param>
        /// <param name="materias"></param>
        public void OptenerMaterias(int Id_Grupo, List<CMaterias> materias)
        {
            Open();

            cmd = new MySqlCommand("sp_materias_grupo", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_grupo", Id_Grupo);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                materias.Add(new CMaterias(
                    Convert.ToInt16(reader["Id_Materia"]),
                                    reader["Nombre_Mat"].ToString(),
                    Convert.ToInt16(reader["Horas_totales"]),
                    Convert.ToInt16(reader["Id_Ciclo"]),
                                    reader["Id_Usuario"].ToString()
                    ));

            }
            close();
        }
        /// <summary>
        /// Este metotodo captura una nueva materia
        /// </summary>
        public void AgregarMateria(string Nombre_Materia,int Horas_totales,int Id_Ciclo,string Usuario)
        {
            Open();

            cmd = new MySqlCommand("sp_agregar_materia", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre_Mat", Nombre_Materia);
            cmd.Parameters.AddWithValue("@Horas_totales", Horas_totales);
            cmd.Parameters.AddWithValue("@Id_Ciclo", Id_Ciclo);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);

            cmd.ExecuteNonQuery();
            close();
        }
        /// <summary>
        /// Este Metodo Optiene los Planes de estudio
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="materias"></param>
        public void OptenerPE(int Id_Materia, List<CPlanDeEstudio> PEs)
        {
            Open();

            cmd = new MySqlCommand("sp_pe", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Materia1", Id_Materia);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                PEs.Add(new CPlanDeEstudio(
                    Convert.ToInt16(reader["Id_PE"]),
                    Convert.ToInt16(reader["Examen"]),
                    Convert.ToInt16(reader["Tareas"]),
                    Convert.ToInt16(reader["Practicas"]),
                    Convert.ToInt16(reader["Asistencia"]),
                    Convert.ToInt16(reader["Extra"]),
                    Convert.ToInt16(reader["Unidad"]),
                    Convert.ToInt16(reader["Id_Materia"])

                    ));

            }
            close();
        }
        /// <summary>
        /// Este metodo Agrega un Plan de Estudios
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="PEs"></param>
        public void AgrgarPe(int  Examen, int Tareas, int Practicas, int Asistencia, int Extra , int Unidad , int Id_Materia)
        {
            Open();

            cmd = new MySqlCommand("sp_agregar_pe", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Examen", Examen);
            cmd.Parameters.AddWithValue("@Tareas", Tareas);
            cmd.Parameters.AddWithValue("@Practicas", Practicas);
            cmd.Parameters.AddWithValue("@Asistencia", Asistencia);
            cmd.Parameters.AddWithValue("@Extra", Extra);
            cmd.Parameters.AddWithValue("@Unidad", Unidad);
            cmd.Parameters.AddWithValue("@Id_Materia", Id_Materia);
            cmd.ExecuteNonQuery();
            
            close();
        }
        public void AgregarActividad(int Id_Materia, int Valor, DateTime Fecha_Entrega, string tipo, int Id_PE, int Unidad, string Nombre_Act)
        {
            Open();

            cmd = new MySqlCommand("sp_agregar_actividad", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Materia", Id_Materia);
            cmd.Parameters.AddWithValue("@Valor", Valor);
            cmd.Parameters.AddWithValue("@Fecha_Entrega", Fecha_Entrega);
            cmd.Parameters.AddWithValue("@Tipo", tipo);
            cmd.Parameters.AddWithValue("@Id_PE", Id_PE);
            cmd.Parameters.AddWithValue("@Unidad", Unidad);
            cmd.Parameters.AddWithValue("@Nombre_Act", Nombre_Act);
            cmd.ExecuteNonQuery();

            close();
        }
        /// <summary>
        /// Este metodo optiene las actividades
        /// </summary>
        /// <param name="Id_Materia"></param>
        /// <param name="PEs"></param>
        public void OptenerActividades(int Unidad,int Id_PE, List<CActividades> Actividades)
        {
            Open();

            cmd = new MySqlCommand("sp_actividades", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Unidad", Unidad);
            cmd.Parameters.AddWithValue("@Id_PE", Id_PE);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Actividades.Add(new CActividades(
                    Convert.ToInt16(reader["Id_Actividad"]),
                    Convert.ToInt16(reader["Id_Materia"]),
                    Convert.ToInt16(reader["Valor"]),
                    Convert.ToDateTime(reader["Fecha_Entrega"]),
                    Convert.ToString(reader["Tipo"]),
                    Convert.ToInt16(reader["Id_PE"]),
                    Convert.ToInt16(reader["Unidad"]),
                    Convert.ToString(reader["Nombre_Act"])

                    ));

            }
            close();
        }/// <summary>
        /// Este Metodo Optiene los Grupos
        /// </summary>
        /// <param name="Unidad"></param>
        /// <param name="Id_PE"></param>
        /// <param name="Actividades"></param>
        public void OptenerGrupos( List<CGrupos> Grupos, string User)
        {
            Open();

            cmd = new MySqlCommand("sp_grupos", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Grupos.Add(new CGrupos(
                    Convert.ToInt16(reader["Id_Grupo"]),
                    Convert.ToString(reader["Nombre_Grupo"]),
                    Convert.ToInt16(reader["Id_Ciclo"])

                    ));

            }
            close();
        }
        public void CrearRelacion(int Id_Materia,int Id_Grupo)
        {
            if (ValidarRelacion(Id_Materia, Id_Grupo))
            {

                Open();

                cmd = new MySqlCommand("sp_relacionGM", conexionDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Materia", Id_Materia);
                cmd.Parameters.AddWithValue("@Id_Grupo", Id_Grupo);
                reader = cmd.ExecuteReader();

                close();
            }
            else
            {
                MessageBox.Show("Ya estan relacionadas");
            }
            
            


        }
        public bool ValidarRelacion(int Id_Materia, int Id_Grupo)
        {
            
            Open();

            cmd = new MySqlCommand("sp_validar", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdMateria", Id_Materia);
            cmd.Parameters.AddWithValue("@IdGrupo", Id_Grupo);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                close();
                return false;
                
            }
            else
            {
                close();
                return true;
                
            }
        }

        public void OptenerRelacionGM(List<CRelacionados> Relacionadas, string User)
        {
            Open();

            cmd = new MySqlCommand("sp_grupo_materias", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", User);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Relacionadas.Add(new CRelacionados(
                    Convert.ToString(reader["Nombre_Mat"]),
                    Convert.ToString(reader["Nombre_Grupo"])

                    ));

            }
            close();
        }/// <summary>
        /// Este metodo crea una nueve clase
        /// </summary>
        /// <param name="NombreGrupo"></param>
        /// <param name="Id_ciclo"></param>
        public void CrearClase(CClase Clase)
        {
            Open();

            cmd = new MySqlCommand("sp_crear_clase", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tema", Clase.Tema);
            cmd.Parameters.AddWithValue("@Fecha", Clase.Fecha);
            cmd.Parameters.AddWithValue("@Duracion", Clase.Duracion);
            cmd.Parameters.AddWithValue("@Id_Materia", Clase.Id_Materia);

            cmd.ExecuteNonQuery();
            close();
        }
        public void OptenerAlumnos(List<CAlumnos> Alumnos, int Id_Grupo)
        {
            Open();
            cmd = new MySqlCommand("sp_alumnos_grupo", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Grupo", Id_Grupo);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Alumnos.Add(new CAlumnos(
                    Convert.ToString(reader["Id_Alumno"]),
                    Convert.ToString(reader["Nombre"]),
                    Convert.ToString(reader["Apellidos"]),
                    Convert.ToInt16(reader["Id_Grupo"]),
                    Convert.ToInt16(reader["Activo"])


                    ));

            }
            close();
        }
        public int OptenerIdClase( int Id_Materia)
        {
            Open();
            cmd = new MySqlCommand("sp_ultima_clase", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdMateria", Id_Materia);
            int Ultima = 0;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {


                Ultima =Convert.ToInt16(reader["MAX(Id_Clase)"]);

                    
            }
            close();
            return Ultima;

        }
        public void CrearAsistencias(CAsistencia Asistencia)
        {
            Open();

            cmd = new MySqlCommand("sp_asistencia", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdClase", Asistencia.Clase.Id_Clase);
            cmd.Parameters.AddWithValue("@IdAlumno", Asistencia.Alumno.Id_Alumnos);
            cmd.Parameters.AddWithValue("@Valor", Asistencia.valor);

            cmd.ExecuteNonQuery();
            close();
        }
        public int OptenerAsistencias(CClase Clase, List<CAsistencia> Asistencias)
        {
            Open();
            cmd = new MySqlCommand("sp_obtener_asistencias", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdClase", Clase.Id_Clase);
            int Ultima = 0;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                //Asistencias.Add(new CAsistencia(
                //      Convert.ToString(reader["Id_Alumno"]),
                //      Convert.ToString(reader["Nombre"]),
                //      Convert.ToString(reader["Apellidos"]),
                //      Convert.ToInt16(reader["Id_Grupo"]),
                //      Convert.ToInt16(reader["Activo"])


                //      ));
            }
            close();
            return Ultima;

        }
        public void ActualizarAsistencias(CAsistencia Asistencia)
        {
            Open();

            cmd = new MySqlCommand("sp_asistencia", conexionDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Clase", Asistencia.Clase.Id_Clase);
            cmd.Parameters.AddWithValue("@Id_Alumno", Asistencia.Alumno.Id_Alumnos);
            cmd.Parameters.AddWithValue("@Valor", Asistencia.valor);

            cmd.ExecuteNonQuery();
            close();
        }
    }

}
