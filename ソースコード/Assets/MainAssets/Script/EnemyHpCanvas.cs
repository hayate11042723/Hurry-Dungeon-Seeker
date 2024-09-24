using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpCanvas : MonoBehaviour
{
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        // “G‚ÌHP‚ğí‚ÉƒJƒƒ‰‚ÉŒü‚¯‚éˆ×‚ÌŠÖ”
        transform.rotation = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
