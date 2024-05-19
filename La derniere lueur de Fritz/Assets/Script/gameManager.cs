using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUi;
    public static GameManager instance;
    
    
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
