using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour {

	public float moveSpeed = 4.0f;
	public float turboSpeed = 8.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	float actualSpeed = 0f;
		if ( Input.GetKey ( KeyCode.LeftShift) ) {
			actualSpeed = turboSpeed;
		} else {
			actualSpeed = moveSpeed;
		}

	
	if ( Input.GetKey ( KeyCode.W ) ) {
			transform.position += new Vector3 (0f, 0f, 1f ) * Time.deltaTime * actualSpeed;
		}

	if ( Input.GetKey ( KeyCode.S ) ) {
			transform.position += new Vector3 (0f, 0f, -1f ) * Time.deltaTime * actualSpeed;
		}

	if ( Input.GetKey ( KeyCode.A ) ) {
			transform.position += new Vector3 ( -1f, 0f, 0f ) * Time.deltaTime * actualSpeed;
		}

	if ( Input.GetKey ( KeyCode.D ) ) {
			transform.position += new Vector3 ( 1f, 0f, 0f ) * Time.deltaTime * actualSpeed;
		}
	}
}
