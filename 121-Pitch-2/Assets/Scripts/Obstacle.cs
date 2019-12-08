using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 10);
        if (transform.position.x > 30)
        {
            transform.position = new Vector3(-30f, -1f, -30.6f);
        }
    }
}
