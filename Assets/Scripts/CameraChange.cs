using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {

    public GameObject mercury;
    public GameObject venus;
    public GameObject earth;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public GameObject neptune;
    public GameObject pluto;

    bool mercurytrue = false;
    bool venustrue = false;
    bool earthtrue = false;
    bool marstrue = false;
    bool jupitertrue = false;
    bool saturntrue = false;
    bool uranustrue = false;
    bool neptunetrue = false;
    bool plutotrue = false;

    float zoomValue = 10.0f;

  
    void OnGUI()
    {
    
        
        GUI.backgroundColor = Color.green;

        zoomValue = GUI.HorizontalSlider(new Rect(20, 240, 80, 20), zoomValue, 10.0f, 10000.0f);

        GUI.Box(new Rect(10, 10, 190, 1080), "Click to zoom on the planet");

        if (GUI.Button(new Rect(20,40,80,20), "Mercury"))
        {
            Camera.main.transform.position = mercury.transform.position + new Vector3(0,zoomValue,0);
            Camera.main.transform.Rotate(new Vector3(90, 0, 0));
            mercurytrue = true;
            venustrue = false;
            earthtrue = false;
            marstrue = false;
            jupitertrue = false;
            saturntrue = false;
            uranustrue = false;
            neptunetrue = false;
            plutotrue = false;
        }


        if (GUI.Button(new Rect(20, 60, 80, 20), "Venus"))
        {
            Camera.main.transform.position = venus.transform.position + new Vector3(0, zoomValue, 0);
            Camera.main.transform.Rotate(new Vector3(90, 0, 0));
            venustrue = true;
            mercurytrue = false;
            earthtrue = false;
            marstrue = false;
            jupitertrue = false;
            saturntrue = false;
            uranustrue = false;
            neptunetrue = false;
            plutotrue = false;
        }

        if (GUI.Button(new Rect(20, 80, 80, 20), "Earth"))
        {
            Camera.main.transform.position = earth.transform.position + new Vector3(0, zoomValue, 0);
            Camera.main.transform.Rotate(new Vector3(90, 0, 0));
            earthtrue = true;
            mercurytrue = false;
            venustrue = false;
            marstrue = false;
            jupitertrue = false;
            saturntrue = false;
            uranustrue = false;
            neptunetrue = false;
            plutotrue = false;
        }

        if (GUI.Button(new Rect(20, 100, 80, 20), "Mars"))
        {
            Camera.main.transform.position = mars.transform.position + new Vector3(0, zoomValue, 0);
            Camera.main.transform.Rotate(new Vector3(90, 0, 0));
            marstrue = true;
            mercurytrue = false;
            venustrue = false;
            earthtrue = false;
            jupitertrue = false;
            saturntrue = false;
            uranustrue = false;
            neptunetrue = false;
            plutotrue = false;
        }


        if (GUI.Button(new Rect(20, 120, 80, 20), "Jupiter"))
        {
            Camera.main.transform.position = jupiter.transform.position + new Vector3(0, zoomValue, 0);
            Camera.main.transform.Rotate(new Vector3(90, 0, 0));
            jupitertrue = true;
            mercurytrue = false;
            venustrue = false;
            earthtrue = false;
            marstrue = false;
            saturntrue = false;
            uranustrue = false;
            neptunetrue = false;
            plutotrue = false;
        }

        if (GUI.Button(new Rect(20, 140, 80, 20), "Saturn"))
        {
            Camera.main.transform.position = saturn.transform.position + new Vector3(0, zoomValue, 0);
            Camera.main.transform.Rotate(new Vector3(90, 0, 0));
            saturntrue = true;
            mercurytrue = false;
            venustrue = false;
            earthtrue = false;
            marstrue = false;
            jupitertrue = false;
            uranustrue = false;
            neptunetrue = false;
            plutotrue = false;
        }

        if (GUI.Button(new Rect(20, 160, 80, 20), "Uranus"))
        {
            Camera.main.transform.position = uranus.transform.position + new Vector3(0, zoomValue, 0);
            Camera.main.transform.Rotate(new Vector3(90, 0, 0));
            uranustrue = true;
            mercurytrue = false;
            venustrue = false;
            earthtrue = false;
            marstrue = false;
            jupitertrue = false;
            saturntrue = false;
            neptunetrue = false;
            plutotrue = false;
        }

        if (GUI.Button(new Rect(20, 180, 80, 20), "Neptune"))
        {
            Camera.main.transform.position = neptune.transform.position + new Vector3(0, zoomValue, 0);
            Camera.main.transform.Rotate(new Vector3(90, 0, 0));
            neptunetrue = true;
            mercurytrue = false;
            venustrue = false;
            earthtrue = false;
            marstrue = false;
            jupitertrue = false;
            saturntrue = false;
            uranustrue = false;
            plutotrue = false;
        }

        if (GUI.Button(new Rect(20, 200, 80, 20), "Pluto"))
        {
            Camera.main.transform.position = pluto.transform.position + new Vector3(0, zoomValue, 0);
            Camera.main.transform.Rotate(new Vector3(90, 0, 0));
            plutotrue = true;
            mercurytrue = false;
            venustrue = false;
            earthtrue = false;
            marstrue = false;
            jupitertrue = false;
            saturntrue = false;
            uranustrue = false;
            neptunetrue = false;
        }
    }

    void Update()
    {


        //Camera Follow for the planet when the corresponding button on GUI is pressed;
        if (mercurytrue == true)
        {
            Camera.main.transform.position = mercury.transform.position + new Vector3(0,zoomValue,0);
            
        }


        if (venustrue == true)
        {
            Camera.main.transform.position = venus.transform.position + new Vector3(0, zoomValue, 0);
          
        }


        if (earthtrue == true)
        {
            Camera.main.transform.position = earth.transform.position + new Vector3(0, zoomValue, 0);
            
        }


        if (marstrue == true)
        {
            Camera.main.transform.position = mars.transform.position + new Vector3(0, zoomValue, 0);

        }


        if (jupitertrue == true)
        {
            Camera.main.transform.position = jupiter.transform.position + new Vector3(0, zoomValue, 0);
            
        }


        if (saturntrue == true)
        {
            Camera.main.transform.position = saturn.transform.position + new Vector3(0, zoomValue, 0);
            
        }


        if (uranustrue == true)
        {
            Camera.main.transform.position = uranus.transform.position + new Vector3(0, zoomValue, 0);
         
        }


        if (neptunetrue == true)
        {
            Camera.main.transform.position = neptune.transform.position + new Vector3(0, zoomValue, 0);
            
        }


        if (plutotrue == true)
        {
            Camera.main.transform.position = pluto.transform.position + new Vector3(0, zoomValue, 0);
            
        }







        // Camera reset
        if (Input.anyKeyDown && Input.GetKeyDown(KeyCode.Mouse0) != true)
        {
            
           mercurytrue = false;
           venustrue = false;
           earthtrue = false;
           marstrue = false;
           jupitertrue = false;
           saturntrue = false;
           uranustrue = false;
           neptunetrue = false;
           plutotrue = false;
        }
    }
}
