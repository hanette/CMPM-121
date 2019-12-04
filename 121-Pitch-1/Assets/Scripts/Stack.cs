using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour {
    public GameObject bun;
    public float stack;

    void Start() {
        stack = 1;
    }

    void Update() {
    }

    void OnCollisionEnter(Collision other){
        print("inside parent");
        if (other.gameObject.name == "Lettuce"){
            other.transform.position = bun.transform.position;
            other.transform.position += new Vector3(0f, 0.1f*stack, 0f);
            other.transform.parent = bun.transform;
            other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            stack += 1;
        }

        if (other.gameObject.name == "Tomato"){
            other.transform.position = bun.transform.position;
            other.transform.position += new Vector3(0f, 0.1f*stack, 0f);
            other.transform.parent = bun.transform;
            other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            stack += 1;
        }
        if (other.gameObject.name == "Cheese"){
            other.transform.position = bun.transform.position;
            other.transform.position += new Vector3(0f, 0.1f*stack, 0f);
            other.transform.parent = bun.transform;
            other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            stack += 1;
        }
        if (other.gameObject.name == "Meat" && GameObject.Find("Stove").GetComponent<Cooking>().isCooked){
            other.transform.position = bun.transform.position;
            other.transform.position += new Vector3(0f, 0.1f*stack, 0f);
            other.transform.parent = bun.transform;
            other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            stack += 1;
        } else if(other.gameObject.name == "Meat"){
            print("Needs to be cooked");
        }
        if (other.gameObject.name == "BunTop"){
            other.transform.position = bun.transform.position;
            other.transform.position += new Vector3(0f, 0.1f*stack, 0f);
            other.transform.parent = bun.transform;
            other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            stack += 1;
        }
    }

}
