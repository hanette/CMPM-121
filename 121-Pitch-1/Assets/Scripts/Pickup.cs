using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private bool held;
    private void Update()
    {
        if (held == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }      
    }
    public Transform look;

    private void OnMouseDown()
    {
        held = true;
        //GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        this.transform.position = look.position;
        this.transform.parent = GameObject.Find("Look").transform;
    }

    private void OnMouseUp()
    {
        held = false;
        this.transform.parent = null;
        //GetComponent<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
