using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameplay;
    public GameObject pause;
    public GameObject Quit;
    public void EnableMainMenu()
    {
        DisableAllMenus();
        mainMenu.SetActive(true);
        Quit.SetActive(true);
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

    public void DisableAllMenus()
    {
        mainMenu.SetActive(false);
        gameplay.SetActive(false);
        pause.SetActive(false);
        Quit.SetActive(false);
        
    }
    public void QuitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = !EditorApplication.isPlaying;
    }
}
