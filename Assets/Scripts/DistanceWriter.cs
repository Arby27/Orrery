using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

public class DistanceWriter : MonoBehaviour {

    StreamWriter writer;
    float xPos;
    float yPos;
    float distance;
    double time = 0;
    public string Planet;
    public Movement benchmark;


	// Use this for initialization
	void Start () {
        string path = Path.GetFileName(Planet);
        writer = new StreamWriter(File.Open(path, FileMode.CreateNew));

    }
	
	// Update is called once per frame
	void Update () {
        StringBuilder sb = new StringBuilder();

        xPos = gameObject.transform.position.x;
        yPos = gameObject.transform.position.z;

        //pythagoras therom to calculate distance
        distance = Mathf.Sqrt((Mathf.Pow(xPos, 2) + Mathf.Pow(yPos, 2)));

        double value = benchmark.angleFromSun;

        time = (value);

        

        string distanceWrite = distance.ToString();
        string timeWrite = time.ToString();

        sb.AppendLine(string.Format("{0} , {1}", distanceWrite, timeWrite));
        writer.Write(sb.ToString());

    }
}
