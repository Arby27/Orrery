using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float moveSpeed;
	public float R;
	public float angle;
	public float mass;
	public float eccentricity;
	//public float periapsis;
	//public float angularMomentum;
	//public float constant;
	//public float aphelion;
    public float semiMajorAxis;
/*	public float perihelion;
	public float xCent;
	public float yCent;*/
	public float xPos;
	public float zPos;
    float yPos;
    public double angleFromSun;
    public float angleOfInclination;
    double avgFrame = 0.0802747252747253;

    float oldTimeScale = Time.timeScale;


    // Use this for initialization
    void Start () {
        //R = ((Mathf.Pow (angularMomentum, 2.0f)) / (Mathf.Pow (mass, 2.0f) * constant)) * (1 / (1 + eccentricity * Mathf.Cos (angle)));
        
	}
	
	// Update is called once per frame
	void Update () {
        angle += moveSpeed * Time.deltaTime;
        angleFromSun += moveSpeed * avgFrame ;
        
        //Use a derivation of keplers first law to find r
        R = (semiMajorAxis * (1 - Mathf.Pow(eccentricity, 2))) / (1 + (eccentricity * Mathf.Cos(angle)));
		//transform.Translate((Mathf.Cos (angle)*aphelion) * Radius,(Mathf.Sin (angle)* perihelion) * Radius,0);
		xPos =  (R * Mathf.Cos (angle ));
		zPos =  (R * Mathf.Sin (angle ));

        yPos =  xPos * Mathf.Sin(angleOfInclination * Mathf.PI / 180);//converting the degrees to radians
		this.gameObject.transform.position =  GameObject.Find("Sun").transform.position + new Vector3(xPos, yPos, zPos);


        


        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            Time.timeScale = Time.timeScale + 0.1f;
        }

        if (moveSpeed > 0)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Time.timeScale = Time.timeScale - 0.1f;
            }
        }
    }
}
