using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour {
    public Material Cooked;
    public GameObject Meat;
    public bool isCooked;
    bool TimerOn;
    float seconds;
    float timeLeft = 10.0f; // 10 seconds
    float curTime;

    void Start(){
         TimerOn = false;
         isCooked = false;
         curTime = 0.0f;
     }

     void Update(){
             if (TimerOn){
                 curTime += .01f;
                 seconds = (int)(curTime % 60f);
             }
             if(curTime >= timeLeft){
                 Meat.GetComponent<MeshRenderer>().material = Cooked;
                 isCooked = true;
             }
     }

     public void OnCollisionExit(){
         TimerOn = false;
     }

    void OnCollisionEnter(Collision other){
        if (other.gameObject.name == "Meat"){
            TimerOn = true;
        }
    }
}
