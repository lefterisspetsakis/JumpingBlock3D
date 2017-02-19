using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    GameManager GM;
    // LevelManager LM;

	// Use this for initialization
	void Awake ()
    {
        GM = GameManager.Instance;
        GM.OnStateChange += HandleOnStateChange;
	}

    public void HandleOnStateChange()
    {
        Debug.Log("OnStateChange!");
    }

    public void OnGUI()
    {
        
    }

    public void ResumeGame()
    {
        GM.SetGameState(GameState.GAME);
        SceneManager.LoadScene("Level1");

        Debug.Log(GM.gameState);
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
