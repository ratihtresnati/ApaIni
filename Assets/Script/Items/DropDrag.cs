using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropDrag : MonoBehaviour
{
    Vector3 offset;
    Vector3 firstPosition;
    CapsuleCollider2D  collider2D;
    private string dropTag = "pesan";

    

    void awake()
    {
        collider2D = gameObject.GetComponent<CapsuleCollider2D>();
    }

    void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        firstPosition = transform.position;
    }   

    string transformTag;

    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;

        transformTag = transform.tag;

       // Debug.Log(transformTag);
    }

    void OnMouseUp()
    {

        DialogManagement dm = FindObjectOfType<DialogManagement>();
        MoneyManagement mn = FindObjectOfType<MoneyManagement>();

        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit2D hitInfo;

        string b = dm.b.ToString();
        string a = dm.a.ToString();
        
        bool checkTransformA = transformTag == a;
        bool checkTransformB = transformTag == b;
        
        if (hitInfo = Physics2D.Raycast(rayOrigin, rayDirection))
         {
            if (hitInfo.transform.tag == dropTag && (checkTransformA || checkTransformB))
            {
                int c = mn.UangBertambah(checkTransformA ? dm.a : dm.b); 
                mn.Bertambah(c);
                // dm.dialog = true;
                dm.reset = true;
                // dm.Reset();
                transform.position = SavePosition();
                Debug.Log(c);
                Debug.Log(c + (checkTransformA ? "a" : "b"));
            }
            else
            {
                Debug.Log("gak jadi");
                transform.position = SavePosition();
            }
        }
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }

    Vector3 SavePosition()
    {
        return firstPosition;
    }

    // bool Check()
    // {
        
    //    DialogManagement dm = GetComponent<DialogManagement>();

    //     if (dm.a.ToString == transformTag)
    //     {
    //         true;
    //     }
    //     return false;

    // }
}
