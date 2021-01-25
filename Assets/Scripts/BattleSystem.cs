using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BattleSystem : MonoBehaviour {


    public Market playerMarket;
    public Player currentPlayer;
    public Player otherPlayer;
    private Player firstPlayer;
    private Player secondPlayer;
    private Card[] p1Cards;
    private Card[] p2Cards;

    public void battleStart() {

        Queue<Card> battleQueue = new Queue<Card>();
        

        //clear current cards from market
        playerMarket.destroyCards();

        //find oponent
        //[needs code]

        //run initializer

        //pick random first player

        if (Random.Range(0.0f,1.0f) > 0.5f)
        {
            firstPlayer = currentPlayer;
            secondPlayer = otherPlayer;
        }
        else 
        {
            firstPlayer = otherPlayer;
            secondPlayer = currentPlayer;
        }

        //get list of cards from both players
        p1Cards = firstPlayer.getCardArray();
        p2Cards = secondPlayer.getCardArray();

        //battlefield effects added to queue
        //[needs code]
        //remove cards that die

        //check cards for charge and rush and add based on first and second player
        //[needs code]
        //remove cards that die

        //add cards excluding those from that
        for (int i = 0; i < p1Cards.Length + p2Cards.Length; i++) {

            cardFight(p1Cards[i], 0);

            cardFight(p2Cards[i], 1);


        }

        //compute the battle
        


    }


    //card fight
    private void cardFight(Card card, int player) {
        
        //pick random oposing card

        //compute a fight

        //return 
    }
}


