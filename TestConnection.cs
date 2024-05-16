using Npgsql;
using System;

class TestConnection
{
    static void Main(string[] args)
    {
        var connectionString = "Host=dpg-cp1lmaud3nmc73b7j75g-a;Database=igolf_db_j9w3;Username=igolf_db_j9w3_user;Password=iUOvV7Pf72RpBtD0eruzLsdIu928HMST";
        using var conn = new NpgsqlConnection(connectionString);
        try
        {
            conn.Open();
            Console.WriteLine("Connection successful!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
