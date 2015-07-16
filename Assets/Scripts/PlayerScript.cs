using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{

	public Transform player;
	public float moveSpeed = 4.0f;
	public float turboSpeed = 8.0f;
	public GameObject treasure;
	private string treasureMessage;

	void OnGUI ()
	{
		GUI.Label (new Rect (10, 10, 100, 100), treasureMessage);
	}

	void Start ()
	{
		treasureMessage = "Find the treasure";
	}
	
	// Update is called once per frame
	void Update ()
	{

		float actualSpeed = 0f;
		if (Input.GetKey (KeyCode.LeftShift)) {
			actualSpeed = turboSpeed;
		} else {
			actualSpeed = moveSpeed;
		}

	
		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (0f, 0f, 1f) * Time.deltaTime * actualSpeed;
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0f, 0f, -1f) * Time.deltaTime * actualSpeed;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (-1f, 0f, 0f) * Time.deltaTime * actualSpeed;
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (1f, 0f, 0f) * Time.deltaTime * actualSpeed;
		}
		if (Vector3.Distance (this.transform.position, treasure.transform.position) < 5f && Input.GetKey (KeyCode.Space)) {
			treasureMessage = "You found it!";
		} else if (this.transform.position.x - treasure.transform.position.x < -50f) {
			treasureMessage = "Go East";
		} else if (this.transform.position.z - treasure.transform.position.z < -10f) {
			treasureMessage = "Too far South, go North";
		
		} else {
			treasureMessage = "Find the treasure";
		}
		//if ( this.transform.position.x - treasure.transform.position.x ) {
		//print (this.transform.position.x - treasure.transform.position.x);
		







	

	}
}
