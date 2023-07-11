using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    public Variables VB;
    public GameController GC;
    public List<ArmorSO> ASO;
    public TMP_Text Name;
    public TMP_Text Price;

    // Start is called before the first frame update
    void Start()
    {

        VB.ArmorObject = Resources.Load<ArmorSO>("Armor/Armor1");
        ASO.Add(VB.ArmorObject as ArmorSO);
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < ASO.Count; i++)
        {
            Name.text = "" + ASO[i].Name;
            Price.text = "Precio: " + ASO[i].Price + " Nivel: " + ASO[i].Level;
        }
    }
    public void ComprarArmor()
    {
        for (int i = 0; i < ASO.Count; i++)
        {
            if (VB.Armor < 12 && ASO[i].Level <= VB.LevelV && VB.Money >= ASO[i].Price)
            {
                GC.MonoIMG.texture = (Texture)Resources.Load("Sprites/Mono" + VB.Armor.ToString());
                VB.Money -= ASO[i].Price;
                VB.Armor++;
                VB.LevelV += VB.Armor;

                ASO.Remove(VB.ArmorObject as ArmorSO);
                VB.ArmorObject = Resources.Load<ArmorSO>("Armor/Armor" + VB.Armor.ToString());
                ASO.Add(VB.ArmorObject as ArmorSO);
                break;
            }
        }
    }


}
