using UnityEngine;
using System.Collections;

public class RayCastShooting : MonoBehaviour {
	public GameObject Character;
	private RaycastHit Hit;
	public float theDamage;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 myTransform = Character.transform.forward;

			if (Input.GetKey (KeyCode.Mouse0)) {
				
				if(Physics.Raycast(transform.position , myTransform , out Hit , 20)){

				if(Hit.collider.gameObject.CompareTag("block")){
					Debug.DrawRay(transform.position , Character.transform.forward , Color.red);

						print("objecktas debile");

					//Hit.collider.gameObject.SendMessage("ApplyDamage", theDamage, SendMessageOptions.DontRequireReceiver);
					HealthPlayer.ApplyDamage( HealthPlayer, 10 );						
				}
			}
		}
	}
}
