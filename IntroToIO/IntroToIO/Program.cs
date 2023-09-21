using System.IO;

//Dictionary that will obtain all files 
Dictionary<int, string> AllFiles = new Dictionary<int, string>();

string textFilePath = @"C:\Users\Gamer\source\repos\IntroToIO\IntroToIO\Story1.txt";
string textFilePath2 = @"C:\Users\Gamer\source\repos\IntroToIO\IntroToIO\Story2.txt";



//Path to access the correct directory
DirectoryInfo DataDir = new DirectoryInfo(@"C:\Users\Gamer\source\repos\IntroToIO\IntroToIO");

//An array that will find files with the exstenstion .txt
FileInfo[] txtFiles = DataDir.GetFiles("*.txt", SearchOption.AllDirectories) ;


//For loop that iterates over the array and adds the contents to the dictionary
for (int i = 0; i < txtFiles.Length; i++)
{
    AllFiles.Add(i, txtFiles[i].Name);
   
}


//for each loop that prints the dictionaries values such as file name and amount of characters in file
foreach (var item in AllFiles)
{
    Console.WriteLine(item.Value);
    Console.WriteLine(CharCount(item.Value));

}
printInfo(textFilePath);
printInfo(textFilePath2);

//Method that counts the characters in each file name
int CharCount(string _name)
{
    if (_name.Contains(' '))
    {
        _name = _name.Replace(" ", "");
        return _name.Length;
    }
    else
        return _name.Length;
}

void printInfo(string file)
{
    StreamReader reader = new StreamReader(file);
    string? line = reader.ReadLine();
    while (line != null)
    {
        Console.WriteLine(line);

        line = reader.ReadLine();
    }

    reader.Close();
}
