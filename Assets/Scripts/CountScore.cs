using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountScore : MonoBehaviour {

    public Text scoreText;
    int score;



	void Start () {
        score = 0;
        Debug.Log("Score reset to " + score);
	}
	
    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
        Debug.Log("Score: " + score);

    }

    public int GetCurrentScore()
    {
        return score;
    }

	// Update is called once per frame
	void Update () {
	
	}
}
