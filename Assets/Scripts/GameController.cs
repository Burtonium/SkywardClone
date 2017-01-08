using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public PlayerController player;
    private SmoothFollow smoothFollowCamera;

	void Start ()
    {
        smoothFollowCamera = GetComponent<SmoothFollow>();
        SnapCameraToActivePiece();
	}
	
    public void SnapCameraToActivePiece()
    {
        smoothFollowCamera.SetTarget(player.CurrentActive().transform);
    }

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            player.ToggleActive();
            SnapCameraToActivePiece();
        }
	}
}
