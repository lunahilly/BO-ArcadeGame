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
        
        // Vernietig het spelobject
    }
}

