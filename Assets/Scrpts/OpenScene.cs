using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    public int id;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(id);
    }
}
