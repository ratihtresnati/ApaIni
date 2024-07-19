using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMove : MonoBehaviour
{
    public Transform targetPoint;
    public Transform targetPoint2;

    public float moveSpeed = 2f;

    public bool move = false;

    private bool firstPosition;

    void Start()
    {
        firstPosition = transform.position == targetPoint.position;
    }

    public void NpcMove()
    {
        if (move == false)
        {
            //npc ke meja
            Vector3 direction = targetPoint.position - transform.position;
            direction.y = 0f; 
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else
        {
            //npc pergi 
            Vector3 direction = targetPoint2.position - transform.position;
            direction.y = 0f; 

            transform.position += direction * moveSpeed * Time.deltaTime;
            move = false;
        }
    }

    
}

