using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
    public Text scoreText;
    public Text resetting;
    public GameObject pin1;
    public GameObject pin2;
    public GameObject pin3;
    public GameObject pin4;
    public GameObject pin5;
    public GameObject pin6;
    public GameObject pin7;
    public GameObject pin8;
    public GameObject pin9;
    public GameObject pin10;
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
    bool waited;
    public int score;

    void Start(){
        if(PlayerPrefs.GetInt("scores") == 0){
            score = 0;
        } else {
            score = PlayerPrefs.GetInt("scores");
        }

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
        waited = false;
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
        if(GameObject.Find("BallReturn").GetComponent<BallReturn>().resetPin){
            StartCoroutine(wait());
        }
        // reset
        if(GameObject.Find("BallReturn").GetComponent<BallReturn>().resetPin && waited){
            PlayerPrefs.SetInt("scores", score);
            Application.LoadLevel("SampleScene");
        }
    }

    void SetScoreText (){
         scoreText.text = "Score: " + score.ToString ();
     }

     void SetResetText (){
          resetting.text = "Resetting Pins...";
      }

     void OnApplicationQuit(){
       PlayerPrefs.SetInt("scores", 0);
   }

   IEnumerator wait(){
       SetResetText();
       yield return new WaitForSeconds(2.0f);
       waited = true;
   }

}
