using Cardapio.TiposItems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public abstract class JsonParser
{
    public static List<Item> ReceberJson()
    {
        // Recebe os paths
        string absolutePath = @"C:\Users\luanar\source\repos\MarmitaEletronica\Cardapio\Itens.json"; //Mudar aqui, colocar nos inputs da func
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string relativePath = Path.GetRelativePath(baseDirectory, absolutePath);

        try
        {
            string jsonString = File.ReadAllText(absolutePath);
            List<Item> itemList = JsonSerializer.Deserialize<List<Item>>(jsonString);
            return itemList;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }
}