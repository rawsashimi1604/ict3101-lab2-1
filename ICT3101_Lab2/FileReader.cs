namespace ICT3101_Lab2;

public class FileReader
{
    public string[] Read(string path)
    {
        return File.ReadAllLines(path);
    }
}