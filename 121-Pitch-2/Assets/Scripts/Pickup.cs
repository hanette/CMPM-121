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
            power.value = Mathf.PingPong(Time.time * 40, 100);
            //GetComponent<Rigidbody>().AddRelativeTorque(transform.forward * 100f, ForceMode.Acceleration);

    }
    private void OnMouseDown()
    {
            GetComponent<Rigidbody>().AddForce(transform.forward * power.value * 5f, ForceMode.Impulse);
    }

}
