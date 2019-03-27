using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMovement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public GameObject maincamera;
    public GameObject rightShoulder;

    Vector3 lastPosition = Vector3.zero;
    Vector3 lastRotation = Vector3.zero;

    float threshold = 1.3f;
    bool flyingHigh = false;
    float lastAngle = 0;
    private void Start()
    {

    }

    void FixedUpdate()
    {
        if (GameObject.Find("R_shoulder")) {
            this.rightShoulder = GameObject.Find("R_shoulder");
            rotate();
        }

    }

    void rotate()
    {
        Vector3 targetDir = new Vector3(rightShoulder.transform.position.x, 0, rightShoulder.transform.position.z) - new Vector3(transform.position.x, 0, transform.position.z);
        lastPosition = transform.position;
        float angle = Vector3.Angle(targetDir, new Vector3(1, 0, 0));
        angle = angle - lastAngle;
        lastAngle = angle;
        if (targetDir.z < 0)
            maincamera.transform.Rotate(0, Mathf.Deg2Rad * angle, 0);
        else
            maincamera.transform.Rotate(0, -Mathf.Deg2Rad * angle, 0);
    }


}