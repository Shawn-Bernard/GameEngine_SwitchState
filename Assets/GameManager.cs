using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager Instance;
    public UIManager UImanager;

    // Start is called before the first frame update
    private void OnEnable()
    {
        UImanager = FindObjectOfType<UIManager>();
    }
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
