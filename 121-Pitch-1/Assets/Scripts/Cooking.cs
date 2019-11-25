using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour {
    public Material Cooked;
    public GameObject Meat;
    public bool isCooked;
    bool TimerOn;
    float seconds;
    float timeLeft = 5.0f; // 5 seconds
    float curTime;
    bool printOnce;

    void Start(){
         TimerOn = false;
         isCooked = false;
         printOnce = true;
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

                 if(printOnce){ // debug
                     printOnce = false;
                     print("cooked");
                 }
             }
     }

     public void OnCollisionExit(Collision other){
         if (other.gameObject.name == "Meat"){
             TimerOn = false;
         }
     }

    void OnCollisionEnter(Collision other){
        if (other.gameObject.name == "Meat"){
            TimerOn = true;
        }
    }
}
