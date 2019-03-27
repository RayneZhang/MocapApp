using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public GameObject maincamera;

    Vector3 lastPosition = Vector3.zero;
    Vector3 lastRotation = Vector3.zero;

    float threshold = 1.3f;
    bool flyingHigh = false;

    void FixedUpdate()
    {
        moveforward();
        flyHigh(transform.position.y);
    }

    void moveforward(){
        speed = (transform.position - lastPosition).magnitude;
        lastPosition = transform.position;
        float forwardMovement = speed * 200.0f * Time.deltaTime;
        maincamera.transform.Translate(Vector3.forward * forwardMovement);
        if(flyingHigh)
            maincamera.transform.Translate(Vector3.up * forwardMovement);
        else
            maincamera.transform.Translate(Vector3.down * 0.4f * forwardMovement);
    }

    void rotate()
    {
        
        //Vector3 targetDir = transform.localRotation - lastRotation;
        //float angle = Vector3.Angle(targetDir, transform.forward);
        Debug.Log(transform.localRotation.y);
        //turnSpeed = 
        //float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        //direction
        //if (the rotation of the head > 20 degree)
        // transform.Rotate(Vector3.up * turnMovement);
        // if (the postion changes in the physcial time)
    }

    void flyHigh(float yPos) {
        if (yPos > threshold)
            this.flyingHigh = true;
        else
            this.flyingHigh = false;
    }


}