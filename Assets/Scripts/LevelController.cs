using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {
    public int maximumGamePieces;
    public GamePiece last;

	// Use this for initialization
	void Start () {
		while(transform.childCount < maximumGamePieces)
        {

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
