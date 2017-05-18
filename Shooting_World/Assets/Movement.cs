using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10f;
    public float rotateSpeed = 10f;
    Rigidbody rigibody;

    Vector3 movement;

    void Run(float h, float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * speed * Time.deltaTime;

        rigibody.MovePosition(transform.position + movement);
    }

    void Turn()
    {

        Quaternion newRotation = Quaternion.LookRotation(movement);

        rigibody.rotation = Quaternion.Slerp(rigibody.rotation, newRotation, rotateSpeed * Time.deltaTime);
    }

    // Use this for initialization
    void Awake () {
        rigibody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Run(h, v);
        Turn();
	}
}
