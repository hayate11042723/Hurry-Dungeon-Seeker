using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript3 : MonoBehaviour
{
    int minute = TimerScript2.minute;
    float seconds = TimerScript2.seconds;
    //　タイマー表示用テキスト
    public static Text timerText;

    void Start()
    {
        timerText = GetComponentInChildren<Text>();
    }

    void Update()
    {
        timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");   
    }
}
