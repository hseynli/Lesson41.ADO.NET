using Microsoft.Data.SqlClient;

string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True";

using (SqlConnection connection = new SqlConnection(conStr))
{
    connection.StateChange += connection_StateChange; // Qoşulmanın cari halı dəyişildikdə baş verən hadisə

    try
    {
        connection.Open();
        //throw new Exception("error"); // Şərhdən çıxarmaq
    }
    catch (Exception e)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(e.Message);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
} // connection.Dispose();


static void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
{
    SqlConnection connection = sender as SqlConnection;

    Console.WriteLine();

    Console.WriteLine                 // Qoşulma və onun cari halı haqqında məlumat
        (
        "Connection to" + Environment.NewLine +
        "Data Source: " + connection.DataSource + Environment.NewLine +
        "Database: " + connection.Database + Environment.NewLine +
        "State: " + connection.State
        );
}