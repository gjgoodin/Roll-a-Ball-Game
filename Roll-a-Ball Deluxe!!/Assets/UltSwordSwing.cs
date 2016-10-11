using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UltSwordSwing: MonoBehaviour {

	public GameObject playerhand;
	public GameObject club;
	public GameObject sword;
	public Transform swing;
	bool grabbed = false;
	public Animator anim;
	public GameObject cubepickup;

	// Update is called once per frame
	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void Update () {
		if (grabbed) {
			club.gameObject.SetActive (true);
			transform.position = playerhand.transform.position;
		}
		if (Input.GetKeyDown ("space")) {
			anim.Play ("", -1, 0f);
		}
		//			if (sword.gameObject.SetActive (true)) {
		//				anim.Play ("SwordSwing", -1, 0f);
		//			}
		//			if (sword.gameObject.SetActive (true)) {
		//			}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			grabbed = true;
		}
		//		if (other.gameObject.tag == "Pick Up") {
		//			cube.health -= 50;
		//			print ("Hit v nice");
		//		}
		//		if (cube.health <= 0) {
		//			Destroy (cubepickup.gameObject);
		//		}
	}
}
