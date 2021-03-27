using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text lblscore;
    private static int scorenum;
    // Start is called before the first frame update
    void Start()
    {
        lblscore = GetComponent<Text>();
        scorenum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        lblscore.text = "Score: " + scorenum;
    }

    public static void AddScore()
    {
        scorenum = 1 + scorenum;
    }
}
