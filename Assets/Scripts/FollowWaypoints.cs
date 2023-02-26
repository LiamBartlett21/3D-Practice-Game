using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour
{
    [SerializeField] GameObject[] waypnts;
    int cWaypointIndex = 0;

    [SerializeField] float speed = 1f;

    void Update()
    {
        if (Vector3.Distance(transform.position, waypnts[cWaypointIndex].transform.position) < .1f)
        {
            cWaypointIndex++;
            if (cWaypointIndex >= waypnts.Length)
            {
                cWaypointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypnts[cWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
