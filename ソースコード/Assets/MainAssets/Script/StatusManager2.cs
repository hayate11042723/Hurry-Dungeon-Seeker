using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager2 : MonoBehaviour
{
    public GameObject Main;
    public int HP;
    public int MaxHP;
    public float ResetTime = 0;
    public Image HPGage;

    public GameObject Effect;
    public AudioSource audioSource;
    public AudioClip HitSE;
    new Collider collider;

    public string TagName;

    private GameObject scoreText;

    void Start()
    {
        collider = GetComponent<Collider>();
        scoreText = GameObject.Find("Score");
    }
    public void Update()
    {
        if (HP <= 0)
        {
            HP = 0;
            var effect = Instantiate(Effect);
            effect.transform.position = transform.position;
            Destroy(effect, 5);
            Destroy(Main);
            scoreText.GetComponent<ScoreManager>().score = scoreText.GetComponent<ScoreManager>().score + 1;
        }

        float percent = (float)HP / MaxHP;
        HPGage.fillAmount = percent;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == TagName)
        {
            Damage();
            collider.enabled = false;
            Invoke("ColliderReSet", ResetTime);
        }
    }

    void Damage()
    {
        audioSource.PlayOneShot(HitSE);
        HP--;
    }

    void ColliderReSet()
    {
        collider.enabled = true;
    }
}
