using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cube : MonoBehaviour {

	public float max_health = 100f;
	public float cur_health = 0f;
	public GameObject player;
	public GameObject cubepickup;
	public GameObject healthBar;
	public Canvas allhealthBar;
	public Text countText;
	public Text winText;

	private int count;

//	private float barDisplay = 0;
//	private Vector2 pos = new Vector2(20,40);
//	private Vector2 size = new Vector2(60,20);
//	private Texture2D progbarfull;
//	private Texture2D progbarempty;
//	var barDisplay : float = 0;
//	var pos : Vector2 = new Vector2(20,40);
//	var size : Vector2 = new Vector2(60,20);
//	var progressBarEmpty : Texture2D;
//	var progressBarFull : Texture2D;

	// Use this for initialization
	void Start () {
		cur_health = max_health;
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "WeaponClub") {
			cur_health -= 10f;					
		}
		if (other.gameObject.tag == "WeaponSword") {
			cur_health -= 25f;					
		}
		if (cur_health <= 0f) {
			Destroy (cubepickup.gameObject);
			Destroy (allhealthBar.gameObject);
			winText.text = "You Win!";
		}
		float calc_health = cur_health / max_health;
		setHealthBar (calc_health);

	}

	void setHealthBar (float myHealth){
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	
	}
	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
	}
//	void OnGUI(){
//		// draw the background:
//		GUI.BeginGroup (new Rect (pos.x, pos.y, size.x, size.y));
//		GUI.Box (Rect (0,0, size.x, size.y),progbarempty);
//
//		// draw the filled-in part:
//		GUI.BeginGroup (new Rect (0, 0, size.x * barDisplay, size.y));
//		GUI.Box (Rect (0,0, size.x, size.y),progbarfull);
//		GUI.EndGroup ();
//
//		GUI.EndGroup ();
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		barDisplay = Time.time * 0.05;
//	}
}
