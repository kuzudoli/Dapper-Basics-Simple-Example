using Dapper;
using DapperExample.Models;
using System.Data;
using System.Data.SqlClient;

await GetList();

async Task GetList()
{
    using (IDbConnection conn = new SqlConnection("Data Source=.;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;"))
    {
        #region QueryAsync (Select)
        var result = await conn.QueryAsync<Employee>("SELECT * FROM Employees");
        #endregion

        #region ExecuteAsync (Insert)
        //var hasData = conn.QueryAsync<Employee>("SELECT * FROM Employees WHERE first_name = 'Enes'").Result.Any(x => x.first_name == "Enes");
        //if (!hasData)
        //{
        //    var result = await conn.ExecuteAsync("INSERT INTO Employees Values(1001,'Enes','Çakır',23,'eckr@mail.com','Turkey','34000','Red','01/08/2021','10000')");
        //    var response = await conn.QueryAsync<Employee>("SELECT * FROM Employees WHERE first_name = 'Enes'");
        //}
        #endregion

        #region ExecuteAsync (Update)
        //var result = await conn.ExecuteAsync("UPDATE Employees SET favorite_color = 'Yellow' WHERE employee_id = '1001'");
        //var response = await conn.QueryAsync<Employee>("SELECT * FROM Employees WHERE first_name = 'Enes'");
        #endregion

        #region ExecuteAsync (Delete)
        //var result = await conn.ExecuteAsync("DELETE FROM Employees WHERE age < 19");
        #endregion


        #region QueryAsync (SP-Select)

        #region Create SP: GetYoungEmployeesByFavoriteColor
        //var spResult = await conn.QueryAsync(@"CREATE PROCEDURE GetYoungEmployeesByFavoriteColor 
        //                                    (@age int, @favColor varchar(50)) 
        //                                    AS 
        //                                    BEGIN 
        //                                        SELECT * FROM Employees WHERE age < @age AND favorite_color = @favColor 
        //                                    END");

        #endregion

        //var parameters = new DynamicParameters();
        //parameters.Add("age", 23);
        //parameters.Add("favColor", "blue");

        //var result = await conn.QueryAsync("GetYoungEmployeesByFavoriteColor", parameters, null, null, CommandType.StoredProcedure);
        //var result2 = await conn.QueryAsync("GetYoungEmployeesByFavoriteColor", new { age = 25, favColor = "red" }, null, null, CommandType.StoredProcedure);
        #endregion

        #region ExecuteAsync (SP-Insert)

        #region Create SP: InsertEmployee
        //var spResult = await conn.QueryAsync(@"CREATE PROCEDURE InsertEmployee
        //                                    (@id int,@name varchar,@lastname varchar, @country varchar, @age int, @favColor varchar)
        //                                    AS
        //                                    BEGIN
        //                                        INSERT INTO Employees(employee_id, first_name, last_name, country, age, favorite_color) 
        //                                        VALUES(@id,@name,@lastname,@country, @age, @favColor);
        //                                    END");
        #endregion

        //var parameters = new DynamicParameters();
        //parameters.Add("id", 3279);
        //parameters.Add("name", "Ahmet");
        //parameters.Add("lastname", "Sevgi");
        //parameters.Add("country", "Turkey");
        //parameters.Add("age", 26);
        //parameters.Add("favColor", "black");

        //var result = await conn.ExecuteAsync("InsertEmployee", parameters, null, null, CommandType.StoredProcedure);
        #endregion

        //Breakpoint variable for debugging the results
        var wait = 1;
    }
}