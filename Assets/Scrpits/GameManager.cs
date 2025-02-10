using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager Instance;
    //Throwing in my UI manager script so I can have access to the methods
    public UIManager UImanager;

    void Start()
    {
        
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            //Doesn't destroy when new scene is loaded
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }

}
