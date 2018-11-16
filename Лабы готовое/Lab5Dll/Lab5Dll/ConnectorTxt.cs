using System.Collections.Generic;
using System.IO.MemoryMappedFiles;

public struct Phonebook
{
    public int Id { get; set; }
    public string Phone { get; set; }
    public string SecondName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Housing { get; set; }
    public string Flat { get; set; }
}

public class ConnectorTxt
{
    public List<string> errorList = new List<string>();
    private string _path { get; set; }

    public void Set(string path) => _path = path;

    public string Get() => _path;

    public List<Phonebook> ReadFileFromMemory()
    {
        List<string> list = new List<string>();
        List<Phonebook> listPhonebook = new List<Phonebook>();

        string value = "";

        using (MemoryMappedFile file = MemoryMappedFile.CreateFromFile(_path))
        using (MemoryMappedViewStream stream = file.CreateViewStream())
        {
            while (true)
            {
                // Read in byte from the MemoryMappedFile.
                int result = stream.ReadByte();
                // Zero bytes are past the end of the file.
                if (result == 0)
                    break;

                char letter = (char)result;
                value += letter;
            }
        }

        value = value.Replace("\r\n", "©");

        string buffer = "";
        while (value.Contains("©"))
        {
            buffer = value.Substring(0, value.IndexOf("©"));
            list.Add(buffer);
            value = value.Remove(0, value.IndexOf("©") + 1);
        }
        list.Add(value);

        for (int i = 0; i < list.Count; i = i + 9)
        {
            listPhonebook.Add(new Phonebook
            {
                Id = int.Parse(list[i]),
                Phone = list[i + 1],
                SecondName = list[i + 2],
                FirstName = list[i + 3],
                MiddleName = list[i + 4],
                Street = list[i + 5],
                House = list[i + 6],
                Housing = list[i + 7],
                Flat = list[i + 8]
            });
        }

        return listPhonebook;
    }

    public Phonebook GetIndex(int index)
    {
        int count = ReadFileFromMemory().Count;

        if (index < count)
            return ReadFileFromMemory()[index];

        return new Phonebook();
    }
}