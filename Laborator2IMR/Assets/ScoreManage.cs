using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManage : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            // Increase the score when the sphere hits the plane
            score++;
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        // Update the UI text to display the current score
        scoreText.text = "Score: " + score.ToString();
    }
}