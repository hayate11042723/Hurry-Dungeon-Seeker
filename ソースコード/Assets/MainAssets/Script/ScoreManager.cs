using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text scoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponentInChildren<Text>();
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

 
}
