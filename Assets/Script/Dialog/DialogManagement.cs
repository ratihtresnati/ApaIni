using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManagement : MonoBehaviour
{
    private List<GameObject> clones = new List<GameObject>();

    [SerializeField] private ItemsManagement itemsManage;
    private int itemsLength;
    [SerializeField] public bool dialog;

    [SerializeField] private GameObject items;
    [SerializeField] private Image gambarItems;
    [SerializeField] private GameObject container;
    [SerializeField] private GameObject clone;

    private int randomItems;
    public int  a, b;

    private Player1Controller playerController; 

    void Start()
    {
        itemsManage = FindObjectOfType<ItemsManagement>();

        gambarItems = items.GetComponent<Image>();

        playerController = FindObjectOfType<Player1Controller>();

        container.transform.position = playerController.getPoint();
    }

    public void StartDialog()
    {
        
        if (dialog == false)
        {
            container.SetActive(true);

            RandomItems();
            
        }
    }

    void RandomItemsPertama()
    {
        RandomItems randomImage = itemsManage.GetRandomImage();

        gambarItems.sprite = randomImage.Sprite;
        b = randomImage.RandomIndex;
        Debug.Log("haloo"+b +1);
    }

    void RandomItems()
    {
        randomItems = Random.Range(0, 2);

        switch (randomItems)
        {
            case 0:
                RandomItemsPertama();
                ImageClone();
                break;
            case 1:
                RandomItemsPertama();
                clone = Instantiate(items.gameObject, container.transform);
                clones.Add(clone);
                ImageClone();
                break;
            case 2:
                RandomItemsPertama();
                Clone();
                //ImageClone();
                break;
        }

        Debug.Log("berapa bubble" + randomItems);

        dialog = true;
    }

    void Clone()
    {
        for (int i = 0; i < 2; i++)
        {
            GameObject clone = Instantiate(items.gameObject, container.transform);
            clones.Add(clone);
        }
        ImageClone();
    }

    public void ImageClone()
    {
        RandomItems randomImage = itemsManage.GetRandomImage();

        foreach (GameObject clone in clones)
        {
            Image image = clone.GetComponent<Image>();

            image.sprite = randomImage.Sprite;
            a = randomImage.RandomIndex;
            Debug.Log("hry"+ a);
        }
    }

    public bool reset = false;


    public void Reset()
    {
        if(!reset)
        {
            return;
        }
        
        foreach (GameObject clone in clones)
        {
            Destroy(clone);
        }
        
        clones.Clear();
        container.SetActive(false);
        dialog = true;        
        reset = false;
        Debug.Log("reset");
    }

    public void GetIndeexSprie()
    {
        
        int b = itemsManage.GetIndeexSprie();
        
        Debug.Log("dialog manager" + b);
    }
}
