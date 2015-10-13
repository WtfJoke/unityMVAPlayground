using UnityEngine;
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
        if (other.gameObject.tag == "Score")
        {
            Debug.Log("Score!");
            countScore.AddScore(cubeValue);
            Destroy(other.gameObject);
        }
    }
}
