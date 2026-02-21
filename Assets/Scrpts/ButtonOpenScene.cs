using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOpenScene : MonoBehaviour
{
    public int id;

    public void OpenScene()
    {
        SceneManager.LoadScene(id);
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
