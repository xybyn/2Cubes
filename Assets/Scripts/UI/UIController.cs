using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject _gamePage;
    [SerializeField]
    private GameObject _menuPage;
    [SerializeField]
    private GameObject _gameOverPage;

    private void Start()
    {
        _gamePage.SetActive(false);
        _menuPage.SetActive(true);
        _gameOverPage.SetActive(false);
    }
    public void OnStartClicked()
    {
        _gamePage.SetActive(true);
        _menuPage.SetActive(false);
        _gameOverPage.SetActive(false);
    }
    public void OnMenuClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnRulesClicked()
    {
        _gamePage.SetActive(false);
        _menuPage.SetActive(false);
        _gameOverPage.SetActive(false);
    }

    public void OnGameOver()
    {
        _gamePage.SetActive(false);
        _menuPage.SetActive(false);
        _gameOverPage.SetActive(true);
    }
    public void OnExitClicked()
    {
        Application.Quit();
    }
}
