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

    int GetRandomItems()
    {
        itemsLength = itemsData.shopItems.Length;
        int itemsBubble = Random.Range(0, itemsLength);

        return itemsBubble;
    }

    Sprite GetItemsImage(int a)
    {
        return itemsData.shopItems[a].gambarItems;
    }

    // public Sprite GetRandomImage(int a)
    // {

    //     int randomBubble = GetRandomBubble();

    //     List<Sprite> randomItems = new List<Sprite>();

    //     for (int i = 0; i <= randomBubble; i++)
    //     {
    //         randomItems.Add(GetRandomItem());
    //     }

    //     // for (int i = 0; i <= randomBubble; i++)
    //     // {
    //     //     GetRandomItems();
    //     // }

    // }
        public Sprite GetRandomImage()
        {
            int randomIndex = Random.Range(0, itemsData.shopItems.Length);

            // Return the sprite at the random index
            return itemsData.shopItems[randomIndex].gambarItems; 
        }
    
}
