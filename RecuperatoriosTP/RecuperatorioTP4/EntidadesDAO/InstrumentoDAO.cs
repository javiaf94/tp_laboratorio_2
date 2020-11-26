using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BibliotecaClases;
using Excepciones;

namespace EntidadesDAO
{
    public class InstrumentoDAO
    {
        private static SqlConnection sqlConnection;
        private static string connectionString;

        static InstrumentoDAO()
        {
            InstrumentoDAO.connectionString = "Server =.\\SQLEXPRESS; Database = TiendaMusical; Trusted_Connection = True";
            InstrumentoDAO.sqlConnection = new SqlConnection(connectionString);
        }

        public static void Guardar(Guitarra g)
        {
            try
            {
                string command = "INSERT INTO Guitarras VALUES(@numSerie, @marca, @modelo, @precio, @tipo)";
                SqlCommand sqlCommand = new SqlCommand(command, InstrumentoDAO.sqlConnection);
                sqlCommand.Parameters.AddWithValue("numSerie", g.NumSerie);
                sqlCommand.Parameters.AddWithValue("marca", g.Marca);
                sqlCommand.Parameters.AddWithValue("modelo", g.Modelo);
                sqlCommand.Parameters.AddWithValue("precio", g.Precio);
                sqlCommand.Parameters.AddWithValue("tipo", g.Tipo.ToString());                

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw (new InstrumentoRepetidoException("Ya existe una guitarra con ese numero de serie", ex));
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                    InstrumentoDAO.sqlConnection.Close();
            }
        }

        public static void Guardar(Bajo b)
        {
            try
            {
                string command = "INSERT INTO Bajos VALUES(@numSerie, @marca, @modelo, @precio, @tipo)";
                SqlCommand sqlCommand = new SqlCommand(command, InstrumentoDAO.sqlConnection);
                sqlCommand.Parameters.AddWithValue("numSerie", b.NumSerie);
                sqlCommand.Parameters.AddWithValue("marca", b.Marca);
                sqlCommand.Parameters.AddWithValue("modelo", b.Modelo); ;
                sqlCommand.Parameters.AddWithValue("precio", b.Precio);
                sqlCommand.Parameters.AddWithValue("tipo", b.Tipo.ToString());               

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw (new InstrumentoRepetidoException("Ya existe un bajo con ese numero de serie", ex));
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                    InstrumentoDAO.sqlConnection.Close();
            }
        }

        public static int EliminarBajo(string serie)
        {
            try
            {
                string command = "DELETE FROM Bajos " + "WHERE numSerie = @serie";

                InstrumentoDAO.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, InstrumentoDAO.sqlConnection);
                sqlCommand.Parameters.AddWithValue("serie", serie);
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Error al realizar la eliminación", ex);

            }
            finally
            {
                if (InstrumentoDAO.sqlConnection != null && InstrumentoDAO.sqlConnection.State == System.Data.ConnectionState.Open)
                    InstrumentoDAO.sqlConnection.Close();
            }
        }

        public static int EliminarGuitarra(string serie)
        {
            try
            {
                string command = "DELETE FROM Guitarras " + "WHERE numSerie = @serie";

                InstrumentoDAO.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, InstrumentoDAO.sqlConnection);
                sqlCommand.Parameters.AddWithValue("serie", serie);
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Error al realizar la eliminación", ex);

            }
            finally
            {
                if (InstrumentoDAO.sqlConnection != null && InstrumentoDAO.sqlConnection.State == System.Data.ConnectionState.Open)
                    InstrumentoDAO.sqlConnection.Close();
            }
        }

        public static List<Instrumento> LeerInstrumentos()
        {
            try
            {
                string command = "SELECT * FROM Guitarras";

                InstrumentoDAO.sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, InstrumentoDAO.sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                List<Instrumento> instrumentos = new List<Instrumento>();
                while (reader.Read())
                {                    
                        string numSerie = (string)reader["numSerie"];
                        string marca = (string)reader["marca"];
                        string modelo = (string)reader["modelo"];
                        string tipo = (string)reader["tipo"];
                        float precio = (float)Convert.ToDouble(reader["precio"]);                        

                        Guitarra.ETipoGuitarra eTipo;
                        if (tipo == "Electrica")
                            eTipo = Guitarra.ETipoGuitarra.Electrica;
                        else
                            eTipo = Guitarra.ETipoGuitarra.Acustica;

                        Guitarra g = new Guitarra(numSerie, marca, modelo, precio, eTipo);
                        instrumentos.Add(g);
                }
                reader.Close();

                command = "SELECT * FROM Bajos";
                sqlCommand = new SqlCommand(command, InstrumentoDAO.sqlConnection);
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string numSerie = (string)reader["numSerie"];
                    string marca = (string)reader["marca"];
                    string modelo = (string)reader["modelo"];
                    string tipo = (string)reader["tipo"];
                    float precio = (float)Convert.ToDouble(reader["precio"]);                    

                    Bajo.ETipoBajo eTipo;
                    if (tipo == "Pasivo")
                        eTipo = Bajo.ETipoBajo.Pasivo;
                    else
                        eTipo = Bajo.ETipoBajo.Activo;

                    Bajo b = new Bajo(numSerie, marca, modelo, precio, eTipo);
                    instrumentos.Add(b);
                }

                return instrumentos;
            }
            catch (Exception ex)
            {
                throw new DatabaseException("Error al leer la lista de instrumentos", ex);
            }
            finally
            {
                if (InstrumentoDAO.sqlConnection != null && InstrumentoDAO.sqlConnection.State == System.Data.ConnectionState.Open)
                    InstrumentoDAO.sqlConnection.Close();
            }
        }

        public static void Modificar(Guitarra g)
        {
            try
            {
                string command = "UPDATE Guitarras SET numSerie = @numSerie , marca = @marca , modelo = @modelo " +
               ", precio = @precio , tipo = @tipo WHERE numSerie = @numSerie";
                SqlCommand sqlCommand = new SqlCommand(command, InstrumentoDAO.sqlConnection);
                sqlCommand.Parameters.AddWithValue("numSerie", g.NumSerie);
                sqlCommand.Parameters.AddWithValue("marca", g.Marca);
                sqlCommand.Parameters.AddWithValue("modelo", g.Modelo); ;
                sqlCommand.Parameters.AddWithValue("precio", g.Precio);
                sqlCommand.Parameters.AddWithValue("tipo", g.Tipo.ToString());                

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw (new InstrumentoRepetidoException("Ya existe una guitarra con ese numero de serie", ex));
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                    InstrumentoDAO.sqlConnection.Close();
            }            
        }

        public static void Modificar(Bajo b)
        {
            try
            {
                string command = "UPDATE Bajos SET numSerie = @numSerie , marca = @marca , modelo = @modelo " +
               ", precio = @precio , tipo = @tipo WHERE numSerie = @numSerie";
                SqlCommand sqlCommand = new SqlCommand(command, InstrumentoDAO.sqlConnection);
                sqlCommand.Parameters.AddWithValue("numSerie", b.NumSerie);
                sqlCommand.Parameters.AddWithValue("marca", b.Marca);
                sqlCommand.Parameters.AddWithValue("modelo", b.Modelo); ;
                sqlCommand.Parameters.AddWithValue("precio", b.Precio);
                sqlCommand.Parameters.AddWithValue("tipo", b.Tipo.ToString());                

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw (new InstrumentoRepetidoException("Ya existe un bajo con ese numero de serie", ex));
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                    InstrumentoDAO.sqlConnection.Close();
            }
        }


    }
}
