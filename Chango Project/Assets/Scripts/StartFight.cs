using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartFight : MonoBehaviour
{
    public GameController GC;
    public Variables VB;
    public List<EnemySO> ESO;
    public ShopController SC;
    public int Enemy;
    public TMP_Text NameEnemy;
    public TMP_Text LevelEnemy;
    public RawImage EnemyIMG;
    public AudioSource ASource;

    public TMP_Text WL;
    // Start is called before the first frame update
    void Start()
    {
        VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino1");
        ESO.Add(VB.EnemyObject as EnemySO);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < ESO.Count; i++)
        {
            NameEnemy.text = "" + ESO[i].NameEnemy;
            LevelEnemy.text = "Nivel: " + ESO[i].LevelEnemy;
        }
    }
    public void StartFights()
    {
        CancelInvoke("ClearText");
        if (VB.LevelV == 0)
        {
            WL.text = "Necesitas ser minimo de nivel 1!";
            Invoke("ClearText", 1f);
        }
        else
        {
            int i = 0;
            while (i < ESO.Count)
            {
                if (VB.LevelV > ESO[i].LevelEnemy)
                {
                    VB.Money += ESO[i].DineroWin;
                    WL.text = "Ganaste";
                    Invoke("ClearText", 1f);
                    switch (Enemy)
                    {
                        case 0:
                            EnemyIMG.texture = (Texture)Resources.Load("Sprites/Pinguino2");
                            ESO.Remove(VB.EnemyObject as EnemySO);
                            VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino2");
                            ESO.Add(VB.EnemyObject as EnemySO);
                            AudioClip audioClip = Resources.Load<AudioClip>("Musica/1");
                            ASource.clip = audioClip;
                            ASource.Play();
                            break;
                        case 1:
                            ESO.Remove(VB.EnemyObject as EnemySO);
                            VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino3");
                            ESO.Add(VB.EnemyObject as EnemySO);
                            EnemyIMG.texture = (Texture)Resources.Load("Sprites/Pinguino3");
                            audioClip = Resources.Load<AudioClip>("Musica/2");
                            ASource.clip = audioClip;
                            ASource.Play();
                            break;
                        case 2:
                            ESO.Remove(VB.EnemyObject as EnemySO);
                            VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino4");
                            ESO.Add(VB.EnemyObject as EnemySO);
                            EnemyIMG.texture = (Texture)Resources.Load("Sprites/Pinguino4");
                            audioClip = Resources.Load<AudioClip>("Musica/3");
                            ASource.clip = audioClip;
                            ASource.Play();
                            break;
                        case 3:
                            ESO.Remove(VB.EnemyObject as EnemySO);
                            VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino5");
                            ESO.Add(VB.EnemyObject as EnemySO);
                            EnemyIMG.texture = (Texture)Resources.Load("Sprites/Pinguino5");
                            audioClip = Resources.Load<AudioClip>("Musica/4");
                            ASource.clip = audioClip;
                            ASource.Play();
                            break;
                        case 4:
                            ESO.Remove(VB.EnemyObject as EnemySO);
                            VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino6");
                            ESO.Add(VB.EnemyObject as EnemySO);
                            EnemyIMG.texture = (Texture)Resources.Load("Sprites/Pinguino6");
                            audioClip = Resources.Load<AudioClip>("Musica/5");
                            ASource.clip = audioClip;
                            ASource.Play();
                            break;
                        case 5:
                            ESO.Remove(VB.EnemyObject as EnemySO);
                            VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino7");
                            ESO.Add(VB.EnemyObject as EnemySO);
                            EnemyIMG.texture = (Texture)Resources.Load("Sprites/Pinguino7");
                            audioClip = Resources.Load<AudioClip>("Musica/6");
                            ASource.clip = audioClip;
                            ASource.Play();
                            break;
                        case 6:
                            ESO.Remove(VB.EnemyObject as EnemySO);
                            VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino8");
                            ESO.Add(VB.EnemyObject as EnemySO);
                            EnemyIMG.texture = (Texture)Resources.Load("Sprites/Pinguino8");
                            audioClip = Resources.Load<AudioClip>("Musica/7");
                            ASource.clip = audioClip;
                            ASource.Play();
                            break;
                        case 7:
                            ESO.Remove(VB.EnemyObject as EnemySO);
                            VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino9");
                            ESO.Add(VB.EnemyObject as EnemySO);
                            EnemyIMG.texture = (Texture)Resources.Load("Sprites/Pinguino9");
                            audioClip = Resources.Load<AudioClip>("Musica/8");
                            ASource.clip = audioClip;
                            ASource.Play();
                            break;
                        case 8:
                            ESO.Remove(VB.EnemyObject as EnemySO);
                            VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino10");
                            ESO.Add(VB.EnemyObject as EnemySO);
                            EnemyIMG.texture = (Texture)Resources.Load("Sprites/Pinguino10");
                            audioClip = Resources.Load<AudioClip>("Musica/9");
                            ASource.clip = audioClip;
                            ASource.Play();
                            break;
                        case 9:
                            ESO.Remove(VB.EnemyObject as EnemySO);
                            VB.EnemyObject = Resources.Load<EnemySO>("Enemy/Pinguino11");
                            ESO.Add(VB.EnemyObject as EnemySO);
                            EnemyIMG.texture = (Texture)Resources.Load("Sprites/Pinguino11");
                            audioClip = Resources.Load<AudioClip>("Musica/10");
                            ASource.clip = audioClip;
                            ASource.Play();
                            VB.LevelV = 666;
                            VB.Money = 666;
                            SC.ASO.Remove(VB.ArmorObject as ArmorSO);
                            VB.ArmorObject = Resources.Load<ArmorSO>("Armor/Armor" + VB.Armor.ToString());
                            SC.ASO.Add(VB.ArmorObject as ArmorSO);
                            Invoke("ChangeScene", 9f);

                            break;
                        default:
                            WL.text = "No hay más enemigos";
                            Invoke("ClearText", 1f);
                            break;
                    }
                    Enemy += 1;
                }
                else
                {
                    WL.text = "Perdiste";
                    Invoke("ClearText", 1f);
                }
                i++;
            }
        }
    }


    void ChangeScene()
    {
        SceneManager.LoadScene("Pelea Final");
    }
    public void ClearText()
    {
        WL.text = "";
    }

}
