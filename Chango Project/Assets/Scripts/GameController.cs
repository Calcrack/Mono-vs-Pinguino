using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Variables VB;
    public List<LevelSO> ListLevelSO;
    public LevelSelector LS;
    public ShopController SC;

    public TMP_Text Level;
    public TMP_Text Counter;
    public TMP_Text MoneyTMP;

    public RawImage MonoIMG;
    // Start is called before the first frame update
    void Start()
    {
        LS.SelectorLevel();
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < ListLevelSO.Count; i++)
        {
            Level.text = "Nivel: " + VB.LevelV;
            Counter.text = "XP: " + VB.MonoClick + "\nNext Level: " + ListLevelSO[i].MaxClickLevel;
            MoneyTMP.text = "Dinero: " + VB.Money;
        }
    }
    public void TrainMono()
    {
        VB.MonoClick += VB.TrainPower;
        for (int i = 0; i < ListLevelSO.Count; i++)
        {
            if (VB.MonoClick >= ListLevelSO[i].MaxClickLevel)
            {
                VB.MonoClick = 0;
                VB.InternalMonoClick += 1;
                VB.LevelV += 1;
                LS.SelectorLevel();
            }
        }
    }
}
