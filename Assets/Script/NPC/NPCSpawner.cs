using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public GameObject npcPrefab; 
    public Transform spawnPoint; 

    private GameObject NPC;
    private NPCMove npcMove;

    public bool npcSpawned;

    private DialogManagement dialogManage;

    void Start()
    {
        npcMove = FindObjectOfType<NPCMove>();
        dialogManage = FindObjectOfType<DialogManagement>();
    }

    //spawn npc
    public void SpawnNPC()
    {
        if (npcSpawned)
        {
            NPC = Instantiate(npcPrefab, spawnPoint.position, spawnPoint.rotation);
            Debug.Log("hai");
            npcSpawned = true;
        }
    }

    // respawn npc
    public void RespawnNPC()
    {
        transform.position = spawnPoint.position; 
        transform.rotation = spawnPoint.rotation;
        npcSpawned = false;
        
            npcMove.move = false;
            dialogManage.dialog = false;
    }

    public void RespawnNPC(float delayTime) 
    {
        //tunggu dulu sebelum respawn
        Invoke("RespawnNPC", delayTime);
    }


}
