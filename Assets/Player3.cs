using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI Info;

    string Name = "Enzo Villarin";
    int Age = 16;
    string Race = "Asian";
    int PhysicalDamage = 65;
    int Armor = 50;
    int MagicDamage = 90;
    int MagicResistance = 95;
    float Speed = 55;

    public void ButtonThreePressed()
    {
        Info.text = "Player Info: \r\n \r\nName: " + Name + "\r\nAge " + Age + "\r\nRace" + Race + "\r\nPhysicalDamage: " + PhysicalDamage + "\r\nArmor " + Armor + "\r\nMagicDamage " + MagicDamage + "\r\nMagicResistance " + MagicResistance + "\r\nSpeed " + Speed;
    }
}
