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
    public GameObject clyde;
    public GameObject pinky;
    public GameObject inky;
    public GameObject blinky;
    public GameObject hinky;
    public int powerdown;
    
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
        clyde.SetActive(false);
        inky.SetActive(false);
        pinky.SetActive(false);
        blinky.SetActive(false);
        hinky.SetActive(false);
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

        if (collision.gameObject.CompareTag("blinky"))    // Als de speler tegen een PowerUp botst
        {
            if (PowerUp == true)
            {
                Destroy(GameObject.FindWithTag("blinky"));
                blinky.SetActive(true);
                eating.score += 200;
                SetScore();
                ghosts =- 1;
            }
            if (PowerUp == false)
            { 
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("pinky"))    // Als de speler tegen een PowerUp botst
        {
            if (PowerUp == true)
            {
                Destroy(GameObject.FindWithTag("pinky"));
                pinky.SetActive(true);
                eating.score += 200;
                SetScore();
                ghosts = -1;
            }
            if (PowerUp == false)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("inky"))    // Als de speler tegen een PowerUp botst
        {
            if (PowerUp == true)
            {
                Destroy(GameObject.FindWithTag("inky"));
                inky.SetActive(true);
                eating.score += 200;
                SetScore();
                ghosts = -1;
            }
            if (PowerUp == false)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("clyde"))    // Als de speler tegen een PowerUp botst
        {
            if (PowerUp == true)
            {
                Destroy(GameObject.FindWithTag("clyde"));
                clyde.SetActive(true);
                eating.score += 200;
                SetScore();
                ghosts = -1;
            }
            if (PowerUp == false)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("hinky"))    // Als de speler tegen een PowerUp botst
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.CompareTag("power-down"))    // Als de speler tegen een PowerUp botst
        {
            power();
            Destroy(collision.transform.gameObject);
        }
    }
    public void Waiting()
    {
        StartCoroutine(PowerUpCountdown(wait));
    }
    public void power()
    {
        StartCoroutine(PowerDown(powerdown));
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
    private IEnumerator PowerDown(float time) 
    {
        hinky.SetActive(true);
        yield return new WaitForSeconds(time);
        hinky.SetActive(false);
    }
}


//Destroy (GameObject.FindWithTag("gameMenu"));


