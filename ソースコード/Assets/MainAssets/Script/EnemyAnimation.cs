using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    public bool attack = false;

    public Animator EnemyAnimator;

    GameObject Target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Target = other.gameObject;
            EnemyAnimator.SetBool("attack", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Target = null;
            EnemyAnimator.SetBool("attack", false);
        }
    }
}
