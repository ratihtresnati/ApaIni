using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCollisionLayer : MonoBehaviour
{
    [SerializeField] public LayerMask loseLayer; 
    [SerializeField] public float loseDistance = 1f; 

    public string dropTag = "pesan";


    public bool TriggerLose()
    {
        //tertriiger
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, loseDistance, loseLayer);
        return hit.collider != null;
    }

    // public bool TriggerItems()
    // {
    //     return 
    // }
}
