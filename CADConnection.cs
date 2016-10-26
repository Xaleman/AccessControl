using System;
using System.Data;
using AccessControl;
using MySql.Data.MySqlClient;

namespace AccessControl
{
	public class CADConnection
	{
		DTOConfig dTOConfig;

		public CADConnection (DTOConfig _DTOConfig)
		{
			dTOConfig = _DTOConfig;
		}
		public bool checkConnection()
		{
			bool result = true;
			MySqlConnection con = new MySqlConnection (dTOConfig.ConnectionString);
			//MySqlCommand cmd = new MySqlCommand ("SELECT id, nombre, telefono, URL FROM personas", con);

			try {
				con.Open ();
				//Ejecutamos la sentencia SQL
				//MySqlDataReader reader = cmd.ExecuteReader ();

				//Llenamos el ListStore con cada fila mientras el Datareader recorre la BD
				//while (reader.Read ()) {
				//	personas.AppendValues ((int)reader["id"], (string)reader["nombre"], (string)reader["telefono"], (string)reader["URL"]);
				//}
			} catch (Exception ex) {
				result = false;
				//throw new Exception (ex.Message);
			}
			finally
			{
				//cmd.Dispose ();
				//con.Dispose ();
			}

			return result;
		}
	}
}

