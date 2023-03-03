using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] [Range(0f,5f)] float speed = 1f;
    
    void Start()
    {
        StartCoroutine(FollowPath());       
    }

    IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path) 
        {
            Vector3 startposition = transform.position;
            Vector3 endposition = waypoint.transform.position;
            float travelPercent = 0f;

            transform.LookAt(endposition);
            
            while(travelPercent < 1f)
            {
                travelPercent += speed * Time.deltaTime;
                transform.position = Vector3.Lerp(startposition, endposition, travelPercent);
                yield return new WaitForEndOfFrame();
            }
        }
        
    }
}