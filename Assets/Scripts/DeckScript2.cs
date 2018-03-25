using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeckScript2:MonoBehaviour {
    
    //Declair the Deck and Hand
    public Card[] Deck;
    public CardDisplay[] Hand;

    //Sets up the Zones on the board
    public CardDisplay[] Rear;
    public CardDisplay Van;

    //Used to get Vanguard Stats
    private Card Vanstats;

    //Used if the player misclicks on a lower grade dog
    private Card temp;
    int returnval;

    //Sets up the opponent's damage
    int damage;

    //Sets up the Start of the game, giving the player a hand of 3 cards, setting the
    //opponent's damage to 0 and sets the other components to be
    //invisible until a card is placed into that zone
	void Start () {
 
        int k = Random.Range(0, 14);
        int j = Random.Range(0, 14);
        int l = Random.Range(0, 14);
        damage = 0;    

        Hand[0].card = Deck[k];
        Hand[0].nameText.text = Deck[k].cardname;
        Hand[0].cardArt.sprite = Deck[k].artwork;
        Hand[0].powerText.text = Deck[k].power.ToString();
        Hand[0].shieldText.text = Deck[k].shield.ToString();
        Hand[0].gradeText.text = Deck[k].grade.ToString();

        Hand[1].card = Deck[j];
        Hand[1].nameText.text = Deck[j].cardname;
        Hand[1].cardArt.sprite = Deck[j].artwork;
        Hand[1].powerText.text = Deck[j].power.ToString();
        Hand[1].shieldText.text = Deck[j].shield.ToString();
        Hand[1].gradeText.text = Deck[j].grade.ToString();

        Hand[2].card = Deck[l];
        Hand[2].nameText.text = Deck[l].cardname;
        Hand[2].cardArt.sprite = Deck[l].artwork;
        Hand[2].powerText.text = Deck[l].power.ToString();
        Hand[2].shieldText.text = Deck[l].shield.ToString();
        Hand[2].gradeText.text = Deck[l].grade.ToString();

        Hand[3].card = null;
        Hand[3].nameText.text = null;
        Hand[3].cardArt.sprite = null;
        Hand[3].powerText.text = null;
        Hand[3].shieldText.text = null;
        Hand[3].gradeText.text = null;
        Hand[3].gameObject.SetActive(false);

        Hand[4].card = null;
        Hand[4].nameText.text = null;
        Hand[4].cardArt.sprite = null;
        Hand[4].powerText.text = null;
        Hand[4].shieldText.text = null;
        Hand[4].gradeText.text = null;
        Hand[4].gameObject.SetActive(false);

        Hand[5].card = null;
        Hand[5].nameText.text = null;
        Hand[5].cardArt.sprite = null;
        Hand[5].powerText.text = null;
        Hand[5].shieldText.text = null;
        Hand[5].gradeText.text = null;
        Hand[5].gameObject.SetActive(false);


        //Sets up the Board, setting both Rear guards to be empty, and placing the default Vanguard onto the field
        Rear[0].card = null;
        Rear[0].nameText.text = null;
        Rear[0].cardArt.sprite = null;
        Rear[0].powerText.text = null;
        Rear[0].shieldText.text = null;
        Rear[0].gradeText.text = null;
        Rear[0].gameObject.SetActive(false);

        Rear[1].card = null;
        Rear[1].nameText.text = null;
        Rear[1].cardArt.sprite = null;
        Rear[1].powerText.text = null;
        Rear[1].shieldText.text = null;
        Rear[1].gradeText.text = null;
        Rear[1].gameObject.SetActive(false);

        Van.nameText.text = Deck[14].cardname;
        Van.cardArt.sprite = Deck[14].artwork;
        Van.powerText.text = Deck[14].power.ToString();
        Van.shieldText.text = Deck[14].shield.ToString();
        Van.gradeText.text = Deck[14].grade.ToString();
        Vanstats = Deck[14];
    }

    //Reshuffles the deck and resets the board
    public void newHand()
    {
        int k = Random.Range(0, 14);
        int j = Random.Range(0, 14);
        int l = Random.Range(0, 14);


        Hand[0].card = Deck[k];
        Hand[0].nameText.text = Deck[k].cardname;
        Hand[0].cardArt.sprite = Deck[k].artwork;
        Hand[0].powerText.text = Deck[k].power.ToString();
        Hand[0].shieldText.text = Deck[k].shield.ToString();
        Hand[0].gradeText.text = Deck[k].grade.ToString();

        Hand[1].card = Deck[j];
        Hand[1].nameText.text = Deck[j].cardname;
        Hand[1].cardArt.sprite = Deck[j].artwork;
        Hand[1].powerText.text = Deck[j].power.ToString();
        Hand[1].shieldText.text = Deck[j].shield.ToString();
        Hand[1].gradeText.text = Deck[j].grade.ToString();

        Hand[2].card = Deck[l];
        Hand[2].nameText.text = Deck[l].cardname;
        Hand[2].cardArt.sprite = Deck[l].artwork;
        Hand[2].powerText.text = Deck[l].power.ToString();
        Hand[2].shieldText.text = Deck[l].shield.ToString();
        Hand[2].gradeText.text = Deck[l].grade.ToString();

        Hand[3].card = null;
        Hand[3].nameText.text = null;
        Hand[3].cardArt.sprite = null;
        Hand[3].powerText.text = null;
        Hand[3].shieldText.text = null;
        Hand[3].gradeText.text = null;
        Hand[3].gameObject.SetActive(false);

        Hand[4].card = null;
        Hand[4].nameText.text = null;
        Hand[4].cardArt.sprite = null;
        Hand[4].powerText.text = null;
        Hand[4].shieldText.text = null;
        Hand[4].gradeText.text = null;
        Hand[4].gameObject.SetActive(false);

        Hand[5].card = null;
        Hand[5].nameText.text = null;
        Hand[5].cardArt.sprite = null;
        Hand[5].powerText.text = null;
        Hand[5].shieldText.text = null;
        Hand[5].gradeText.text = null;
        Hand[5].gameObject.SetActive(false);

        Rear[0].card = null;
        Rear[0].nameText.text = null;
        Rear[0].cardArt.sprite = null;
        Rear[0].powerText.text = null;
        Rear[0].shieldText.text = null;
        Rear[0].gradeText.text = null;
        Rear[0].gameObject.SetActive(false);

        Rear[1].card = null;
        Rear[1].nameText.text = null;
        Rear[1].cardArt.sprite = null;
        Rear[1].powerText.text = null;
        Rear[1].shieldText.text = null;
        Rear[1].gradeText.text = null;
        Rear[1].gameObject.SetActive(false);

        Van.nameText.text = Deck[14].cardname;
        Van.cardArt.sprite = Deck[14].artwork;
        Van.powerText.text = Deck[14].power.ToString();
        Van.shieldText.text = Deck[14].shield.ToString();
        Van.gradeText.text = Deck[14].grade.ToString();
        Vanstats = Deck[14];

    }


    //Draws a random card from the deck
    public void DrawCard()
    {
        int i = 0;
        while (Hand[i].card != null && i+1 < 6)
        {
            ++i;
        }
        if (i < 6 && Hand[i].card == null)
        {

            int k = Random.Range(0, 14);
            Hand[i].gameObject.SetActive(true);
            Hand[i].card = Deck[k];
            Hand[i].nameText.text = Deck[k].cardname;
            Hand[i].cardArt.sprite = Deck[k].artwork;
            Hand[i].powerText.text = Deck[k].power.ToString();
            Hand[i].shieldText.text = Deck[k].shield.ToString();
            Hand[i].gradeText.text = Deck[k].grade.ToString();
        }

    }


    //Allows the player to set a card based on what card was clicked
    //Also takes in the previous spot in the array to allow an error to be corrected
    public void CardClickHand1()
    {
        temp = Hand[0].card;
        returnval = 0;

        Hand[0].card = null;
        Hand[0].nameText.text = null;
        Hand[0].cardArt.sprite = null;
        Hand[0].powerText.text = null;
        Hand[0].shieldText.text = null;
        Hand[0].gradeText.text = null;
        Hand[0].gameObject.SetActive(false);
    }

    public void CardClickHand2()
    {
        temp = Hand[1].card;
        returnval = 1;
        Hand[1].card = null;
        Hand[1].nameText.text = null;
        Hand[1].cardArt.sprite = null;
        Hand[1].powerText.text = null;
        Hand[1].shieldText.text = null;
        Hand[1].gradeText.text = null;
        Hand[1].gameObject.SetActive(false);
    }

    public void CardClickHand3()
    {
        temp = Hand[2].card;
        returnval = 2;
        Hand[2].card = null;
        Hand[2].nameText.text = null;
        Hand[2].cardArt.sprite = null;
        Hand[2].powerText.text = null;
        Hand[2].shieldText.text = null;
        Hand[2].gradeText.text = null;
        Hand[2].gameObject.SetActive(false);
    }

    public void CardClickHand4()
    {
        temp = Hand[3].card;
        returnval = 3;
        Hand[3].card = null;
        Hand[3].nameText.text = null;
        Hand[3].cardArt.sprite = null;
        Hand[3].powerText.text = null;
        Hand[3].shieldText.text = null;
        Hand[3].gradeText.text = null;
        Hand[3].gameObject.SetActive(false);
    }

    public void CardClickHand5()
    {
        temp = Hand[4].card;
        returnval = 4;
        Hand[4].card = null;
        Hand[4].nameText.text = null;
        Hand[4].cardArt.sprite = null;
        Hand[4].powerText.text = null;
        Hand[4].shieldText.text = null;
        Hand[4].gradeText.text = null;
        Hand[4].gameObject.SetActive(false);
    }

    public void CardClickHand6()
    {
        temp = Hand[5].card;
        returnval = 5;
        Hand[5].card = null;
        Hand[5].nameText.text = null;
        Hand[5].cardArt.sprite = null;
        Hand[5].powerText.text = null;
        Hand[5].shieldText.text = null;
        Hand[5].gradeText.text = null;
        Hand[5].gameObject.SetActive(false);
    }


    //Sets the vanguard.  If the grade of card selected is less than the Vanguard, the original vanguard is kept.
    //If the card is too high of a rank it will go back into the player's hand
    public void CardClickVan()
    {
        if (temp.grade <= Vanstats.grade + 1) {
            if (temp.grade > Vanstats.grade)
            {
                Van.card = temp;
                Van.nameText.text = temp.cardname;
                Van.cardArt.sprite = temp.artwork;
                Van.powerText.text = temp.power.ToString();
                Van.shieldText.text = temp.shield.ToString();
                Van.gradeText.text = temp.grade.ToString();
                Vanstats = temp;
                DrawCard();
            }
            else
                DrawCard();
        }
        else
        {
            Hand[returnval].gameObject.SetActive(true);
            Hand[returnval].card = temp;
            Hand[returnval].nameText.text = temp.cardname;
            Hand[returnval].cardArt.sprite = temp.artwork;
            Hand[returnval].powerText.text = temp.power.ToString();
            Hand[returnval].shieldText.text = temp.shield.ToString();
            Hand[returnval].gradeText.text = temp.grade.ToString();
        }

    }

    //Sets a card into rear guard one if the grade is lower or equal to the vanguard's stats
    public void CardClickRear1()
    {
        if (temp.grade <= Vanstats.grade)
        {
            Rear[0].gameObject.SetActive(true);
            Rear[0].card = temp;
            Rear[0].nameText.text = temp.cardname;
            Rear[0].cardArt.sprite = temp.artwork;
            Rear[0].powerText.text = temp.power.ToString();
            Rear[0].shieldText.text = temp.shield.ToString();
            Rear[0].gradeText.text = temp.grade.ToString();
            DrawCard();
        }
        else
        {
            Hand[returnval].gameObject.SetActive(true);
            Hand[returnval].card = temp;
            Hand[returnval].nameText.text = temp.cardname;
            Hand[returnval].cardArt.sprite = temp.artwork;
            Hand[returnval].powerText.text = temp.power.ToString();
            Hand[returnval].shieldText.text = temp.shield.ToString();
            Hand[returnval].gradeText.text = temp.grade.ToString();
        }
    }

    //Sets a card into rear guard 2 if the card's grade is less than or equal to that of the vanguard
    public void CardClickRear2()
    {
        if (temp.grade  <= Vanstats.grade)
        {

                Rear[1].gameObject.SetActive(true);
                Rear[1].card = temp;
                Rear[1].nameText.text = temp.cardname;
                Rear[1].cardArt.sprite = temp.artwork;
                Rear[1].powerText.text = temp.power.ToString();
                Rear[1].shieldText.text = temp.shield.ToString();
                Rear[1].gradeText.text = temp.grade.ToString();
                DrawCard();

        }
        else
        {
            Hand[returnval].gameObject.SetActive(true);
            Hand[returnval].card = temp;
            Hand[returnval].nameText.text = temp.cardname;
            Hand[returnval].cardArt.sprite = temp.artwork;
            Hand[returnval].powerText.text = temp.power.ToString();
            Hand[returnval].shieldText.text = temp.shield.ToString();
            Hand[returnval].gradeText.text = temp.grade.ToString();
        }
    }


    //Attack variable.  If the opponent has taken 6 or more damage, the player wins.
    public void attack()
    {
        damage++;
        if(damage >= 6)
        {
            SceneManager.LoadScene("youwin");
        }

    }
}
