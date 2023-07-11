using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Armor", menuName = "SO/Armor")]
public class ArmorSO : ScriptableObject
{
    public double Price;
    public double Level;
    public string Name;
}