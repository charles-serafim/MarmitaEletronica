using Cardapio.TiposItems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public abstract class JsonParser
{
    public static List<T> ReceberJson<T>(string absolutePath) where T : class // Metodo é estático, coloque o path do arquivo json
    {
        // Recebe os paths
        string absolutePath = @"C:\Users\luanar\source\repos\MarmitaEletronica\Cardapio\Itens.json"; //Mudar aqui, colocar nos inputs da func
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string relativePath = Path.GetRelativePath(baseDirectory, absolutePath);

        try
        {
            string jsonString = File.ReadAllText(absolutePath);
            List<T> itemList = JsonSerializer.Deserialize<List<T>>(jsonString);
            return itemList;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }
    public static List<Item> OrdenarItensPorNome(List<Item> ItemsDoCardapio)
    {
        return ItemsDoCardapio.OrderBy(item => item.Nome).ToList();
    }
    public static List<Item> OrdenarItensPorId(List<Item> ItemsDoCardapio)
    {
        return ItemsDoCardapio.OrderBy(item => item.Id).ToList();
    }
}