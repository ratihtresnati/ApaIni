using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuantityItems : MonoBehaviour
{
    private ItemsManagement itemsManage;

    void Start()
    {
        itemsManage = FindObjectOfType<ItemsManagement>();
    }

    public void Tambah()
    {
        itemsManage.TambahHarga();
        //int a = itemsManage.GetHargaItems();
        //itemsManage.TambahItems1();
        // itemsManage.HargaTambah();
        //int a = itemsManage.HasilTambahan();
        
        Debug.Log("fak");
    }
    
}
