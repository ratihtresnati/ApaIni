using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    // [SerializeField] private GameObject moveContainer;

    // public void Show()
    // {
    //     moveContainer
    // }

    // Posisi awal dan akhir InventoryPanel
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 endPosition;

    public bool isClosing, isOpening;

    public Animator animator;

    // Kecepatan geser
    private float scrollSpeed = 5.0f;

    // Referensi ke tombol
    public GameObject openCloseButton;
    public GameObject Container;

    private  float width;

    void Start() {

        animator = GetComponent<Animator>();

    
    //width = Container.GetComponent<RectTransform>().rect.width;

        // Inisialisasi variabel inventory
        // ...

        // Atur posisi awal InventoryPanel
        //startPosition = Container.transform.position;
        //endPosition = new Vector3(startPosition.x - Container.width, startPosition.y, startPosition.z);
    }

    void Update() {
        // Geser InventoryPanel jika sedang dibuka/ditutup
        // if (isOpening || isClosing) {
        //     float t = Time.deltaTime * scrollSpeed;
        //     Container.transform.position = Vector3.Lerp(startPosition, endPosition, t);

        //     if (isOpening && Vector3.Distance(Container.transform.position, endPosition) < 0.01f) {
        //         isOpening = false;
        //     } else if (isClosing && Vector3.Distance(Container.transform.position, startPosition) < 0.01f) {
        //         isClosing = false;
        //     }
        // }
    }

    public void OpenInventory() 
    {
        //gameObject.RectTransform = startPosition;
        
        // if (!isOpening && !isClosing) {
        //     isOpening = true;
            //animator.SetBool("isOpening", true);
            // isClosing = false;
            // Debug.Log(isClosing);
        
    }

    public void CloseInventory() 
    {
        //gameObject.RectTransform = endPosition;
        
        // if (!isOpening && !isClosing) {
        //     isClosing = true;
            //animator.SetBool("isOpening", false);
        //     isOpening = false;
        //     Debug.Log(isOpening);
        
    }
}
