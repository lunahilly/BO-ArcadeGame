using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacmantango : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.W)) {    
            transform.rotation = Quaternion.Euler(-90,0,-90);  
        }  
        if (Input.GetKey (KeyCode.S)) {  
            transform.rotation = Quaternion.Euler(90,0,-90);    
        }  
        if (Input.GetKey (KeyCode.D)) {   
            transform.rotation = Quaternion.Euler(0,90,0);     
        }  
        if (Input.GetKey (KeyCode.A)) {  
            transform.rotation = Quaternion.Euler(0,-90,0);      
        } 


        if (Input.GetKey (KeyCode.UpArrow)) {  
            transform.rotation = Quaternion.Euler(-90,0,90);  
            
        }  
        if (Input.GetKey (KeyCode.DownArrow)) {  
            transform.rotation = Quaternion.Euler(90,0,90);  
        }
        if (Input.GetKey (KeyCode.RightArrow)) {    
            transform.rotation = Quaternion.Euler(0,90,0);    
        }
        if (Input.GetKey (KeyCode.LeftArrow)) { 
            transform.rotation = Quaternion.Euler(0,-90,0);  
        }  
        
    }
}