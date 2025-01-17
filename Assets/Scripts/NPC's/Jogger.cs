using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jogger : MonoBehaviour
{
    public SpawnJogger spawner;

    [Header("Jogger")]

    [SerializeField] private Transform waypoint;

    [SerializeField] private float distanceToWaypoint;
    [SerializeField] private float speed;


    private void Start()
    {
        waypoint = GameObject.Find("Jogger Waypoint").GetComponent<Transform>();
        spawner = GameObject.Find("Jogger Spawner").GetComponent<SpawnJogger>();
    }


    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoint.position, speed * Time.deltaTime);
    

        distanceToWaypoint = Vector3.Distance(transform.position, waypoint.position);

        if(distanceToWaypoint < 1)
        {
            spawner.joggerIndex --;


            Destroy(gameObject);
        }
    }
}
