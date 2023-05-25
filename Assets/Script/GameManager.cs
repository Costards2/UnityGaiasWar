using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    bool gameHasEnded = false;
    public float restartDelay = 0.5f;
    //public GameObject winnerTerra;
    //public GameObject winnerMarte;

    public void EndGame()
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //Restart();
            //Invoke("Restart", restartDelay);
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    //void Restart ()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
}
