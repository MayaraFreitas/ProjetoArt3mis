using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftController : MonoBehaviour
{
    public List<Recip> recips;

    [Serializable]
    public class Recip
    {
        public string name;
        public List<RecipItem> requestItems;
        public UIItem resultItem;
    }

    [Serializable]
    public class RecipItem
    {
        public UIItem item;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
