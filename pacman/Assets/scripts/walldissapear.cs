using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class walldissapear : MonoBehaviour
{
    // Start is called before the first frame update
    public eating eat;
    public GameObject wall; 
    public string SceneName;
    public int PuntenNodig;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (eat.ghosts == 0 || eating.score == PuntenNodig || eating.score > PuntenNodig)
        {
            wall.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wally"))    // Als de speler tegen een PowerUp botst
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
