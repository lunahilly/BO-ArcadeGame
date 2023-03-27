using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrayonSong : MonoBehaviour
{

    public Material material;
    public eating eat;
    public Renderer rb;
    void Update()
    {
        if (eat.PowerUp == true)
        {
            //GameObject.FindGameObjectsWithTag("ghost").GetComponent<Renderer>().material.color = new Color(0, 204, 102);
    
        }
    }
}
