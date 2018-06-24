using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	public float dayLength; // equivalent to 1 earth day
	float rotate;
	public float axialTilt; //degrees

	// Use this for initialization
	void Start () {
		this.gameObject.transform.Rotate (axialTilt, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Rotate ( 0,-dayLength, 0);

	}
}
