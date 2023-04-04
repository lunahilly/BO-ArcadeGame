using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update



   public void OnClick()
    {
        Debug.Log("quite");
        Application.Quit();
    }
}





