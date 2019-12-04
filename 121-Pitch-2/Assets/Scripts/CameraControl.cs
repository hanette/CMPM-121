using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public float followDistance;
    public float height;
    private Transform camTransform;

    // Start is called before the first frame update
    void Start()
    {
        camTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        camTransform.position = new Vector3(target.position.x, target.position.y + height, target.position.z - followDistance);
        camTransform.LookAt(target);
    }
}
