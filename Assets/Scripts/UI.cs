using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text timeText;
    public Text scoreText;

    private float timeGone = 0f;
    private int score = 0;

    // Update is called once per frame
    void Update()
    {
        timeGone += Time.deltaTime;
        timeText.text = "Time: " + Mathf.Round(timeGone).ToString();

        scoreText.text = "Score: " + score.ToString();
    }
}
