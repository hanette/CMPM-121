using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackChild : MonoBehaviour
{
    float stacks;

    void Start() {
        stacks = GameObject.Find("Bun").GetComponent<Stack>().stack;
    }

    void Update() {
        stacks = GameObject.Find("Bun").GetComponent<Stack>().stack;
    }

    void OnCollisionEnter(Collision other){
        stacks = GameObject.Find("Bun").GetComponent<Stack>().stack;
        if(transform.parent == null){}
        else if(transform.parent.name == "Bun" && other.transform.parent == null){
            print(stacks);
            if (other.gameObject.name == "Lettuce"){
                other.transform.position = transform.parent.transform.position;
                other.transform.position += new Vector3(0f, 0.1f*stacks, 0f);
                other.transform.parent = transform.parent.transform;
                other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
                GameObject.Find("Bun").GetComponent<Stack>().stack += 1;
            }

            if (other.gameObject.name == "Tomato"){
                other.transform.position = transform.parent.transform.position;
                other.transform.position += new Vector3(0f, 0.1f*stacks, 0f);
                other.transform.parent = transform.parent.transform;
                other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
                GameObject.Find("Bun").GetComponent<Stack>().stack += 1;
            }
            if (other.gameObject.name == "Cheese"){
                other.transform.position = transform.parent.transform.position;
                other.transform.position += new Vector3(0f, 0.1f*stacks, 0f);
                other.transform.parent = transform.parent.transform;
                other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
                GameObject.Find("Bun").GetComponent<Stack>().stack += 1;
            }
            if (other.gameObject.name == "Meat" && GameObject.Find("Stove").GetComponent<Cooking>().isCooked){
                other.transform.position = transform.parent.transform.position;
                other.transform.position += new Vector3(0f, 0.1f*stacks, 0f);
                other.transform.parent = transform.parent.transform;
                other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
                GameObject.Find("Bun").GetComponent<Stack>().stack += 1;
            } else if(other.gameObject.name == "Meat"){
                print("Needs to be cooked");
            }
            if (other.gameObject.name == "BunTop"){
                other.transform.position = transform.parent.transform.position;
                other.transform.position += new Vector3(0f, 0.1f*stacks, 0f);
                other.transform.parent = transform.parent.transform;
                other.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
                GameObject.Find("Bun").GetComponent<Stack>().stack += 1;
            }
        }
    }
}
