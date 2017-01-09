using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    private Transform target;
    private int playerDistance = 10;

    public float cameraSnapTime;
    private float snapTimeElapsed;

    void Start()
    {
    }

    public void SnapToTarget(Transform newTarget)
    {
        target = newTarget;
        snapTimeElapsed = 0f;
    }

    void LateUpdate()
    {

        // Early out if we don't have a target
        if (!target) return;

        float percentDone = snapTimeElapsed / cameraSnapTime;
        transform.position = Vector3.Lerp(transform.position,
                                          target.position - (transform.forward * playerDistance),
                                          percentDone);
        snapTimeElapsed += Time.deltaTime;

        if(percentDone > 1)
        {
            target = null;
        }
    }
}
