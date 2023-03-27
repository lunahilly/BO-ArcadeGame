using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class highscore : MonoBehaviour
{
    public TMP_Text text;
    

    eating Eating;
    [SerializeField] GameObject player;

    void Awake()
    {
        Eating = player.GetComponent<eating>(); 
    }
    void SetScore()
    {
        int score = Eating.score;
        text.text = "highscore: " + score;
    }
    private void Update()
    {
        SetScore();
    }
}
