using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovingBetweenPositions : MonoBehaviour
{
    [SerializeField]
    private float travelDurationOne = 1f,
                  travelDurationTwo = 2f,
                  wait = 1f,
                  wait2 = 4f;

    [SerializeField]
    private Vector3 pointA,
                    pointB;

    void Awake()
    {
        StartCoroutine(Timer());
    }

    // Move between points, with timer
    private IEnumerator Timer()
    {
        // Loop 
        while (Application.isPlaying)
        {
            //Travel from A to B
            float speed = 0f;
            while (speed < travelDurationOne)
            {
                transform.position = Vector3.Lerp(pointA, pointB, speed / travelDurationOne);
                speed += Time.deltaTime;
                yield return null;
            }

            // In case the counter isn't equal to the travelDuration
            transform.position = pointB;

            // wait
            yield return new WaitForSeconds(wait);

            //Travel back from B to A
            float speed2 = 0f;
            while (speed2 < travelDurationTwo)
            {
                transform.position = Vector3.Lerp(pointB, pointA, speed2 / travelDurationTwo);
                speed2 += Time.deltaTime;
                yield return null;
            }

            // In case the counter isn't equal to the travelDuration
            transform.position = pointA;

            // Finally, wait
            yield return new WaitForSeconds(wait2);
        }
    }
}
