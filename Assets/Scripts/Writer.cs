using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;


public class Writer : MonoBehaviour {

    StreamWriter writer;
    float xPos;
    float yPos;
    string xResult;
    string yResult;
    // Use this for initialization
    void Start () {
        string path = Path.GetRandomFileName();
        writer = new StreamWriter(File.Open(path, FileMode.CreateNew));
       
	}
	
	// Update is called once per frame
	void Update () {
        StringBuilder sb = new StringBuilder();
        xPos = gameObject.transform.position.x;
        yPos = gameObject.transform.position.z;
       xResult = xPos.ToString();
       yResult = yPos.ToString();
        string Parameter1 = xResult;
        string Parameter2 = yResult;
        sb.AppendLine(string.Format("{0},{1};", Parameter1, Parameter2));
        writer.Write(sb.ToString());
           

    }
}
