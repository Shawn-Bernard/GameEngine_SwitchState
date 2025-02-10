using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameplay;
    public GameObject pause;
    public void EnableMainMenu()
    {
        DisableAllMenus();
        //This will show my main menu canvas and so on
        mainMenu.SetActive(true);
        Debug.Log("Im main menu");
    }
    public void EnableGameplay()
    {
        DisableAllMenus();
        gameplay.SetActive(true);
        Debug.Log("Im gameplay menu");
    }
    public void EnablePause()
    {
        DisableAllMenus();
        pause.SetActive(true);
        Debug.Log("Im pause menu");
    }
    public void QuitGame()
    {
        Application.Quit();
        //This will take you outta play mode also = to false works, I googled it and got this
        //EditorApplication.isPlaying = !EditorApplication.isPlaying;
        //PS unity doesn't like this when trying to build :C
    }

    //making a method to disable all my games object so I'm only have to do it once 
    public void DisableAllMenus()
    {
        mainMenu.SetActive(false);
        gameplay.SetActive(false);
        pause.SetActive(false);
        
    }
    
}
