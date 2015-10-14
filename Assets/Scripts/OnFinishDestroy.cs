using UnityEngine;
using System.Collections;

public class OnFinishDestroy : MonoBehaviour {

    void OnDestroy()
    {
        addHighscoreToDB();
    }

    void addHighscoreToDB()
    {
        // connect to db and insert highscore record
        Debug.Log("Highscore posted");
    }
}
