using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    GameManager GM;

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
        Debug.Log(GM.gameState);
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
