using Cardapio.TiposItems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public abstract class JsonParser <T> where T : class
{
    public static List<T> ReceberJson()
    {
        string tipo = typeof(T).Name; // Recebe o nome da classe
        // Recebe os paths
        string absolutePath = @$"C:\Users\yuric\source\repos\MarmitaEletronica\Cardapio\Itens.json";
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