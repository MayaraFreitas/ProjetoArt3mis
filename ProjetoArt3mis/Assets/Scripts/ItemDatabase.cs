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
        Dictionary<string, int> teste = new Dictionary<string, int> { { "Power: ", 15 }, { "Defence", 10 } };

        items = new List<Item>() {
            new Item(0, "Diamond Sword", "A sword made with diamond.", 
                new Dictionary<string, int>
                {
                    { "Power: ", 15 },
                    { "Defence", 10 }
                }),
            new Item(0, "Diamond Ore", "A beaultiful diamond.",
                new Dictionary<string, int>
                {
                    { "Value: ", 444 }
                }),
            new Item(0, "Silver Pick", "A very C# pick.",
                new Dictionary<string, int>
                {
                    { "Power: ", 5 },
                    { "Defence", 333 }
                })
        };
    }
}
