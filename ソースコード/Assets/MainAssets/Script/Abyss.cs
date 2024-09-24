using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abyss : MonoBehaviour
{
    public int x, y, z;

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.transform.Translate(x, y, z);
    }
}
