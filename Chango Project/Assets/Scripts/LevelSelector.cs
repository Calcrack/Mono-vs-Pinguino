using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public GameController GC;
    public Variables VB;
    public int InternalLevel;
    public void SelectorLevel()
    {
        if (VB.InternalMonoClick == 0)
        {
            VB.Level = Resources.Load<LevelSO>("Level/Level0");
            GC.ListLevelSO.Add(VB.Level as LevelSO);
        }
        if (VB.InternalMonoClick == 1)
        {
            GC.ListLevelSO.Remove(VB.Level as LevelSO);
            VB.Level = Resources.Load<LevelSO>("Level/Level1");
            GC.ListLevelSO.Add(VB.Level as LevelSO);
        }
        if (VB.InternalMonoClick == 2)
        {
            GC.ListLevelSO.Remove(VB.Level as LevelSO);
            VB.Level = Resources.Load<LevelSO>("Level/Level2");
            GC.ListLevelSO.Add(VB.Level as LevelSO);
        }
        if (VB.InternalMonoClick == 3)
        {
            GC.ListLevelSO.Remove(VB.Level as LevelSO);
            VB.Level = Resources.Load<LevelSO>("Level/Level3");
            GC.ListLevelSO.Add(VB.Level as LevelSO);
        }
        if (VB.InternalMonoClick == 4)
        {
            GC.ListLevelSO.Remove(VB.Level as LevelSO);
            VB.Level = Resources.Load<LevelSO>("Level/Level4");
            GC.ListLevelSO.Add(VB.Level as LevelSO);
        }
    }
}