using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

	public float speed;
	public GameObject club;
	public GameObject sword;


	private Rigidbody rb;
	public int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

	}
	void OnTriggerEnter(Collider other)
	{
//		if (other.gameObject.CompareTag ("Pick Up")) 
//		{
//			other.gameObject.SetActive (false);
//			count = count + 1;
//			SetCountText ();
//		}
		if (other.gameObject.CompareTag ("FWeaponClub")) {
			other.gameObject.SetActive (false);
			club.gameObject.SetActive (true);
			sword.gameObject.SetActive (false);
		}	
		if (other.gameObject.CompareTag ("FWeaponSword")) {
			other.gameObject.SetActive (false);
			sword.gameObject.SetActive (true);
			club.gameObject.SetActive (false);
		}	

//		if (count >= 11){
//			winText.text = "You Win!!";
//		}
//			
	}
//	void SetCountText ()
//	{
//		countText.text = "Count: " + count.ToString ();
//	}
}