// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/*The async and await keywords in C# are used to write asynchronous code, allowing methods to run without blocking the main thread. 
 * They help improve application responsiveness, especially in I/O-bound operations (e.g., web requests, file access, or database calls).*/

class Program1
{
    static async Task DoWorkAsync()
    {
        await Task.Delay(3000);  // Non-blocking 3-second delay
        Console.WriteLine("Work done asynchronously!");
    }

    static async Task Main()
    {
        Console.WriteLine("Starting async work...");
        await DoWorkAsync();  // Waits for DoWorkAsync without blocking
        Console.WriteLine("Finished async work!");
    }
}

//Async/Await Example: Fetching Data from a Web API


class Program2
{
    // Asynchronous method to fetch data from an API
    static async Task FetchDataAsync()
    {
        using HttpClient client = new HttpClient();  // Create an HttpClient to send requests

        Console.WriteLine("Fetching data...");

        // `await` makes the method wait for the API response without blocking the main thread
        string data = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");

        // The code here runs only after the API response is received
        Console.WriteLine("Data fetched:");
        Console.WriteLine(data);
    }

    //Main method: Entry point of the program(also asynchronous)
    static async Task Main()
    {
        // Call the async method and wait for it to complete
        await FetchDataAsync();

        Console.WriteLine("Operation completed!");
    }
}

class Program3
{
    static async Task Main()
    {
        Console.WriteLine("Starting program...\n");

        // Start multiple async tasks
        Task download1 = DownloadFileAsync("File1");
        Task download2 = DownloadFileAsync("File2");
        Task download3 = DownloadFileAsync("File3");

        // Meanwhile, do other work
        Console.WriteLine("Performing other tasks while files download...\n");
        SimulateLoadingAnimation(10);  // Simulates work being done

        // Wait for all downloads to complete
        await Task.WhenAll(download1, download2, download3);

        Console.WriteLine("\nAll downloads completed! ✅");
    }

    static async Task DownloadFileAsync(string fileName)
    {
        Console.WriteLine($"Starting download: {fileName} 📥");
        await Task.Delay(3000);  // Simulating a 3-second download
        Console.WriteLine($"\nDownload completed: {fileName} ✅");
    }

    static void SimulateLoadingAnimation(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write(".");
            Thread.Sleep(300); // Simulates some work happening
        }
        Console.WriteLine();
    }
}