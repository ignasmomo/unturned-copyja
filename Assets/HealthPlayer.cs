using UnityEngine;
using System.Collections;

public class HealthPlayer : MonoBehaviour {

	public int health = 100;
	public bool dead = false;
	// Use this for initialization
	void Start () {

	}
	/*public static void ApplyDamage (float theDamage)
	{
		health -= theDamage;
	}*/
	// Update is called once per frame

	public static void ApplyDamage( HealthPlayer healthPlayer, float theDamage ) {
		healthPlayer.health -= theDamage;
	}



	void Update () {

		if (health <= 0)
		dead = true;
		if (dead) {
			GetComponent<CharacterMotor>().enabled = false;
			GetComponent<MouseLook>().enabled = false;
		}


	}


	void OnControllerColliderHit(ControllerColliderHit collision)
	{
		//Debug.Log(string.Format("object tag={0}",collision.collider.gameObject.tag));
		if (collision.gameObject.tag == "block") {
			Debug.Log("working");
			health -= 10;
		
				}
	}

}
