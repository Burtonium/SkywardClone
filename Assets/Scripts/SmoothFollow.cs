using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    // The target we are following
    private Transform target;
    Camera mainCamera;
    public float cameraAcceleration;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    // Place the script in the Camera-Control group in the component menu
    [AddComponentMenu("Camera-Control/Smooth Follow")]


    void LateUpdate()
    {
        // Early out if we don't have a target
        if (!target) return;

        Vector3 direction = mainCamera.WorldToViewportPoint(target.position);
        Debug.Log("Position: " + direction);

        Vector3 v3 = transform.forward;
        v3.y = 0;
        v3.Normalize();

        Debug.Log("Forward:" + v3);

        //if (v3 != Vector3.zero)
        //{
        //    transform.position += v3 * cameraAcceleration * Time.deltaTime;
        //}
    }
}
