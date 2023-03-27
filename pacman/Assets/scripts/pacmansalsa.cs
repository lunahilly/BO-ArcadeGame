using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacmansalsa : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.W)) {  
            transform.Translate (0f, 0.05f, 0f);      
        }  
        if (Input.GetKey (KeyCode.S)) {  
            transform.Translate (0f, -0.05f, 0f);      
        }  
        if (Input.GetKey (KeyCode.D)) {  
            transform.Translate (0f, 0f, 0.05f);     
   
        }  
        if (Input.GetKey (KeyCode.A)) {  
            transform.Translate (0f, 0f, -0.05f);      
        } 


        if (Input.GetKey (KeyCode.UpArrow)) {  
            transform.Translate (0f, 0.05f, 0f);   
        }  
        if (Input.GetKey (KeyCode.DownArrow)) {  
            transform.Translate (0f, -0.05f, 0f);  
   
        }
        if (Input.GetKey (KeyCode.RightArrow)) {  
            transform.Translate (0.05f, 0f, 0f);     
              
        }
        if (Input.GetKey (KeyCode.LeftArrow)) {  
            transform.Translate (-0.05f, 0f, 0f);  
        }  
        
    }
}
