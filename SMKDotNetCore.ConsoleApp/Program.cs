using SMKDotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

// nuget
// sql connection


// Ado.Net
// CRUD
AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read(); 
//adoDotNetExample.Create("Title 1", "Author 1", "content 1");
//adoDotNetExample.Update(2004, "Title 4", "Author 4", "Content 4");
//adoDotNetExample.Delete(2003);
adoDotNetExample.Edit(2003);
adoDotNetExample.Edit(2004);

Console.ReadKey();
