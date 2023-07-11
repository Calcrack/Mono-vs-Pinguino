using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossFINAL : MonoBehaviour
{
    public int BossCount;
    public int vida = 5000;
    public TMP_Text Vidaa;

    public AudioSource ASource;
    // Start is called before the first frame update
    void Start()
    {
        AudioClip audioClip = Resources.Load<AudioClip>("Musica/11");
        ASource.clip = audioClip;
        ASource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Vidaa.text = "Vida: " + vida;
    }
    public void BossFinal()
    {
        BossCount += 1;
        vida -= 10;
        if(BossCount == 500)
        {
            SceneManager.LoadScene("Final");
        }
    }
}
