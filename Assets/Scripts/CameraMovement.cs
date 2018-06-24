using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public float moveSpeed;
    float mouseX = 0, mouseY = 0;
    float oldPosX = 0, oldPosY = 0;
  
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.D))
		{
            //Vector that transaltes in the positive x direction
			transform.Translate (Vector2.right * moveSpeed );
			
		}
		
		if(Input.GetKey(KeyCode.A))
		{
            //Vector that transaltes in the negative x direction
            transform.Translate (Vector2.left * moveSpeed );
    	}

		if(Input.GetKey(KeyCode.W))
		{
            //Vector that translates in the positive Z direction 
			transform.Translate (Vector3.up * moveSpeed );
			


		}
		
		if(Input.GetKey(KeyCode.S))
		{
            //Vector that translates in the negative Z direction 
            transform.Translate (Vector3.down * moveSpeed );
		}

        if (Input.GetAxis("Mouse ScrollWheel") < 0.0f)
        {
            //Vector that translates in the negative Y direction
            transform.Translate(Vector3.back * moveSpeed);



        }

        if (Input.GetAxis("Mouse ScrollWheel" ) > 0.0f)
        {
            //Vector that translates in the positive Y direction
            transform.Translate(Vector3.forward * moveSpeed);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.mousePosition.x > (Screen.width / 2))
            {
                mouseX =   Input.mousePosition.x;
            }
            else
            {
                mouseX =   Input.mousePosition.x ;
            }

            if (Input.mousePosition.y > (Screen.height / 2))
            {
                mouseY = mouseY + Input.mousePosition.y;
            }


            transform.position = new Vector3(mouseX, transform.position.y, mouseY);
        }


        if(Input.GetKey(KeyCode.LeftAlt))
        {
            oldPosX = oldPosX + Input.mousePosition.x;
            oldPosY = oldPosY + Input.mousePosition.y;

            transform.rotation = new Quaternion(oldPosX,oldPosY,0,0);
        }



        if(Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(0, 1300, 0);
            mouseX = 0;
            mouseY = 0;
        }
    }
}
