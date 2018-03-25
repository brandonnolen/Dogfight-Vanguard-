using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "card")]
public class Card : ScriptableObject{
    public string cardname;

    public Sprite artwork;

    public int grade;
    public int power;
    public int shield;
    public int trigger;

    public string clan;
    public string creaturetype;



}
