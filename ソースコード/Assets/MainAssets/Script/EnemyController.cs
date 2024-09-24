using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float Timer;
    public float ChangeTime;
    public float EnemySpeed;

    GameObject Target;

    public bool ran = false;
    public bool walk = true;


    public Animator EnemyAnimator;


    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        var speed = Vector3.zero;
        speed.z = EnemySpeed;
        var rot = transform.eulerAngles;

        if (Target)
        {
            transform.LookAt(Target.transform);
            rot = transform.eulerAngles;
        }
        else
        {
            Timer += Time.deltaTime;
            if(ChangeTime <= Timer)
            {
                float rand = Random.Range(0, 360);
                rot.y = rand;
                Timer = 0;
            }
        }

        rot.x = 0;
        rot.z = 0;
        transform.eulerAngles = rot;

        this.transform.Translate(speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Target = other.gameObject;
            EnemyAnimator.SetBool("run", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Target = null;
            EnemyAnimator.SetBool("run", false);
        }
    }
}
