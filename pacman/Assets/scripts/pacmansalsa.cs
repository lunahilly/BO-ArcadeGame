using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacmansalsa : MonoBehaviour
{
    // Start is called before the first frame update
<<<<<<< HEAD
=======
    void Start()
    {
        
    }

>>>>>>> f9c1c166c3d28aa78cf2866bd1ffc255aa96d7bc
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.W)) {  
<<<<<<< HEAD
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
=======
            transform.Translate (0f, 0.01f, 0f);      
        }  
        if (Input.GetKey (KeyCode.S)) {  
            transform.Translate (0f, -0.01f, 0f);      
        }  
        if (Input.GetKey (KeyCode.D)) {  
            transform.Translate (0f, 0f, 0.01f);       
        }  
        if (Input.GetKey (KeyCode.A)) {  
            transform.Translate (0f, 0f, -0.01f);     
>>>>>>> f9c1c166c3d28aa78cf2866bd1ffc255aa96d7bc
        } 


        if (Input.GetKey (KeyCode.UpArrow)) {  
<<<<<<< HEAD
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
        
=======
            transform.Translate (0f, 0.01f, 0f);      
        }  
        if (Input.GetKey (KeyCode.DownArrow)) {  
            transform.Translate (0f, -0.01f, 0f);      
        }
        if (Input.GetKey (KeyCode.RightArrow)) {  
            transform.Translate (0, 0f, 0.01f);       
        }
        if (Input.GetKey (KeyCode.LeftArrow)) {  
            transform.Translate (0f, 0f, -0.01f);     
        }  
>>>>>>> f9c1c166c3d28aa78cf2866bd1ffc255aa96d7bc
    }
}
