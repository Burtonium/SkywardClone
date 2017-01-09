using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour {
    public List<GamePiece> last;
    public Vector3 attachLocation;
    public float destructionSpeed;
    public Vector3 velocity;
    private bool isBeingDestroyed = false;
    public float acceleration; 

	// Use this for initialization
	void Start () {
        attachLocation = transform.position + new Vector3(0f, 0.2f, 0f);
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Destroy();
        }

        if (isBeingDestroyed)
        {
            transform.Translate(Vector3.down * Time.deltaTime * destructionSpeed);
            destructionSpeed *= acceleration;
        }
	}

    public void Destroy()
    {
        isBeingDestroyed = true;
        velocity = -transform.up;
        Destroy(gameObject, 3);
    }

}
