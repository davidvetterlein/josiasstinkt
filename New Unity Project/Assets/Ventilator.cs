using UnityEngine;
using System.Collections;

public class Ventilator : MonoBehaviour {
	Rigidbody rig;
	public Vector3 vec;
	public GameObject hitttt;
	// Use this for initialization
	void Start () {
		rig = gameObject.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Vector3 lefts = transform.TransformDirection(Vector3.left) - new Vector3(-1,0,0);
		if (Physics.Raycast (transform.position, lefts, out hit)) {
			hitttt = hit.transform.gameObject;
			if (hit.transform.gameObject.tag == "Player") {

				hit.transform.position += vec;
			}
		}

	}
}
