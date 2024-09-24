using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMove : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;

    public bool run = false;
    public bool idle = true;

    public Animator EnemyAnimator;


    // Start is called before the first frame update
    void Start()
    {
        // このスクリプトを設定したGameObjectのNavMeshAgentコンポーネントを取得
        navMeshAgent = this.gameObject.GetComponent<NavMeshAgent>();
    }

    // CollisionDetectorクラスに作ったonTriggerStayEventにセットする。
    public void OnDetectObject(Collider other)
    {
        // 検知したオブジェクトに"Player"タグが付いてれば、そのオブジェクトを追いかける
        if (other.tag == "Player")
        {
            // 対象のオブジェクトを追いかける
            navMeshAgent.destination = other.transform.position;
            EnemyAnimator.SetBool("run", true);
        }
    }

    // CollisionDetectorクラスに作ったonTriggerExitEventにセットする。 
    public void OnLoseObject(Collider other)
    {
        // 検知したオブジェクトに"Player"タグが付いてれば、その場で止まる
        if (other.tag == "Player")
        {
            // その場で止まる（目的地を今の自分自身の場所にすることにより止めている）
            navMeshAgent.destination = this.gameObject.transform.position;
            EnemyAnimator.SetBool("run", false);
        }
    }
}