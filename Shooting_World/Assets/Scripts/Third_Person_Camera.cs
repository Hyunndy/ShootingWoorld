using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third_Person_Camera : MonoBehaviour {

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 4.5f;
    private float currentX = 1f;
    private float currentY =2f;
    private float sensivityX = 4.0f;
    private float sensivityY = 1.0f;

    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 50.0f;
    
    // Use this for initialization
	void Start () {

        camTransform = transform;
        cam = Camera.main;

	}

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(5, 5,-distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);

    }
    // Update is called once per frame
    void Update () {

        /*currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        currentY =Mathf.Clamp(currentY,Y_ANGLE_MAX)
        */
    }
}
