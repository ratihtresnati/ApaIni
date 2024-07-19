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

    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }

    void OnMouseUp()
    {
    //  collider2D.enabled = false;
        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit2D hitInfo;


        if (hitInfo = Physics2D.Raycast(rayOrigin, rayDirection))
        {
            Debug.Log("Hit something! " + hitInfo.collider.name);
            if (hitInfo.transform.tag == dropTag)
            {
                Debug.Log("pesan");
            }
            else
            {
                Debug.Log("gak jadi");
                transform.position = SavePosition();
            }
        }
        // collider2D.enabled = true;
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
}
