using Cardapio.TiposItems;
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
        string absolutePath = @"C:\Users\luanar\source\repos\MarmitaEletronica\Cardapio\Itens.json";
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string relativePath = Path.GetRelativePath(baseDirectory, absolutePath);

        try
        {
            string jsonString = File.ReadAllText(absolutePath);
            List<Item> itemList = JsonSerializer.Deserialize<List<Item>>(jsonString);
            itemList = itemList.OrderBy(item => item.Nome).ToList();
            
            return itemList;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }

    public void Printing(List<Item> itemList)
    {
        if (itemList == null)
        {
            Console.WriteLine("Unable to print items. Check for parsing errors.");
            return;
        }

        foreach (var item in itemList)
        {
            Console.WriteLine($"" +
                $"\nNome: {item.Nome}," +
                $"\nTipo: {item.Tipo}," +
                $"\nVegetariano: {item.Vegetariano}," +
                $"\nPreço: {item.Preco}," +
                $"\nDescrição: {item.Descricao}," +
                $"\nCalorias: {item.Calorias}\n");
        }
    }

}