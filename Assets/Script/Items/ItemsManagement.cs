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

    private int jumlahItems;

    private RandomItems randomItem;

    void Start()
    {
        ShowItems(selectedIndex);
        
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

        jumlahItems = itemsData.shopItems[currentIndex].Quantity;
    }

    private void UpdateHargaItems(int a)
    {
        textHargaItems.text = a.ToString("N0");
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

    //uang di drag
    public int HargaItems(int items)
    {
        return itemsData.shopItems[items].hargaItems;
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

    public void ItemsBerkurang()
    {
        
    }

    public void TambahHarga()
    {
        int b = HargaItems(selectedIndex);

        int total = b + b;

        UpdateHargaItems(total);
        Debug.Log(total);

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
