using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class deathwalts : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] eating eat;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))    // Als de speler tegen een PowerUp botst
        {
            if (eat.PowerUp == false)
            {
                //  Destroy(collision.transform.gameObject);
                SceneManager.LoadScene("GameOver");
            }
        }
    }
        // Vernietig het spelobject
}


//     [SerializeField] Color customColor = new Color(0.4f, 0.9f, 0.7f, 1.0f);
//            var Renderer = GetComponent<Renderer>();
//            Renderer.material.SetColor("_Color", customColor);
