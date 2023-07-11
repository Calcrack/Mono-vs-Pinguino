using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public double MonoClick = 0;
    public double InternalMonoClick = 0;
    public double TrainPower = 1;
    public double LevelV = 0;
    public double InternalLevelV = 0;
    public double Money = 0;
    public double Armor;

    public System.Object Level;
    public System.Object ArmorObject;
    public System.Object EnemyObject;
    // Start is called before the first frame update
    void Start()
    {
        Armor = 1;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
