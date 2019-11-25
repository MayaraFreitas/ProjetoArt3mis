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
            new Item(0, "Carreg Goch", "Propriedades que permite filtrar líquidos", 
                new Dictionary<string, string>
                {
                    { "OBS: ", "Isso brilha? Wow!" }
                }),
            new Item(1, "Balde com Purpura", "Um balde cheio de um líquido roxo",
                new Dictionary<string, string>
                {
                    { "OBS: ", "O líquido parece conter Hidrogênio e Oxigênio!" }
                }),
            new Item(2, "Balde com Água", "Um balde cheio água",
                new Dictionary<string, string>
                {
                    { "OBS: ", "Yeaah! Água potável!" }
                }),
            new Item(3, "Balde Vazio", "Um balde vazio",
                new Dictionary<string, string>
                {
                    { "OBS: ", "Somente um balde vazio mesmo.." }
                }),
            new Item(4, "Tronco", "",
                new Dictionary<string, string>
                {
                    { "OBS: ", "Parece madeira, mas..." }
                })
        };
    }
}
