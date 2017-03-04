using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { MAIN_MENU, GAME}

public delegate void OnStateChangeHandler();

public class GameManager : MonoBehaviour
{
    protected GameManager() {}
    public event OnStateChangeHandler OnStateChange;
    public GameState gameState { get; private set; }

    public GameManager Instance
    {
        get
        {
            return this;
        }
    }

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void SetGameState(GameState state)
    {
        this.gameState = state;
        OnStateChange();
    }

    public void OnApplicationQuit()
    {
        
    }
}
