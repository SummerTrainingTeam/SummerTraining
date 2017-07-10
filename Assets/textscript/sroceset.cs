using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sroceset : MonoBehaviour {

    public Text ScoreText;
    public int score = 0;
    // Use this for initialization

    void Start () {
        ScoreText = GameObject.Find("Canvas/Score").GetComponent<Text>();
	}
	
    void Show()
    {
        ScoreText.text = "Score : " + score;
    }

	// Update is called once per frame
	void Update () {
        Show();
	}
}
