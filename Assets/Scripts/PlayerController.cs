using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public GameObject firstCircle;
    public GameObject secondCircle;
    private bool firstCircleIsActive;

    public void ToggleActive()
    {
        firstCircleIsActive = !firstCircleIsActive;
    }

    public GameObject CurrentActive()
    {
        return firstCircleIsActive ? firstCircle : secondCircle;
    }

    public GameObject NotActive()
    {
        return firstCircleIsActive ? secondCircle : firstCircle;
    }
}
