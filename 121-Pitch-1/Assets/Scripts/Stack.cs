using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour {
    public GameObject bun;
    float stack;

    void Start() {
        stack = 0;
    }

    void Update() {

    }

    void OnCollisionEnter(Collision other){
        if (other.gameObject.name == "Lettuce"){
            other.transform.position = bun.transform.position;

            if (stack == 0){
                other.transform.position += new Vector3(0f, 0.1f, 0f);
            } else if (stack == 1){
                other.transform.position += new Vector3(0f, 0.2f, 0f);
            } else if (stack == 2){
                other.transform.position += new Vector3(0f, 0.3f, 0f);
            } else if (stack == 3){
                other.transform.position += new Vector3(0f, 0.4f, 0f);
            } else if (stack == 4){
                other.transform.position += new Vector3(0f, 0.5f, 0f);
            }

            other.transform.parent = bun.transform;
            other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            stack += 1;
        }

        if (other.gameObject.name == "Tomato"){
            other.transform.position = bun.transform.position;

            if (stack == 0){
                other.transform.position += new Vector3(0f, 0.1f, 0f);
            } else if (stack == 1){
                other.transform.position += new Vector3(0f, 0.2f, 0f);
            } else if (stack == 2){
                other.transform.position += new Vector3(0f, 0.3f, 0f);
            } else if (stack == 3){
                other.transform.position += new Vector3(0f, 0.4f, 0f);
            } else if (stack == 4){
                other.transform.position += new Vector3(0f, 0.5f, 0f);
            }

            other.transform.parent = bun.transform;
            other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            stack += 1;
        }
        if (other.gameObject.name == "Cheese"){
            other.transform.position = bun.transform.position;

            if (stack == 0){
                other.transform.position += new Vector3(0f, 0.1f, 0f);
            } else if (stack == 1){
                other.transform.position += new Vector3(0f, 0.2f, 0f);
            } else if (stack == 2){
                other.transform.position += new Vector3(0f, 0.3f, 0f);
            } else if (stack == 3){
                other.transform.position += new Vector3(0f, 0.4f, 0f);
            } else if (stack == 4){
                other.transform.position += new Vector3(0f, 0.5f, 0f);
            }

            other.transform.parent = bun.transform;
            other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            stack += 1;
        }
        if (other.gameObject.name == "Meat"){
            other.transform.position = bun.transform.position;

            if (stack == 0){
                other.transform.position += new Vector3(0f, 0.1f, 0f);
            } else if (stack == 1){
                other.transform.position += new Vector3(0f, 0.2f, 0f);
            } else if (stack == 2){
                other.transform.position += new Vector3(0f, 0.3f, 0f);
            } else if (stack == 3){
                other.transform.position += new Vector3(0f, 0.4f, 0f);
            } else if (stack == 4){
                other.transform.position += new Vector3(0f, 0.5f, 0f);
            }

            other.transform.parent = bun.transform;
            other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
            stack += 1;
        }
    }

}
