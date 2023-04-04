using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading;
using Unity.VisualScripting;

public class eating : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score = 0;
    public TMP_Text text;
    public TMP_Text Countdown;
    public GameObject canvas;
    public bool PowerUp = false;
    public int wait;
    public int ghosts = 4;
    float timer;
    

    
    void SetScore()
    {
        text.text = "Highscore: " + eating.score;
    }
    void SetTime()
    {
        Countdown.text = "Time Left: " + timer + " seconds";
    }
    private void Start()
    {
        canvas.SetActive(false);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bolletje"))    // Als de speler tegen een PowerUp botst
        {
            Destroy(collision.transform.gameObject);
            eating.score += 10;
            SetScore();
        }

        if (collision.gameObject.CompareTag("fruit"))    // Als de speler tegen een PowerUp botst
        {
            Destroy(collision.transform.gameObject);
            eating.score += 50;
            SetScore();
        }

        if (collision.gameObject.CompareTag("power-up"))    // Als de speler tegen een PowerUp botst
        {
            Destroy(collision.transform.gameObject);
            eating.score += 50;
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
                eating.score += 200;
                SetScore();
                ghosts =- 1;
            }
            if (PowerUp == false)
            { 
                Destroy(gameObject);
            }
        }
    }
    public void Waiting()
    {
        StartCoroutine(PowerUpCountdown(wait));
    }
    private IEnumerator PowerUpCountdown(float time)
    {
        timer = time;
        canvas.SetActive(true);
        PowerUp = true;
        while (timer > 0 || timer == 0)
        {
            Countdown.text = "Time Left: " + timer + " seconds";
            Debug.Log(timer);
            yield return new WaitForSeconds(1.0f);
            timer--;
        }
        PowerUp= false;
        canvas.SetActive(false);


    }
}



