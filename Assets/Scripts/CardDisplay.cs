using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

    public Card card;

    public Text nameText;


    public Image cardArt;

    public Text powerText;
    public Text shieldText;
    public Text gradeText;
    
	void Start () {
        
        nameText.text = card.cardname;
        cardArt.sprite = card.artwork;
 //       cardArt = card.artwork;

        powerText.text = card.power.ToString();
        shieldText.text = card.shield.ToString();
        gradeText.text = card.grade.ToString();

	}



}
