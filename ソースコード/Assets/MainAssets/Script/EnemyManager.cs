using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;

    public Transform EnemyPlace1;
    public Transform EnemyPlace2;

    float TimeCount;

    public int Count;
    public int MaxCount;

    [SerializeField]
    private GameObject createPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(MaxCount <= Count)
        {
            return;
        }

        TimeCount += Time.deltaTime;
        // 約1秒置きにランダムに生成されるようにする。
        if (TimeCount > 1.0f)
        {
            // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
            float x = Random.Range(EnemyPlace1.position.x, EnemyPlace2.position.x);
            // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
            float y = Random.Range(EnemyPlace1.position.y, EnemyPlace2.position.y);
            // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
            float z = Random.Range(EnemyPlace1.position.z, EnemyPlace2.position.z);

            // GameObjectを上記で決まったランダムな場所に生成
            Instantiate(Enemy1, new Vector3(x, y, z),Enemy1.transform.rotation);
            Count++;
            // GameObjectを上記で決まったランダムな場所に生成
            Instantiate(Enemy2, new Vector3(x, y, z), Enemy2.transform.rotation);
            Count++;

            // 経過時間リセット
            TimeCount = 0f;
        }
    }
}
