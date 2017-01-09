using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public GameObject firstCircle;
    public GameObject secondCircle;
    public float timeoutTime;
    public float rotationSpeed;
    public Vector3 initialScale;

    private float timeRemaining;
    private bool firstCircleIsActive;

    public void ToggleActive()
    {
        NotActive().transform.localScale = initialScale;
        timeRemaining = timeoutTime;
        firstCircleIsActive = !firstCircleIsActive;
    }

    public float RemainingTime()
    {
        return timeRemaining;
    }

    public GameObject CurrentActive()
    {
        return firstCircleIsActive ? firstCircle : secondCircle;
    }

    public GameObject NotActive()
    {
        return firstCircleIsActive ? secondCircle : firstCircle;
    }

    public void Start()
    {
        initialScale = firstCircle.transform.localScale;
        timeRemaining = timeoutTime;
    }

    public void Update()
    {
        timeRemaining -= Time.deltaTime;

        // Rotate around the active object
        NotActive().transform.RotateAround(CurrentActive().transform.position, Vector3.up, rotationSpeed * Time.deltaTime);

        float percentCloseToDeath = (timeoutTime - timeRemaining) / timeoutTime;

        Debug.Log("Percent:" + percentCloseToDeath);
        NotActive().transform.localScale = Vector3.Lerp(initialScale, new Vector3(), percentCloseToDeath);

    }
}
