using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float minumumX = -60f;
    public float maximumX = 60f;
    public float minimumY = -360f;
    public float maximumY = 360f;

    public float sensitivityX = 15f;
    public float sensitivityY = 15f;

    public Camera cam;

    float rotationY = 0f;
    float rotationX = 0f;
    Vector3 offset;

    // Use this for initialization
    void Start () {

        Cursor.lockState = CursorLockMode.Locked;
        offset = cam.transform.position - transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        rotationY += Input.GetAxis("Mouse X") * sensitivityY;
        rotationX += Input.GetAxis("Mouse Y") * sensitivityX;

        rotationX = Mathf.Clamp(rotationX, minumumX, maximumX);

        transform.localEulerAngles = new Vector3(0, rotationY, 0);
        cam.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);


        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void LateUpdate()
    {
        cam.transform.position = transform.position + offset;
    }
}
