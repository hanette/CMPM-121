using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public Text scoreText;
    bool check1;
    bool check2;
    bool check3;
    bool check4;
    bool check5;
    bool check6;
    bool check7;
    bool check8;
    bool check9;
    bool check10;
    public int score;

    void Start(){
        score = 0;
        SetScoreText();
        check1 = false;
        check2 = false;
        check3 = false;
        check4 = false;
        check5 = false;
        check6 = false;
        check7 = false;
        check8 = false;
        check9 = false;
        check10 = false;
    }

    void Update() {
        if(GameObject.Find("PinCollider1").GetComponent<Fallen>().points == 1 && check1 == false){
            score += 1;
            check1 = true;
            SetScoreText();
        }
        if(GameObject.Find("PinCollider2").GetComponent<Fallen>().points == 1 && check2 == false){
            score += 1;
            check2 = true;
            SetScoreText();
        }
        if(GameObject.Find("PinCollider3").GetComponent<Fallen>().points == 1 && check3 == false){
            score += 1;
            check3 = true;
            SetScoreText();
        }
        if(GameObject.Find("PinCollider4").GetComponent<Fallen>().points == 1 && check4 == false){
            score += 1;
            check4 = true;
            SetScoreText();
        }
        if(GameObject.Find("PinCollider5").GetComponent<Fallen>().points == 1 && check5 == false){
            score += 1;
            check5 = true;
            SetScoreText();
        }
        if(GameObject.Find("PinCollider6").GetComponent<Fallen>().points == 1 && check6 == false){
            score += 1;
            check6 = true;
            SetScoreText();
        }
        if(GameObject.Find("PinCollider7").GetComponent<Fallen>().points == 1 && check7 == false){
            score += 1;
            check7 = true;
            SetScoreText();
        }
        if(GameObject.Find("PinCollider8").GetComponent<Fallen>().points == 1 && check8 == false){
            score += 1;
            check8 = true;
            SetScoreText();
        }
        if(GameObject.Find("PinCollider9").GetComponent<Fallen>().points == 1 && check9 == false){
            score += 1;
            check9 = true;
            SetScoreText();
        }
        if(GameObject.Find("PinCollider10").GetComponent<Fallen>().points == 1 && check10 == false){
            score += 1;
            check10 = true;
            SetScoreText();
        }
    }

    void SetScoreText (){
         scoreText.text = "Score: " + score.ToString ();
     }
}
