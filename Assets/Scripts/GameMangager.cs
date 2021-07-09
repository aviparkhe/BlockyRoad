using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMangager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");

            // Restart game
            Invoke("RestartGame", restartDelay);
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
