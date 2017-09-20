using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject target;
	public float followAhead;
	public float smoothing;

	private Vector3 targetPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// this moves the target of the camera ahead of the player in both left and right direction.
		targetPosition = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);

		if (target.transform.localScale.x > 0f) {
			targetPosition = new Vector3 (targetPosition.x + followAhead, targetPosition.y, targetPosition.z);
		} else {
			targetPosition = new Vector3 (targetPosition.x -followAhead, targetPosition.y, targetPosition.z);

		}
		transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing*Time.deltaTime);

		//transform.position = targetPosition;
	}
}
