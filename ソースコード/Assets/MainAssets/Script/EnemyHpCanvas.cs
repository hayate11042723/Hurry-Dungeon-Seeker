using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpCanvas : MonoBehaviour
{
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        // 敵のHPを常にカメラに向ける為の関数
        transform.rotation = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
