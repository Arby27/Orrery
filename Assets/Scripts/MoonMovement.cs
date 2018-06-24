using UnityEngine;
using System.Collections;

public class MoonMovement : MonoBehaviour {

    public float semiMajorAxis;
    public float eccentricity;
    public float mass;
    public GameObject Planet;
    public float moveSpeed;
    float angle;
    float xPos;
    float yPos;
    float R;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
     this.gameObject.transform.position = Planet.transform.position + new Vector3(xPos, 0, yPos);
        angle += moveSpeed * Time.deltaTime;
        R = (semiMajorAxis * (1 - Mathf.Pow(eccentricity, 2))) / (1 + (eccentricity * Mathf.Cos(angle)));

        xPos = (R * Mathf.Cos(angle ));
        yPos = (R * Mathf.Sin(angle));

      
	
	}
}
