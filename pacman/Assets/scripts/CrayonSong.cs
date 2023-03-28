using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrayonSong : MonoBehaviour
{
    public eating eat;
    public Material material;
    void Update()
    {
        if (eat.PowerUp == true)
        {
            Debug.Log("poweruped");
            //GameObject.FindGameObjectsWithTag("ghost").GetComponent<Renderer>().material.color = new Color(0, 204, 102);
            //gameObject.GetComponent<Renderer>().material.color = Color.blue;
            material.color = Color.blue;

        }
    }
}
