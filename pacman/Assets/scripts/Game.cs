using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text text;
    void Start()
    {
        
    }
    void SetScore()
    {
        text.text = "Highscore: " + eating.score;
    }
    // Update is called once per frame
    void Update()
    {
        SetScore();
    }
}
