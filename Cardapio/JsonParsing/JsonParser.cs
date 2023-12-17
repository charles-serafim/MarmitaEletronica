﻿using Cardapio.TiposItems.Cardapio.TiposItems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

internal class JsonParser
{
    public static List<Item> Parse()
    {
        // Recebe os paths
        string absolutePath = @"C:\Users\pedrov\Desktop\Ada\arquviosjson\cardapiojson\cardapiojson\itens.json";
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string relativePath = Path.GetRelativePath(baseDirectory, absolutePath);

        try
        {
            string jsonString = File.ReadAllText(absolutePath);
            List<Item> itemList = JsonSerializer.Deserialize<List<Item>>(jsonString);
            for (int i = 0; i < itemList.Count; i++)
            {
                itemList[i].ID = i + 1; // IDs iniciando de 1 (ou do valor desejado)
            }

            return itemList;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }

    public static void Printing(List<Item> itemList)
    {
        if (itemList == null)
        {
            Console.WriteLine("Unable to print items. Check for parsing errors.");
            return;
        }

        foreach (var item in itemList)
        {
            Console.WriteLine($"" +
                $"\nNúmero: {item.ID}," +
                $"\nNome: {item.Nome}," +
                $"\nTipo: {item.Tipo}," +
                $"\nVegetariano: {item.Vegetariano}," +
                $"\nPreço: {item.Preco}," +
                $"\nDescrição: {item.Descricao}," +
                $"\nCalorias: {item.Calorias}\n");
        }
    }

}