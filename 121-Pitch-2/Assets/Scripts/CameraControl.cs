using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Vector2 finalLook;
    public GameObject player;
    private Vector2 mouseIN;
    public float sense = 1.0f;
    public float smooth = 3.0f;
    private Vector2 smoothMouse;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        player = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //get input and scale
        mouseIN = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mouseIN = Vector2.Scale(mouseIN, new Vector2(sense * smooth, sense * smooth));

        //interpolate and add step by step
        smoothMouse.x = Mathf.Lerp(smoothMouse.x, mouseIN.x, 1f / smooth);
        smoothMouse.y = Mathf.Lerp(smoothMouse.y, mouseIN.y, 1f / smooth);
        finalLook += smoothMouse;

        transform.localRotation = Quaternion.AngleAxis(-finalLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(finalLook.x, player.transform.up);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
