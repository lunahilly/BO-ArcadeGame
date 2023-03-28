using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class eating : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    public TMP_Text text;
    public bool PowerUp = false;
    public int wait;
    private int ghosts = 4;


    void SetScore()
    {
        text.text = "highscore: " + score;
    }

    private void Update()
    {
        if (ghosts == 0 || score == 1590)
        {
            SceneManager.LoadScene("GameWin");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bolletje"))    // Als de speler tegen een PowerUp botst
        {
            Destroy(collision.transform.gameObject);
            score += 10;
            SetScore();
        }

        if (collision.gameObject.CompareTag("fruit"))    // Als de speler tegen een PowerUp botst
        {
            Destroy(collision.transform.gameObject);
            score += 50;
            SetScore();
        }

        if (collision.gameObject.CompareTag("power-up"))    // Als de speler tegen een PowerUp botst
        {
            Destroy(collision.transform.gameObject);
            score += 50;
            SetScore();
            Debug.Log("Powered up");
            Waiting();
        }

        if (collision.gameObject.CompareTag("ghost"))    // Als de speler tegen een PowerUp botst
        {
            if (PowerUp == true)
            {
                Waiting();
                Destroy(collision.transform.gameObject);
                score += 200;
                SetScore();
                ghosts =- 1;
            }
        }
    }
    public void Waiting()
    {
        StartCoroutine(PowerUpCountdown(wait));
    }
    private IEnumerator PowerUpCountdown(float time)
    {
        PowerUp = true;
        yield return new WaitForSeconds(time);
        PowerUp= false;
    }
}



