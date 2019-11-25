using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    private bool held;
    public bool shooting;
    public Slider power;

    private void Start()
    {
        held = false;
        shooting = false;
        GetComponent<Rigidbody>().maxAngularVelocity = 100f;
    }
    private void FixedUpdate()
    {
        if (held == true)
        {
            //GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
        if (shooting == true)
        {
            power.value = Mathf.PingPong(Time.time * 40, 100);
            GetComponent<Rigidbody>().AddRelativeTorque(transform.forward * 100f, ForceMode.Acceleration);
        }
    }
    public Transform look;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            held = true;
            //GetComponent<BoxCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            this.transform.position = look.position;
            this.transform.parent = GameObject.Find("Look").transform;
            transform.forward = GameObject.Find("Look").transform.forward;
        }
    }


    private void OnMouseDown()
    {
        if (shooting == true)
        {
            held = false;
            shooting = false;
            this.transform.parent = null;
            //GetComponent<BoxCollider>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().AddForce(transform.forward * power.value, ForceMode.Impulse);
        }

        if (held == true)
        {
            shooting = true;
        }



    }

}
