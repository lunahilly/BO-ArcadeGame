using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrayonSong : MonoBehaviour
{
    public eating eat;
    Color colour = new Color32(114, 76, 255, 0);
    [SerializeField] Color customColor = new Color(0.4f, 0.9f, 0.7f, 1.0f);
    void Update()
    {
        if (eat.PowerUp == true)
        {
            var Renderer = GetComponent<Renderer>();
            Color Color = new Color32(0,0,255,1);
            Renderer.material.SetColor("_Color", Color);
        }
        if (eat.PowerUp == false)
        {
            var Renderer = GetComponent<Renderer>();
            Renderer.material.SetColor("_Color", customColor);
        }
    }
}
