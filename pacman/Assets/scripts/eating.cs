using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class eating : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    public TMP_Text text;
    public bool PowerUp = false;




    void SetScore()
    {
        text.text = "highscore: " + score;
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
            PowerUpCountdown();
        }

        if (collision.gameObject.CompareTag("ghost"))    // Als de speler tegen een PowerUp botst
        {
            if (PowerUp == true)
            {
                //Destroy(collision.transform.gameObject);
                score += 200;
                SetScore();
            }
            
        }
        // Vernietig het spelobject
    }
    private IEnumerator PowerUpCountdown()
    {
        yield return new WaitForSeconds(20.0f);
        PowerUp= true;
        
    }


    
}



