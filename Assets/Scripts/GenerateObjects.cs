using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateObjects : MonoBehaviour {

    public GameObject toGenerate;
    public List<Transform> SpawnPoints;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateObject", 1.5f, 2f);
	}


    void GenerateObject()
    {
        int pos = Random.Range(0, SpawnPoints.Count);
        if (SpawnPoints[pos].transform.childCount == 0)
        {
            var instanciatedObj = Instantiate(toGenerate);
            instanciatedObj.transform.parent = SpawnPoints[pos].transform;
            instanciatedObj.transform.position = SpawnPoints[pos].transform.position;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
