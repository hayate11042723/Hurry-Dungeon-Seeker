using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpMove : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Warp());
    }

    private IEnumerator Warp()
    {
        while (true)
        {
            // 5ïbå„Ç≤Ç∆Ç…ÉèÅ[Évà⁄ìÆÇ∑ÇÈÅB
            yield return new WaitForSeconds(10.0f);
            transform.position = new Vector3(1040, 355, 540);

            yield return new WaitForSeconds(10.0f);
            transform.position = new Vector3(600, 240, -990);

            yield return new WaitForSeconds(10.0f);
            transform.position = new Vector3(100, 60, -40);
        }
    }
}