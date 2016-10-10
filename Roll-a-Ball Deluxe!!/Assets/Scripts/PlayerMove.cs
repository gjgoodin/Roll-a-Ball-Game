using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;
	public int maxHealth = 100;
	public int curHealth = 100;
	public GameObject club;


	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
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
		}	
		if (count >= 11){
			winText.text = "You Win!!";
		}
			
	}
	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
	}
}