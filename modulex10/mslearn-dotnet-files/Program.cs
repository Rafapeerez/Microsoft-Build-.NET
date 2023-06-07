using System.IO;
using Newtonsoft.Json;
//using System.Collection.Generic;
/**
//First exercise
var salesFiles = FindFiles("stores");

foreach (var file in salesFiles){
    Console.WriteLine(file);
}

IEnumerable <string> FindFiles(string folderName){
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles){
        // The file name will contain the full path, so only check the end of it
        if (file.EndsWith("sales.json")){
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}*/

//------------------------------------------------------------------------------------------------------------------
//Show the current directory
//Console.WriteLine(Directory.GetCurrentDirectory());
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Returns the path to the equivalent of the Windows My Documents folder, or the user's HOME directory for any operating system, even if the code is running on Linux.
/**string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Console.WriteLine(docPath);*/
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
/**Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
returns:
stores\201 on Windows
stores/201 on macOS   */
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Console.WriteLine(Path.Combine("stores","201")); // outputs: stores/201
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Show a lot of information about the file
/**string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";
FileInfo info = new FileInfo(fileName);
Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}");*/ // And many more
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
/**
//Second exercise
var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");
var salesFiles = FindFiles(storesDirectory); 

foreach (var file in salesFiles) {
    Console.WriteLine(file);
}

IEnumerable <string> FindFiles(string folderName){
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles){
        var extension = Path.GetExtension(file);
        if (extension == ".json"){
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}*/
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Create directories
//Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(),"stores","201","newDir"));
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Check if a directory exists
//var filePath = "home/rafa/prueba"
//bool check = Directory.Exists(filePath);
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Create file
//File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Read the content of a file
//File.ReadAllText(($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json"));
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Parse the data read from String to JSON --> dotnet add package Newtonsoft.Json
/** using Newtonsoft.Json
    var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
    var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);
    Console.WriteLine(salesData.Total);
    class SalesTotal{
        public double Total{ get; set; }
    }
*/
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Write data on file
//var data = JsonConvert.DeserializerObject<SalesTotal>(salesJson);
//File.WriteAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", data.Total.ToString());
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Append data to files
///var data = JsonConvert.DeserializeObject<SalesTotal>(salesJson);
//File.AppendAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", $"{data.Total}{Environment.NewLine}");
//------------------------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------------------------
//Third exercise
var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);   

var salesFiles = FindFiles(storesDirectory);
var salesTotal = CalculateSalesTotal(salesFiles);

File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;
    
    // Loop over each file path in salesFiles
    foreach (var file in salesFiles)
    {      
        // Read the contents of the file
        string salesJson = File.ReadAllText(file);
    
        // Parse the contents as JSON
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);
    
        // Add the amount found in the Total field to the salesTotal variable
        salesTotal += data?.Total ?? 0;
    }
    
    return salesTotal;
}

record SalesData (double Total);
//------------------------------------------------------------------------------------------------------------------


//------------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------------

