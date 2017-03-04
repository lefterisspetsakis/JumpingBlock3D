using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameManager GM;
    // LevelManager LM;

    // Use this for initialization
    void Awake()
    {
        GM.OnStateChange += () => Debug.Log("OnStateChange!");
    }

    public void HandleOnStateChange()
    {
        Debug.Log("OnStateChange!");
    }

    // starts game from last save
    public void StartGame()
    {
        GM.SetGameState(GameState.GAME);
        load(1);
    }

    private void load(int level)
    {
        print("Loading level...");
        if (level > 0)
        { SceneManager.LoadScene(level); }
        print("Done");
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
