using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour {

    public Card cardObject;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI typeText;

    public TextMeshProUGUI costText;
    public TextMeshProUGUI strengthText;
    public TextMeshProUGUI healthText;

    public Image artworkImage;
    public Image reachImage;
    public Image frameImage;
    public Image factionImage;
    public Image faction2Image;

    void Start(){
        //LoadCard(CardPool.GetCardFromPool());
    }

    public void loadCard(Card c) {

        if (c == null){
            return;
        }
        cardObject = c.card;
        nameText.text = c.name;
        descriptionText.text = c.description;
        typeText.text = c.type;

        costText.text = c.cost.ToString();
        strengthText.text = c.strength.ToString();
        healthText.text = c.health.ToString();

        //artworkImage.sprite = c.artwork;
        frameImage.sprite = c.frame;
        reachImage.sprite = c.reach;
        factionImage.sprite = c.factionDisp;
        faction2Image.sprite = c.faction2Disp;
        
    }

    public Card getCard(){
        return this.cardObject;
    }
}
