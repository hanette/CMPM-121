using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallen : MonoBehaviour {
    public int points;

    void Start(){
        points = 0;
    }

    void Update(){
        if(transform.position.y <= 0.7f){
            points = 1;
        }
    }
}
