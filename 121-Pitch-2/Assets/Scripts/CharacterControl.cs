using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 10f;
    private float forward;
    private float side;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        side = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(side, 0, forward);
    }
}
