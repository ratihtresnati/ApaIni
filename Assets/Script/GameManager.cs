using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     public static GameManager Instance { get; private set;}

     public Loading loading;

     private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        loading = FindObjectOfType<Loading>();
    }

    public static void ChangeScene(string scene)
    {
        Instance.loading.LoadScene(scene);   
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
