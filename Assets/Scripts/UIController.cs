using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject gamePage;
    public GameObject menuPage;
    public GameObject gameOverPage;

    private void Start()
    {
        gamePage.SetActive(false);
        menuPage.SetActive(true);
        gameOverPage.SetActive(false);
    }
    public void OnStartClicked()
    {
        gamePage.SetActive(true);
        menuPage.SetActive(false);
        gameOverPage.SetActive(false);
    }
    public void OnMenuClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnRulesClicked()
    {
        gamePage.SetActive(false);
        menuPage.SetActive(false);
        gameOverPage.SetActive(false);
    }

    public void OnGameOver()
    {
        gamePage.SetActive(false);
        menuPage.SetActive(false);
        gameOverPage.SetActive(true);
    }
    public void OnExitClicked()
    {
        Application.Quit();
    }
}
