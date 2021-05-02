using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPercent : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        ///Declaration of constants and variables

        const int MaxScore = 100;
        int Score = 83;
        float Percent = (float)Score / MaxScore;

        ///Output
        print("Percentage : " + Percent + "%");
	}
	
	
}
