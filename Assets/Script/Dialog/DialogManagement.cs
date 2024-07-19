using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManagement : MonoBehaviour
{
    private List<GameObject> clones = new List<GameObject>();

    [SerializeField] private ItemsManagement itemsManage;
    private int itemsLength;
    [SerializeField] private bool dialog;

    [SerializeField] private GameObject items;
    [SerializeField] private Image gambarItems;
    [SerializeField] private GameObject container;
    [SerializeField] private GameObject clone;

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
            gambarItems.sprite = itemsManage.GetRandomImage();
            //itemsManage.GetRandomItems();

            RandomItems();
            
        }
    }

    void RandomItems()
    {
        int randomItems = Random.Range(0, 3);

        switch (randomItems)
        {
            case 0:
                break;
            case 1:
                clone = Instantiate(items, container.transform);
                clones.Add(clone);
                break;
            case 2:
                Clone();
                break;
        }

        Debug.Log(randomItems);

        dialog = true;
    }

    void Clone()
    {
        for (int i = 0; i < 2; i++)
            {
                GameObject clone1 = Instantiate(items, container.transform);
                clones.Add(clone1);
            }
    }

    public void Reset()
    {
        foreach (GameObject clone in clones)
        {
            Destroy(clone);
        }
        
        clones.Clear();
        container.SetActive(false);
        dialog = false;
    }
}
