using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript2 : MonoBehaviour
{
    [SerializeField]
    public static int minute;
    [SerializeField]
    public static float seconds;
    //　前のUpdateの時の秒数
    public static float oldSeconds;
    //　タイマー表示用テキスト
    public static Text timerText;

    void Start()
    {
        timerText = GetComponentInChildren<Text>();
    }

    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }
        //　値が変わった時だけテキストUIを更新
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
    }
}
