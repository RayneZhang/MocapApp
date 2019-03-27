using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitting : MonoBehaviour
{
    //public Rigidbody bulletPrefab;
    //public Transform firePosition;
    //public float bulletSpeed;

    Life life;
    bool isTriggered;

    void Awake()
    {
        life = GetComponent<Life>();
        isTriggered = false;
    }


    void Update()
    {
        Hit();
    }

    void OnTriggerEnter(Collider other)
    {
        isTriggered = true;
        Hit();
    }


	void Hit()
    {
        if (isTriggered == true && life.myPoint.points > 0)
        {
            //Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            //bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            life.myPoint.points--;
            Debug.Log(life.myPoint.points);

        }

        if (life.myPoint.points == 0){
            Debug.Log("You are dizzy now!");
        }
    }
}
