using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuantityItems : MonoBehaviour
{
    private ItemsManagement itemsManage;

    private int Quantity;

    void Start()
    {
        itemsManage = gameObject.GetComponent<ItemsManagement>();
    }

    public void QuantityBerkurang()
    {
        //itemsManage.TambahHarga();
        //int a = itemsManage.GetHargaItems();
        //itemsManage.TambahItems1();
        // itemsManage.HargaTambah();
        //int a = itemsManage.HasilTambahan();

        int a = itemsManage.GetQuantity();

        if(a == 0)
        {
            Debug.Log("udh habis");
        }
    }
    
}
