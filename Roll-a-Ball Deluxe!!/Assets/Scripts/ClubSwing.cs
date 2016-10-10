using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClubSwing : MonoBehaviour {

	public GameObject playerhand;
	public GameObject club;
	public Transform swing;
	bool grabbed = false;
	public Animator anim;

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
			anim.Play ("Melee Swing", -1, 0f);
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			grabbed = true;
		}
	}
}
