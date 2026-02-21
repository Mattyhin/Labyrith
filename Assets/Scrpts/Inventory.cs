using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int keys = 0;
    public int coins = 0;
    
    public AudioSource audioCoin;
    public AudioSource audioDestroy;
    
    public TextMeshProUGUI scoreText;

    private void OnDestroy()
    {
        if (audioDestroy != null)
        {
            audioDestroy.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coins += 1;
            Destroy(collision.gameObject);
            if (audioCoin != null)
            {
                audioCoin.Play();
            }
            scoreText.text = coins.ToString();
        }

        if (collision.gameObject.CompareTag("Crystal"))
        {
            coins += 3;
            Destroy(collision.gameObject);
            if (audioCoin != null)
            {
                audioCoin.Play();
            }
            scoreText.text = coins.ToString();
        }

        if (collision.gameObject.CompareTag("Key"))
        {
            keys = keys + 1;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Door"))
        {
           if(keys > 0)
            {
                Destroy(collision.gameObject);
                keys = keys - 1;
            }
        }
    }
}