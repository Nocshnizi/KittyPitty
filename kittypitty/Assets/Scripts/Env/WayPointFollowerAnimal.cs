using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollowerAnimal : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoint;
    private int currentWaypointIndex = 0;
    [SerializeField] private float speed = 2f;

    private void FixedUpdate()
    {

        if (Vector2.Distance(wayPoint[currentWaypointIndex].transform.position, transform.position) < .1f) {
            Debug.Log("FLIP");
            Flip();
            currentWaypointIndex++;
            
            if (currentWaypointIndex >= wayPoint.Length) {
                
                currentWaypointIndex = 0;
                
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoint[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }

    private void Flip() {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}
