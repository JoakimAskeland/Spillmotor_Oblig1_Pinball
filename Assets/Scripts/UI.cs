using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    private float timer = 0;
    private int score = 0;

    [SerializeField] private TMP_Text timeText;
    [SerializeField] private TMP_Text scoreText;

    private void Start()
    {
        scoreText.text = "Score: " + score.ToString("f0");
    }

    private void FixedUpdate()
    {
        // Showing time in 2 decimals
        timeText.text = "Time: " + timer.ToString("f2");
        timer += Time.deltaTime;
    }

    public void newScore(int plus)
    {
        score += plus;
        scoreText.text = "Score: " + score.ToString("f0");
    }



    //public Text timeText;
    //public Text scoreText;

    //private float timeGone = 0f;
    //private int score = 0;

    //// Update is called once per frame
    //void Update()
    //{
    //    timeGone += Time.deltaTime;
    //    timeText.text = "Time: " + Mathf.Round(timeGone).ToString();

    //    scoreText.text = "Score: " + score.ToString();
    //}

    //public static int totalScore = 0;
    //public BumpSC totalScore;

    //public GameObject Bumper0;

    private void OnGUI()
    {
        //float totalScore = BumpSC.Instance.score;
        //int valueFromBumpSC = totalScore.score;

        //Bumper0 = GameObject.Find("Bumper");
        //int scoreBumper0 = Bumper0.GetComponent<>
        //int totalScore = 

        //GUI.Box(new Rect(100, 100, 200, 100), "Score: " + valueFromBumpSC);
        //GUI.Box(new Rect(100, 100, 200, 100), "Score: " + BumpSC.Instance.score);
    }

}
