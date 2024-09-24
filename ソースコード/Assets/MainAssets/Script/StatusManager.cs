using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
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
    private GameObject scoreText2;

    void Start()
    {
        collider = GetComponent<Collider>();
        scoreText = GameObject.Find("Score");
        scoreText2 = GameObject.Find("Score2");
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
            scoreText2.GetComponent<ScoreManager>().score = scoreText2.GetComponent<ScoreManager>().score + 1;
        }

        float percent = (float)HP / MaxHP;
        HPGage.fillAmount = percent;
    }

    // ƒ_ƒ[ƒW‚ğó‚¯‚éˆ—
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == TagName)
        {
            Damage();
            collider.enabled = false;
            Invoke("ColliderReSet", ResetTime);
        }
    }

    // HP‚ÌŒ¸‚éˆ—
    void Damage()
    {
        audioSource.PlayOneShot(HitSE);
        HP--;
    }

    // –³“GŠÔ
    void ColliderReSet()
    {
        collider.enabled = true;
    }
}
