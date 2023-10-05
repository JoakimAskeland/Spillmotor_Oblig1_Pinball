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
}
