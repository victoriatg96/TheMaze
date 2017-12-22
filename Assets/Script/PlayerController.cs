//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public int id;
	public float Speed = 10f;
	public float jump = 20f;
	//public float Gravite = 0;
	private Vector2 DirectionDeplacement = Vector2.zero;
	//private Vector3 DirectionDeplacement = Vector3.zero;
	//private CharacterController Player;

	public float horizontalSpeed = 2.0F;
	public float verticalSpeed = 2.0F;

	void Start () {
		//Player = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		DirectionDeplacement = Vector2.zero;
		DirectionDeplacement.x = Input.GetAxisRaw ("Horizontal j" + id);
		DirectionDeplacement.y = Input.GetAxisRaw ("Vertical j" + id);

		//DirectionDeplacement = transform.TransformDirection(DirectionDeplacement);
		//transform.Translate (new Vector3(DirectionDeplacement.x  * Time.deltaTime * Speed, DirectionDeplacement.y * Time.deltaTime * Speed, 0.0f));

		//Player.Move (DirectionDeplacement * Speed * Time.deltaTime);


		/*
		float h = horizontalSpeed * Input.GetAxis ("Mouse X");
		float v = verticalSpeed * Input.GetAxis ("Mouse Y");
		transform.Rotate (v, h, 0);
*/
		/*
		if (!Player.isGrounded) {
			DirectionDeplacement.y = Gravite * Time.deltaTime * Speed;
		}
		*/
		/*
		if (Input.GetKeyDown (KeyCode.Z)) {
			DirectionDeplacement.y = jump * Speed * Gravite;
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			DirectionDeplacement.y -= jump * Speed * Gravite;
		}
		*/
	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position + DirectionDeplacement * Speed * Time.fixedDeltaTime);
	}
}
