using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    public GameObject CardTemplate;
    public int numberOfCards;
    // Start is called before the first frame update
    public void startMarket(CardPool cp, Player currentPlayer)
    {
        generateCards(cp, currentPlayer);
    }

    //generates n new cards in the card shop
    //destroy all game objects currently in the market
    public void generateCards(CardPool cp, Player currentPlayer){
        
        
        if (transform.childCount > 0){
            destroyCards();
        }

        //instantiate n cards attachted to the market parent
        //on each card, call GetCard from the CardPool class

        for (int i = 0; i < numberOfCards; i++){    
           GameObject newCardTemplate = Instantiate(CardTemplate, transform);
           Card card = cp.getCardFromPool(currentPlayer);
           newCardTemplate.GetComponent<CardDisplay>().loadCard(card);
        }
    }

    public void destroyCards(){
        
        foreach(Transform child in transform)
        {       
            CardPool.returnCardToPool(child.GetComponent<CardDisplay>().getCard());
            Destroy(child.gameObject);
        }
    }
}
