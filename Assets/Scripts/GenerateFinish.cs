using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GenerateFinish : MonoBehaviour {

    public GameObject finishObjectToGenerate;
    public GameObject finishSpawnPoint;
    public int neededPointsToFinish = 30;
    private CountScore countScore;
    private bool isGenerated;

    // Use this for initialization
    void Start () {
        countScore = GetComponent<CountScore>();
        isGenerated = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!isGenerated && countScore.GetCurrentScore() >= neededPointsToFinish)
        {
            var finish = Instantiate(finishObjectToGenerate);
            finish.transform.position = finishSpawnPoint.transform.position;
            isGenerated = true;
        }
	
	}
}
