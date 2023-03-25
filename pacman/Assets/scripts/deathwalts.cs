using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class deathwalts : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject canvas;
    public GameObject plane;


    private void Start()
    {
        canvas.SetActive(false);
        plane.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))    // Als de speler tegen een PowerUp botst
        {
            Destroy(collision.transform.gameObject);
            System.Threading.Thread.Sleep(1000);
            canvas.SetActive(true);
            plane.SetActive(true);
        }

        // Vernietig het spelobject
    }
}
