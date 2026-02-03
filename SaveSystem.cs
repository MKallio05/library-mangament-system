using System.Text.Json;

class SaveSystem
{
    public static void Save(Library library)
    {
        var json = JsonSerializer.Serialize(library);
        File.WriteAllText("library.json", json);
    }

    public static Library Load()
    {
        if (!File.Exists("library.json"))
            return new Library();

        var json = File.ReadAllText("library.json");
        return JsonSerializer.Deserialize<Library>(json);
    }
}
