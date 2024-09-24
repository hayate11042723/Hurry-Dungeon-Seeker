using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class SceneScript : MonoBehaviour
{
    private ScoreManager scoreManager;

    public string Scene;
    public int Score;

    void Start()
    {
        scoreManager = GameObject.Find("Score").GetComponent<ScoreManager>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ExitPortal"))
        {
            if (scoreManager.score >= Score)
            {
                SceneManager.LoadScene(Scene); // ‚±‚±‚Åw’è‚µ‚½ƒV[ƒ“‚É‘JˆÚ
            }
        }
    }
}
