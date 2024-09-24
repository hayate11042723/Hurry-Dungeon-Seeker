using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // ゴール
    [SerializeField] Transform target;

    // カーソル
    [SerializeField] Transform cursor;

    // Update is called once per frame
    void Update()
    {
        cursor.LookAt(target);
    }
}
