using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostfloss : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;
    public int wait;
    [SerializeField] float speed = 1f;
    private bool yes = true;
    

    void Update()
    {
        

        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < 0.2f)
        {
            
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 1;
            }
        }

        if (yes == true)
        {
            System.Threading.Thread.Sleep(wait);
            yes = false;
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
