using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ScoreKeep : MonoBehaviour {

    public static int score;
    public Text scoreText;

	// Use this for initialization
	

    void Start()
    {
        score = 0;
        GameObject temp = GameObject.FindWithTag("scoreText");

        if (temp != null)
        {
            Debug.Log("Found scoreText");
            scoreText = temp.GetComponent<Text>();
        }
        else
            Debug.Log("CAN'T FIND SCORETEXT??");
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = score.ToString();
	}

    public void AddScore(int toAdd)
    {
        score += toAdd;
    }

    public void UpdateScore()
    {
        
    }

    public int getScore()
    {
        return score;
    }
}
