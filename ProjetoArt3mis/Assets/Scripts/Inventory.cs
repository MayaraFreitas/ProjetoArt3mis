using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> chacacterItems = new List<Item>();
    public ItemDatabase itemDatabase;

    private void Start()
    {
        GiveItem("Diamond Sword");
        GiveItem(1);
        GiveItem(2);
        RemoveItem(1);
    }

    public void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        chacacterItems.Add(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    public void GiveItem(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        chacacterItems.Add(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    public Item CheckForItem(int id)
    {
        return chacacterItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
    {
        Item item = CheckForItem(id);
        if(item != null)
        {
            chacacterItems.Remove(item);
            Debug.Log("Item removed: " + item.title);
        }
    }
}
