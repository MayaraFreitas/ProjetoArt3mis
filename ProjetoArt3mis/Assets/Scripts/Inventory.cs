﻿using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> chacacterItems = new List<Item>();
    public ItemDatabase itemDatabase;
    public UIInventory inventoryUI;

    private void Start()
    {
        AddItem("Diamond Sword");
        AddItem(1);
        AddItem(2);

        inventoryUI.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)){
            inventoryUI.gameObject.SetActive(!inventoryUI.gameObject.activeSelf);
        }
    }

    public void AddItem(int id)
    {
        if (chacacterItems.Count < inventoryUI.numberOfSlots)
        {
            Item itemToAdd = itemDatabase.GetItem(id);
            addNewItem(itemToAdd);
        }
        else
        {
            print("INVENTARIO CHEIO :(");
        }
        
    }

    public void AddItem(string itemName, GameObject obj = null)
    {
        if (chacacterItems.Count < inventoryUI.numberOfSlots)
        {
            Item itemToAdd = itemDatabase.GetItem(itemName);
            addNewItem(itemToAdd);
            if (obj != null)
            {
                Destroy(obj);
            }
        }
        else
        {
            print("INVENTARIO CHEIO :(");
        }
    }

    private void addNewItem(Item itemToAdd)
    {
        chacacterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    public Item CheckForItem(int id)
    {
        return chacacterItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);
        if(itemToRemove != null)
        {
            chacacterItems.Remove(itemToRemove);
            inventoryUI.RemoveItem(itemToRemove);
            Debug.Log("Item removed: " + itemToRemove.title);
        }
    }

    public void DropItem(UIItem selectedItem)
    {
        if (selectedItem != null && selectedItem.item != null)
        {
            // Remover da lusta de character
            chacacterItems.Remove(selectedItem.item);
            
            // Setar item igual a null no slot do inventário
            selectedItem.UpdateItem(null);
        }
    }

    public void UpdateItem(string oldItemName, string newItemName)
    {
        if (string.IsNullOrEmpty(oldItemName) || string.IsNullOrEmpty(newItemName))
            return;

        Item oldItem = itemDatabase.GetItem(oldItemName);
        if (oldItem == null)
            return;

        Item newItem = itemDatabase.GetItem(newItemName);
        if (newItem == null)
            return;

        inventoryUI.UpdateItem(oldItem, newItem);
    }
}
