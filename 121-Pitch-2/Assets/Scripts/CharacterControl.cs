using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    public float spinSpeed;
    public float launchSpeed;
    private float side;
    public bool shooting;
    public Slider power;
    public Text time;
    public float timer = 30f;

    private void Start()
    {
        shooting = false;
        GetComponent<Rigidbody>().maxAngularVelocity = 100f;
    }
    private void FixedUpdate()
    {     
        side = Input.GetAxis("Horizontal");
        if (shooting == true)
        {
            timer -= Time.deltaTime;
            time.text = "Time Left: " +timer.ToString("F1");
            GetComponent<Rigidbody>().AddTorque(Vector3.forward * side * -spinSpeed, ForceMode.Acceleration);
            if(timer < 0)
            {
                transform.position = new Vector3(0, 2, -307);
                shooting = false;
                timer = 30f;
            }
        }
        else {
            power.value = Mathf.PingPong(Time.time * 40, 100);
            transform.position += new Vector3(side,0,0);
        }

    }
    private void OnMouseDown()
    {
        if(shooting == false)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * power.value * launchSpeed, ForceMode.Impulse);
            shooting = true;
        }

    }
}
