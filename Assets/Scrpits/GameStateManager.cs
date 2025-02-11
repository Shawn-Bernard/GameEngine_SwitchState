using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public enum GameState
    {
        MainMenu_State, 
        Gameplay_State, 
        Paused_State
    }
    private GameState gameState;

    private bool isPaused;
    private GameState currentState { get; set; }

    private GameState lastState { get; set; }

    [SerializeField] private string currentStateDebug;
    [SerializeField] private string lastStateDebug;

    //This is where we will change game states 
    public void ChangeState(GameState newState)
    {
        // (Reading only) Holding my last game state, while converting to string
        lastStateDebug = currentState.ToString();

        // Storing my new state in current state
        currentState = newState;
        // Throwing in my new state
        HandleStateChange(newState);

        // (Reading only) Holding my new current state after storing my new state in the current state
        currentStateDebug = currentState.ToString();
    } 

    public void HandleStateChange(GameState state)
    {
        //making a switch case for game states
        switch (state)
        {
            case GameState.MainMenu_State:
                Debug.Log("Switch to menu");
                gameManager.UImanager.EnableMainMenu();
                Time.timeScale = 1;
                isPaused = false;
                //Cursor.visible = true;
                // Logic for state here

                break;
            case GameState.Gameplay_State:
                Debug.Log("Switch to gameplay");
                gameManager.UImanager.EnableGameplay();
                Time.timeScale = 1;
                isPaused = false;
                //Cursor.visible = false;

                // Logic for state here

                break;
            case GameState.Paused_State:
                Debug.Log("Switch to paused");
                gameManager.UImanager.EnablePause();
                Time.timeScale = 0;
                isPaused = true;

                // Logic for state here
                break;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        HandleStateChange(GameState.MainMenu_State);
        //gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //checking if were in the menu and if not, the player is allowed to pause
        if (currentState != GameState.MainMenu_State)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                //If my game is paused then change the state to unpaused
                if (isPaused)
                {
                    ChangeState(GameState.Gameplay_State);
                }
                //If the game isn't paused then pause
                else
                {
                    ChangeState(GameState.Paused_State);
                }
            }
        }
        
    }
    //Changing my game states so it could work with buttons
    public void MainMenu()
    {
        ChangeState(GameState.MainMenu_State);
    }
    public void Gameplay()
    {
        ChangeState(GameState.Gameplay_State);
    }
    public void Pause()
    {
        ChangeState(GameState.Paused_State);
    }
    //this method gets my UI manager script methods from game manager
    public void Quit()
    {
        gameManager.UImanager.QuitGame();
    }
}
