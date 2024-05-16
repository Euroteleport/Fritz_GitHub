using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject gameOverUi;
    public static gameManager instance;
    
    
    public void Awake()
    {
        instance = this;

    }
    
    public void OnPlayerDeath()
    {
        gameOverUi.SetActive(true);
    }

    public void Revivre()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      gameOverUi.SetActive(false);
    }

    public void MenuPrincipal()
    {
        
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
