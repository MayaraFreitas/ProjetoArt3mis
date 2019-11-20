using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDataBase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

    void BuildDataBase()
    {
        items = new List<Item>() {
            new Item(0, "Diamond Sword", "A sword made with diamond.", 
                new Dictionary<string, string>
                {
                    { "Power: ", "15" },
                    { "Defence", "10" }
                }),
            new Item(1, "Diamond Ore", "A beaultiful diamond.",
                new Dictionary<string, string>
                {
                    { "Value: ", "444" }
                }),
            new Item(2, "Silver Pick", "A very C# pick.",
                new Dictionary<string, string>
                {
                    { "Power: ", "5" },
                    { "Defence", "333"}
                }),
            new Item(3, "Gold Ore", "A beaultiful Gold rock.",
                new Dictionary<string, string>
                {
                    { "Value: ", "999" }
                }),
            new Item(4, "Balde com Purpura", "Um balde cheio de um líquido roxo",
                new Dictionary<string, string>
                {
                    { "OBS: ", "O líquido parece conter Hidrogênio e Oxigênio!" }
                }),
            new Item(5, "Balde com Água", "Um balde cheio água",
                new Dictionary<string, string>
                {
                    { "OBS: ", "Água potável!" }
                }),
            new Item(6, "Balde Vazio", "Um balde vazio",
                new Dictionary<string, string>
                {
                    { "OBS: ", "Somente um balde vazio mesmo.." }
                }),
            new Item(7, "Tronco", "",
                new Dictionary<string, string>
                {
                    { "OBS: ", "Parece madeira" }
                })

        };
    }
}
