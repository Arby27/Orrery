using UnityEngine;
using System.Collections;

public class MouseOver : MonoBehaviour {

    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit rayHit;
    bool displayText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(ray, out rayHit, 1000))
        {
            displayText = true;
        }
        else
        {
            displayText = false;
        }
	
	}

    void OnGUI()
    {
        if(displayText == true)
        {
            GUI.Label(new Rect(100, 100, 40, 20), "TEST");
        }
    }
}
