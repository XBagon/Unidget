using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 mousePosition = Input.mousePosition;
        if (mousePosition.x < (0 + Screen.width / 99))
        {
            transform.Translate(new Vector3(-(speed * Time.deltaTime), 0));
        }

        if (mousePosition.x > Screen.width - Screen.width / 99)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0));
        }

        if (mousePosition.y > Screen.height - Screen.height / 99)
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime));
        }

        if (mousePosition.y < (0 + Screen.height / 99))
        {
            transform.Translate(new Vector3(0, -(speed * Time.deltaTime)));
        }

        Debug.Log(mousePosition.x + " | " + mousePosition.y);
    }
}
