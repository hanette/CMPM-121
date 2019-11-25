using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private bool held;
    private void Update()
    {
        if (held == true){
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
    public Transform look;

    private void OnMouseDown(){
        held = true;
        if(transform.parent == null){
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = look.position;
            this.transform.parent = GameObject.Find("Look").transform;
        }
    }

    private void OnMouseUp(){
        held = false;
        if(transform.parent.name == "Look"){
            this.transform.parent = null;
        }
        GetComponent<Rigidbody>().useGravity = true;
    }
}
