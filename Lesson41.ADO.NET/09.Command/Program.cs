using Microsoft.Data.SqlClient;

string conStr = @"some connection string;"; 
SqlConnection connection = new SqlConnection(conStr);

//**********Birinci variant**************
SqlCommand cmd = new SqlCommand();
cmd.Connection = connection;
cmd.CommandText = "Some T-SQL Command";

//**********İkinci variant**************
cmd = connection.CreateCommand();
cmd.CommandText = "Some T-SQL Command";

//**********Üçüncü variant**************
cmd = new SqlCommand("Some T-SQL Command", connection);
