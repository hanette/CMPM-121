using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    public float speed;
    private float side;
    public bool shooting;
    public Slider power;

    private void Start()
    {
        shooting = false;
        GetComponent<Rigidbody>().maxAngularVelocity = 100f;
    }
    private void FixedUpdate()
    {
        power.value = Mathf.PingPong(Time.time * 40, 100);
        side = Input.GetAxis("Horizontal");
        if (shooting == true)
        {
            GetComponent<Rigidbody>().AddTorque(Vector3.forward * side * -speed, ForceMode.Acceleration);
        }
    }
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * power.value * 5f, ForceMode.Impulse);
        shooting = true;
    }
}
