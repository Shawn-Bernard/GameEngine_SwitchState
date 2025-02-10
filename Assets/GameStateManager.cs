using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public enum GameState
    {
        MainMenu_State, 
        Gameplay_State, 
        Paused_State
    }
    private GameState gameState;

    private GameState currentState { get; set; }

    private GameState lastState { get; set; }

    [SerializeField] private string currentStateDebug;
    [SerializeField] private string lastStateDebug;


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
        //Time.timeScale = 0; 
        switch (state)
        {
            case GameState.MainMenu_State:
                Debug.Log("Switch to menu");

                // Logic for state here

                break;
            case GameState.Gameplay_State:
                Debug.Log("Switch to gameplay");

                // Logic for state here

                break;
            case GameState.Paused_State:
                Debug.Log("Switch to paused");

                // Logic for state here
                break;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        HandleStateChange(GameState.MainMenu_State);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            ChangeState(GameState.MainMenu_State);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            ChangeState(GameState.Gameplay_State);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            ChangeState(GameState.Paused_State);
        }
    }
}
