using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManagement2 : MonoBehaviour
{
	//public float HP;
	public int HP = 5;
	public int cp = 1;
	//bool HP = 100 = true;
	public GameObject vie1;
	public GameObject vie2;
	public GameObject vie3;
	public GameObject vie4;
	public GameObject vie5;
	public GameObject cp2;
	public GameObject j1g2;
	public GameObject j1g;
	// Use this for initialization
	void Start () {
		HP = 5;
		//Camp1.SetActive (false);

	}

	// Update is	 called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag ("Bonus")) {
			HP++;
			if (HP > 5)
				HP = 5;

			switch (HP) {
			case 5:
				vie5.SetActive (true);
				break;

			case 4:
				vie4.SetActive (true);
				break;

			case 3:
				vie3.SetActive (true);
				break;

			case 2:
				vie2.SetActive (true);
				break;

			case 1:
				vie1.SetActive (true);
				break;
			}

			Destroy (other.gameObject);
		} else if (other.gameObject.CompareTag ("Player")) {

		} else if (other.gameObject.CompareTag ("Wall")) {
			HP--;

			switch (HP) {
			case 4:
				vie5.SetActive (false);
				break;

			case 3:
				vie4.SetActive (false);
				break;

			case 2:
				vie3.SetActive (false);
				break;

			case 1:
				vie2.SetActive (false);
				break;

			case 0:
				vie1.SetActive (false);
				j1g.SetActive (true);
				break;
			}
		}/* else if (other.gameObject.CompareTag ("Camp1")) {
			cp--;


			cp1.SetActive (false);

			if (cp < 1) {


				j1g.SetActive (true);


			}
		}*/

		else if (other.gameObject.CompareTag ("Camp2")) {
			cp--;

			cp2.SetActive (true);
			if (cp < 1) {


				j1g2.SetActive (true);


			}
		}

	}
}
