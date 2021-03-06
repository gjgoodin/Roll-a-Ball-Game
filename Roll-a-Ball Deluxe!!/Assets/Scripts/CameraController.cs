﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

//	public Transform target;
//	public float angularSpeed;
//
//	[SerializeField][HideInInspector] 
//	private Vector3 initialOffset;
//
//	private Vector3 currentOffset;
//
//	[ContextMenu("Set Current Offset")]
//	private void SetCurrentOffset () {
//		if(target == null) {
//			return;
//		}
//
//		initialOffset = transform.position - target.position;
//	}
//
//	private void Start () {
//		if(target == null) {
//			Debug.LogError ("Assign a target for the camera in Unity's inspector");
//		}
//
//		currentOffset = initialOffset;
//	}
//
//	private void LateUpdate () {
//		transform.position = target.position + currentOffset;
//
//		float movement = Input.GetAxis ("Horizontal") * angularSpeed * Time.deltaTime;
//		if(!Mathf.Approximately (movement, 0f)) {
//			transform.RotateAround (target.position, Vector3.up, movement);
//			currentOffset = transform.position - target.position;
//		}
//	}
//
//	public GameObject player;
//	public float turnSpeed;
//	public Transform player_cam;
//	private Vector3 offset;
//
//	// Use this for initialization
//	void Start () {
//		offset = transform.position - player.transform.position;
//
//	}
//
//	// Update is called once per frame
//	void LateUpdate () {
//		transform.position = player.transform.position + offset;
//
//		float movement = Input.GetAxis ("Horizontal_1") * turnSpeed * Time.deltaTime;
//		if(!Mathf.Approximately (movement, 0f)) {
//			transform.RotateAround (player_cam.position, Vector3.up, movement);
//			offset = transform.position - player_cam.position;
//		}
//
//		offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
//		transform.position = player_cam.position + offset; 
//		transform.LookAt(player_cam.position);
//
//		float desiredAngle = player.transform.eulerAngles.y;
//		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
//
//		transform.position = player.transform.position - (rotation * offset);
//		transform.LookAt(player.transform);
//	}
//}
//
		public GameObject target;
		public float damping;
		Vector3 offset;

		void Start() {
			offset = transform.position - target.transform.position;
		}

		void LateUpdate() {
			Vector3 desiredPosition = target.transform.position + offset;
			Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
			transform.position = position;

			transform.LookAt(target.transform.position);
		}
	}
//	public GameObject target;
//	public float rotateSpeed = 5;
//	Vector3 offset;
//
//	void Start() {
//		offset = target.transform.position - transform.position;
//	}
//
//	void LateUpdate() {
//		float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
//		target.transform.Rotate(0, horizontal, 0);
//
//		float desiredAngle = target.transform.eulerAngles.y;
//		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
//		transform.position = target.transform.position - (rotation * offset);
//
//		transform.LookAt(target.transform);
//	}
//}