using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
