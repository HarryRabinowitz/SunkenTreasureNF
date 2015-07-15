using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public Transform player;
	public Transform sphere;


	//float dist = 5f;

	//new Vector3 (5f, 5f, 0f );

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	

		//Input.GetKeyDown (KeyCode.Space) &&
		//if (player) {
		//	dist = ( Vector3.Distance ( player.transform.position, sphere.transform.position )); //&& Input.GetKeyDown ( KeyCode.Space ) );

				//textBuffer= "You Found It! ";


		if ( Vector3.Distance ( player.position, sphere.position ) < 5) { //&& Input.GetKeyDown ( KeyCode.Space ) );
			print ("Distance is equal to + dist");
		}
	}
}
