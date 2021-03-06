﻿using UnityEngine;
using System.Collections;

public class TriggerColission : MonoBehaviour
{
    public GameObject gameController;
    CountScore countScore;
    public int cubeValue = 10;

    void Start()
    {
        countScore = gameController.GetComponent<CountScore>();
    }
    void OnTriggerEnter(Collider other)
    {
        var otherGameObject = other.gameObject;
        switch (otherGameObject.tag)
        {
            case "Score":
                Debug.Log("Score!");
                countScore.AddScore(cubeValue);
                Destroy(otherGameObject);
                break;
            case "Finish":
                countScore.scoreText.text = "Finished!";
                Debug.Log("Finished!");
                Destroy(otherGameObject);
                break;
            default:
                break;

        }
    }
}
