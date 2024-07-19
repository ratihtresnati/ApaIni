using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehaviour : MonoBehaviour
{
    public enum NpcState { Spawn, Waiting, Exit }

    NpcState currentState = NpcState.Spawn;

    private NPCSpawner npcSpawner;
    private NPCMove npcMove;
    private DialogManagement dialogManage;

    private NPCCollisionLayer npcCollisionLayer;

    void Start()
    {
        npcSpawner = FindObjectOfType<NPCSpawner>();
        npcMove = FindObjectOfType<NPCMove>();
        dialogManage = FindObjectOfType<DialogManagement>();
        npcCollisionLayer = GetComponent<NPCCollisionLayer>();
    }

    public void Update()
    {
        switch (currentState)
        {
            case NpcState.Spawn:
                SpawnNPC();
                break;
            case NpcState.Waiting:
                Debug.Log("npc is waiting!");
                break;
            case NpcState.Exit:
                ExitNPC();
                if (Input.GetMouseButtonDown(0) && npcSpawner.npcSpawned == false)
                {
                    currentState = NpcState.Spawn;
                }
                break;
        }
    }

    private void SpawnNPC()
    {

        npcSpawner.SpawnNPC();
        npcMove.NpcMove();
        
        if (npcCollisionLayer.TriggerLose())
        {
            dialogManage.StartDialog();
            //SpawnDialog();
        }
    }

    private void ExitNPC()
    {
        Debug.Log("NPC has exited.");
        npcMove.move = true; 
        npcSpawner.RespawnNPC(2);
    }

    void SpawnDialog()
    {
        GameObject container = GameObject.Find("Container");
        GameObject container1 = GameObject.Find("Popi");

        Instantiate(container, container1.transform);
    }
}
