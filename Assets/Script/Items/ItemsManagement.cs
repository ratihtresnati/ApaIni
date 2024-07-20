using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemsManagement : MonoBehaviour
{
    public int currentMoney;
    public ScriptableItems itemsData;
    public TextMeshProUGUI textNamaItems, textHargaItems ;
    public Image gambar;
    
    private int currentIndex = 0;
    private int selectedIndex = 0;

    private int itemsLength;
    private int randomIndex;

    private RandomItems randomItem;

    void Update()
    {
        selectedIndex = itemsData.selectedIndex;
        currentIndex = selectedIndex;

        if (gambar != null)
        {
            gambar.sprite = itemsData.shopItems[currentIndex].gambarItems;
        }

        if (textNamaItems != null && textHargaItems != null )
        {
            textNamaItems.text = itemsData.shopItems[currentIndex].namaItems;
            textHargaItems.text = itemsData.shopItems[currentIndex].hargaItems.ToString("N0");  
        }
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

    public int HargaItems(int items)
    {
        return itemsData.shopItems[currentIndex].hargaItems;
    }

    public void HapusItems()
    {
        
    }


}


public class RandomItems
{
        public Sprite Sprite { get; set; }
        public int RandomIndex { get; set; }
}
