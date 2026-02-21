using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;

    public void Hide()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Show()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}