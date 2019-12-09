using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReturn : MonoBehaviour
{
    public int reset;
    public bool resetPin;

    // Start is called before the first frame update
    void Start()
    {
        reset = 0;
        resetPin = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.transform.forward = Vector3.forward;
            other.GetComponent<CharacterControl>().shooting = false;
            other.transform.position = new Vector3(0, 2, -307);
            reset++;
            if(reset >= 2){
                reset = 0;
                resetPin = true;
            }
        }
    }
}
