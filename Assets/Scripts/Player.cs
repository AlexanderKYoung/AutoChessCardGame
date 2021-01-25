using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    public int healthTotal;
    public int goldTotal;
    public int tierLevel;
    public Market playerMarket;

    public Player(int health, int gold, int tier){
        this.healthTotal = health;
        this.goldTotal = gold;
        this.tierLevel = tier;
    }

    //battle scene calls this function to populate player board
    public Card[] getCardArray(){
        Card[] cardArr = new Card[8];
        int count = 0;

        foreach(Transform child in transform){

            cardArr[count] = child.GetComponent<CardDisplay>().getCard();
            count++;
        }
        for (int i = 0; i < cardArr.Length; i++) {
            Debug.Log(cardArr[i]);
        }
        
        return cardArr;
    }

    public void increasePlayerGold(){
        this.goldTotal += goldTotal;
    }

    public void increaseTierLevel(){
        this.tierLevel += tierLevel;
        Debug.Log("Tiered Up!");
    }

    public int getHealth(){
        return this.healthTotal;
    }

    public void setHealth(int newHealth){
        this.healthTotal = newHealth;
    }

    public int getGold(){
        return this.goldTotal;
    }

    public void setGold(int newGold){
        this.goldTotal = newGold;
    }

    public int getTier(){
        return this.tierLevel;
    }

    public void setTier(int newTier){
        this.tierLevel = newTier;
    }

}
