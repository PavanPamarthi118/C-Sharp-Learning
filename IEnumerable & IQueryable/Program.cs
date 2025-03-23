// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//-----------------------------------------------🔹IEnumerable<T> (In-Memory Enumeration) ------------------------------------------------//
/*
IEnumerable<T> is used for iterating through in-memory collections. It is suitable for working with data that is already loaded into memory.

✅ Key Features of IEnumerable<T>
✔ Executes in Memory: Queries are executed in-memory, meaning all data must be loaded before filtering or processing.
✔ Supports LINQ-to-Objects: Works with collections like List<T>, Array, etc.
✔ Forward-Only Traversal: Supports foreach loop but does not allow indexed access (except when implemented by lists or arrays).
✔ Deferred Execution: LINQ queries using IEnumerable<T> execute when iterated (e.g., inside a foreach loop). 
*/

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        List<int> myList = new List<int> { 8,96,5,6,4,8};
        // IEnumerable query
        IEnumerable<int> evenNumbers = myList.Where(n => n % 2 == 0);
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}

/*
🛠 How It Works
The query numbers.Where(n => n % 2 == 0) filters even numbers.
The execution happens in memory, meaning all elements are already loaded.
IEnumerable<T> is best for in-memory collections. 
*/


//-----------------------------------------------🔹 2. IQueryable<T> (Deferred Execution & Database Querying) ------------------------------------------------//

/*
 IQueryable<T> is used for querying databases and remote data sources. It is suitable for efficient query execution on external data sources like SQL databases.

✅ Key Features of IQueryable<T>
✔ Executes on Data Source: Queries are converted to SQL and executed on a database server (like SQL Server).
✔ Supports LINQ-to-SQL / LINQ-to-Entities: Works with Entity Framework (EF), NHibernate, etc.
✔ Deferred Execution: The query is not executed until it is iterated (e.g., ToList(), FirstOrDefault()).
✔ Performance Optimized: Fetches only required data from the database, reducing memory usage.
*/


public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program2
{
    static void Main()
    {
        using var dbContext = new AppDbContext();

        // IQueryable query (NOT executed immediately)
        IQueryable<Customer> query = dbContext.Customers.Where(c => c.Name.StartsWith("A"));

        // Executed only when iterated or converted to List
        var result = query.ToList();

        foreach (var customer in result)
        {
            Console.WriteLine(customer.Name);
        }
    }
}
/*
🛠 How It Works
dbContext.Customers.Where(c => c.Name.StartsWith("A")) builds a SQL query.
IQueryable<T> does not execute immediately.
Query is sent to the database when ToList() is called.
Only the filtered data is retrieved, improving efficiency. 
*/

/*
🔹 When to Use What?
✅ Use IEnumerable<T> when:
✔ Working with in-memory collections (e.g., List<T>, Array)
✔ Filtering or transforming small datasets
IEnumerable<T> is best for in-memory collections and LINQ-to-Objects.

✅ Use IQueryable<T> when:
✔ Querying large datasets (e.g., databases)
✔ Using Entity Framework or LINQ-to-SQL
✔ Optimizing performance by fetching only required data 
IQueryable<T> is best for database querying (LINQ-to-SQL, LINQ-to-Entities).
*/