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
    public Material material;
    public GameObject highscore;
    public GameObject button;
    [SerializeField] eating eat;

    private void Start()
    {
        canvas.SetActive(false);
        plane.SetActive(false);
        button.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))    // Als de speler tegen een PowerUp botst
        {
            if (eat.PowerUp == false)
            {
                //  Destroy(collision.transform.gameObject);
                System.Threading.Thread.Sleep(500);
                canvas.SetActive(true);
                plane.SetActive(true);
                button.SetActive(true);
                highscore.SetActive(false);
                Debug.Log("not powered");
            }
        }
    }
        // Vernietig het spelobject
}


//     [SerializeField] Color customColor = new Color(0.4f, 0.9f, 0.7f, 1.0f);
//            var Renderer = GetComponent<Renderer>();
//            Renderer.material.SetColor("_Color", customColor);
