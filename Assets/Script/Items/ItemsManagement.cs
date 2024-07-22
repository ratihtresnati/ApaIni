using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemsManagement : MonoBehaviour
{

    private List<GameObject> clones = new List<GameObject>();
    [SerializeField] private GameObject items;

    public int currentMoney;
    public ScriptableItems itemsData;
    public TextMeshProUGUI textNamaItems, textHargaItems ;
    public Image gambar;
    
    private int currentIndex = 0;
    [SerializeField] private int selectedIndex;

    private int itemsLength;
    private int randomIndex;

     [SerializeField] private int jumlahItems = 2;

    private RandomItems randomItem;



    void Update()
    {
        ShowItems(selectedIndex);

        int a = itemsData.shopItems[currentIndex].Quantity;

        //Debug.Log(a + "quantity sript");

        int b = jumlahItems;

        //Debug.Log(b + "quantity itemsManage");


       /// if ()
    }

    void ShowItems(int currentIndex)
    {
        if (gambar != null)
        {
            gambar.sprite = itemsData.shopItems[currentIndex].gambarItems;
        }

        if (textNamaItems != null && textHargaItems != null )
        {
            textNamaItems.text = itemsData.shopItems[currentIndex].namaItems;
            textHargaItems.text = itemsData.shopItems[currentIndex].hargaItems.ToString("N0"); 
        }

        itemsData.shopItems[currentIndex].Quantity = jumlahItems;
    }

    int GetRandomBubble()
    {
        int randomItems = Random.Range(0, 3);

        return randomItems;
    }

    public int GetIndeexSprie()
    {
        return randomIndex;
    }

    public RandomItems GetRandomImage()
    {
        int randomIndex = Random.Range(0, itemsData.shopItems.Length);
        Sprite randomImage = itemsData.shopItems[randomIndex].gambarItems;

        randomItem = new RandomItems() { Sprite = randomImage, RandomIndex = randomIndex };
            
        return randomItem;
    }

    // int GetHargaItems()
    // {
    //     return itemsData.shopItems[selectedIndex].hargaItems;
    // }

    //uang tambah di shop
    // public int GetHargaItems(int currentIndex)
    // {
    //     this.currentIndex = currentIndex;
    //     return itemsData.shopItems[currentIndex].hargaItems;
    // }

    private void UpdateHargaItems(int a)
    {
        textHargaItems.text = a.ToString("N0");
    }

    //uang di drag
    public int HargaItems(int items)
    {
        float persen = 1.3f;

        float a = itemsData.shopItems[items].hargaItems;

        float total = a * persen;

        //int a = itemsData.shopItems[items].hargaItems * (int)persen;
        return (int)total;

        //return itemsData.shopItems[items].hargaItems;
    }

    public int HargaItemsBeli(int items)
    {
        return itemsData.shopItems[items].hargaItems;
    }

    public void BeliItems()
    {
        MoneyManagement mm = FindObjectOfType<MoneyManagement>();
        mm.UangBerkurang(selectedIndex);

        Debug.Log("ad");

        // return a;
    }
    
    public void TambahHarga()
    {
        int b = HargaItems(selectedIndex);

        int total = b + b;

        UpdateHargaItems(total);
        Debug.Log(total);
    }

    public int GetJumlahItems(int a)
    {
        return itemsData.shopItems[a].Quantity;
    }

    private void UpdateJumlahItems(int a)
    {
        itemsData.shopItems[currentIndex].Quantity = a;
    }
    
    // public void ItemsBerkurang(int a)
    // {
    //     jumlahItems -= jumlahItems;
    // }

    public void QuantityBerkurang()
    {
        int a = GetJumlahItems(selectedIndex);

        // Debug.Log(a);

        int total = a - 1;

        UpdateJumlahItems(total);
        
        Debug.Log(total);
    }

    public int GetQuantity()
    {
        return jumlahItems;
    }

    // public int HasilTambahan()
    // {
    //     return TambahHarga(selectedIndex);
    // }

    

    public void HapusItems()
    {
        
    }


}




public class RandomItems
{
        public Sprite Sprite { get; set; }
        public int RandomIndex { get; set; }
}
