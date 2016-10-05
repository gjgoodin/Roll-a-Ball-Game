using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClubSwing : MonoBehaviour {

	public GameObject playerhand;
	public GameObject club;
	public Transform swing;
	bool grabbed = false;

	private string firebutton;
	private bool fired;

	// Update is called once per frame
	void Update () {
		if (grabbed) {
			club.gameObject.SetActive (true);
			transform.position = playerhand.transform.position;
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			grabbed = true;
		}
	}
	void onFire (){
		if (Input.GetButtonDown (firebutton)) {
		}
	}
	private void Fire(){
		fired = true;
	}
}
