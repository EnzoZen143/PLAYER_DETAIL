using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Info;

    string Name = "Isaiah See";
    int Age = 16;
    string Race = "Asian";
    int PhysicalDamage = 55;
    int Armor = 80;
    int MagicDamage = 65;
    int MagicResistance = 50;
    float Speed = 70;

    public void ButtonTwoPressed()
    {
        Info.text = "Player Info: \r\n \r\nName: " + Name + "\r\nAge " + Age + "\r\nRace" + Race + "\r\nPhysicalDamage: " + PhysicalDamage + "\r\nArmor " + Armor + "\r\nMagicDamage " + MagicDamage + "\r\nMagicResistance " + MagicResistance + "\r\nSpeed " + Speed;
    }
}
