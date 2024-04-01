using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] bool chasing;
    [SerializeField] GameObject[] waypoints;
    [SerializeField] int waypointNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chasing)
        {
            float newPositX = Mathf.MoveTowards(transform.position.x, waypoints[waypointNum].transform.position.x, 0.1f);
            float newPositY = Mathf.MoveTowards(transform.position.y, waypoints[waypointNum].transform.position.y, 0.1f);
            float newPositZ = Mathf.MoveTowards(transform.position.z, waypoints[waypointNum].transform.position.z, 0.1f);

            transform.position = new Vector3(newPositX, newPositY, newPositZ);
        }

        else
        {
            transform.Translate(-transform.right * Time.deltaTime * 35, Space.World);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Waypoint")
        {
            waypointNum++;

            if (waypointNum >= waypoints.Length)
            {
                waypointNum = 0;
            }
        }
    }
}
