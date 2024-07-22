using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemsShop", menuName = "Scriptable/ItemsData")]
public class ScriptableItems : ScriptableObject
{
    public int selectedIndex;
    public Items[] shopItems;
}

[System.Serializable]
public class Items
{
    public string namaItems;
    public string deskripsiItems;
    public int hargaItems;
    public Sprite gambarItems;
    public int Quantity = 2;
}
