using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinky : MonoBehaviour
{
    public eating eat;
    public Material material;
    public int wait;
    [SerializeField] Color customColor = new Color32(255, 184, 82, 1);
    void Update()
    {
        if (eat.PowerUp == true)
        {
            var Renderer = GetComponent<Renderer>();
            Color Color = new Color32(0, 0, 255, 1);
            Renderer.material.SetColor("_Color", Color);
            Debug.Log("power");
        }
        if (eat.PowerUp == false)
        {
            var Renderer = GetComponent<Renderer>();
            Renderer.material.SetColor("_Color", customColor);
        }
    }
    public void Waiting()
    {
        StartCoroutine(PowerUpCountdown(wait));
    }
    private IEnumerator PowerUpCountdown(float time)
    {
        material.color = Color.blue;
        yield return new WaitForSeconds(time);
    }

//public void test()
  //  {
  //     // var Renderer = GetComponent<Renderer>();

        // Create a new RGBA color using the Color constructor and store it in a variable
        //Color customColor = new Color32(12, 100, 230, 231);

        // Call SetColor using the shader property name "_Color" and setting the color to the custom color you created
       // Renderer.material.SetColor("_Color", customColor);
   // }
}
