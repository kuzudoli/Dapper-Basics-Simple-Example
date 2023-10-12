using Dapper;
using DapperExample.Models;
using System.Data.SqlClient;

await GetList();

async Task GetList()
{
    using (var _conn = new SqlConnection("Data Source=.;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;"))
    {
        Console.WriteLine(_conn.State.ToString());//Closed

        var result = await _conn.QueryAsync<Employee>("SELECT * FROM Employees"); //Dapper opens connection while executing the query and then it closes connection when returned result

        Console.WriteLine(_conn.State.ToString());//Closed
    }

    #region UserConnectionHandling
    //using (var _conn = new SqlConnection("Data Source=.;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;"))
    //{
    //    _conn.Open();
    //    Console.WriteLine(_conn.State.ToString());//Open

    //    var result = await _conn.QueryAsync<Employee>("SELECT * FROM Employees"); //Connection already opened, it doesn't attempt to open new connection

    //    _conn.Close();
    //    Console.WriteLine(_conn.State.ToString());//Closed
    //}
    #endregion
}