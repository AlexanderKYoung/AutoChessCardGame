using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class CardPool : MonoBehaviour
{

    public CardDatabase cards;
    //private static CardPool instance = null;

    public static List<Card> tier1 = new List<Card>();
    public static List<Card> tier2 = new List<Card>();
    public static List<Card> tier3 = new List<Card>();
    public static List<Card> tier4 = new List<Card>();
    public static List<Card> tier5 = new List<Card>();
    public static List<Card> tier6 = new List<Card>();

    //generate the two removed factions
    private string removedFact1;
    private string removedFact2;

    //public void Start(){
    //    GenerateCardPool();
    //}

    public void generateCardPool(){
        //list of factions, save two to be absent from the game
        var list = new List<string>{ "Brimdar", "Lorvoz", "Draxul", "Valerus", "Gylaxoid", "Myrwinn", "Kraag"};
        int index;
        int index2;

        do{
            index = Random.Range(0, 6);
            index2 = Random.Range(0, 6);

        }while (index == index2);

        removedFact1 = list[index];
        removedFact2 = list[index2];
        Debug.Log(removedFact1);
        Debug.Log(removedFact2);

        //create 6 lists of cards in the game for each tier
        //Populate each list with cards from the card list
        foreach (Card card in cards.cardList){
            
            if ((card.faction != removedFact1 
                && card.faction != removedFact2) 
                && (card.faction2 != removedFact1 
                && card.faction2 != removedFact2)){
                
                Debug.Log(card);
                switch (card.cost){
                
                case 1:
                    for (int i = 0; i < 16; i++){
                        tier1.Add(card);
                    }
                    break;

                case 2:
                    for (int i = 0; i < 15; i++){
                        tier2.Add(card);
                    }
                    break;

                case 3:
                    for (int i = 0; i < 13; i++){
                        tier3.Add(card);
                    }
                    break;

                case 4:
                    for (int i = 0; i < 11; i++){
                        tier4.Add(card);
                    }
                    break;

                case 5:
                    for (int i = 0; i < 9; i++){
                        tier5.Add(card);
                    }
                    break;

                case 6:
                    for (int i = 0; i < 7; i++){
                        tier6.Add(card);
                    }
                    break;
                }

            }
        }
    }
    
    //retrieves a random card given the player's tier level
    //removes the card from the list
    public Card getCardFromPool(Player player){
        Card rndCard;

        if (player.tierLevel == 1){
        
            do{
                rndCard = tier1[Random.Range(0, tier1.Count())];
                tier1.Remove(rndCard);
            }while(rndCard == null);
                
            return rndCard;

        }else if (player.tierLevel == 2){
            
            do{
                int randTier = Random.Range(1, 3);

                if (randTier == 1){
                    rndCard = tier1[Random.Range(0, tier1.Count())];
                    tier1.Remove(rndCard);
                }else{
                    rndCard = tier2[Random.Range(0, tier2.Count())];
                    tier2.Remove(rndCard);
                }
            }while(rndCard == null);
                
            return rndCard;

        }else if (player.tierLevel == 3){
            
            do{
                int randTier = Random.Range(1, 4);

                if (randTier == 1){
                    rndCard = tier1[Random.Range(0, tier1.Count())];
                    tier1.Remove(rndCard);
                }else if (randTier == 2){
                    rndCard = tier2[Random.Range(0, tier2.Count())];
                    tier2.Remove(rndCard);
                }else{
                    rndCard = tier3[Random.Range(0, tier3.Count())];
                    tier3.Remove(rndCard);
                }
            }while(rndCard == null);
                
            return rndCard;

        }else if (player.tierLevel == 4){
            
            do{
                int randTier = Random.Range(1, 5);

                if (randTier == 1){
                    rndCard = tier1[Random.Range(0, tier1.Count())];
                    tier1.Remove(rndCard);
                }else if (randTier == 2){
                    rndCard = tier2[Random.Range(0, tier2.Count())];
                    tier2.Remove(rndCard);
                }else if (randTier == 3){
                    rndCard = tier3[Random.Range(0, tier3.Count())];
                    tier3.Remove(rndCard);
                }else{
                    rndCard = tier4[Random.Range(0, tier4.Count())];
                    tier4.Remove(rndCard);
                }
            }while(rndCard == null);
                
            return rndCard;
        
        }else if (player.tierLevel == 5){
            
            do{
                int randTier = Random.Range(1, 6);

                if (randTier == 1){
                    rndCard = tier1[Random.Range(0, tier1.Count())];
                    tier1.Remove(rndCard);
                }else if (randTier == 2){
                    rndCard = tier2[Random.Range(0, tier2.Count())];
                    tier2.Remove(rndCard);
                }else if (randTier == 3){
                    rndCard = tier3[Random.Range(0, tier3.Count())];
                    tier3.Remove(rndCard);
                }else if (randTier == 4){
                    rndCard = tier4[Random.Range(0, tier4.Count())];
                    tier4.Remove(rndCard);
                }else{
                    rndCard = tier5[Random.Range(0, tier5.Count())];
                    tier5.Remove(rndCard);
                }
            }while(rndCard == null);
                
            return rndCard;
        }else{
            
            do{
                int randTier = Random.Range(1, 7);
                
                if (randTier == 1){
                    rndCard = tier1[Random.Range(0, tier1.Count())];
                    tier1.Remove(rndCard);
                }else if (randTier == 2){
                    rndCard = tier2[Random.Range(0, tier2.Count())];
                    tier2.Remove(rndCard);
                }else if (randTier == 3){
                    rndCard = tier3[Random.Range(0, tier3.Count())];
                    tier3.Remove(rndCard);
                }else if (randTier == 4){
                    rndCard = tier4[Random.Range(0, tier4.Count())];
                    tier4.Remove(rndCard);
                }else if (randTier == 5){
                    rndCard = tier5[Random.Range(0, tier5.Count())];
                    tier5.Remove(rndCard);
                }else{
                    rndCard = tier6[Random.Range(0, tier6.Count())];
                    tier6.Remove(rndCard);
                }
            }while(rndCard == null);
                
            return rndCard;
        }
    }

    public static void returnCardToPool(Card c){
        if (c.cost == 1){
            tier1.Add(c);
            Debug.Log("Sold a tier 1 unit!");
        }else if (c.cost == 2){
            tier2.Add(c);
        }else if (c.cost == 3){
            tier3.Add(c);
        }else if (c.cost == 4){
            tier4.Add(c);
        }else if (c.cost == 5){
            tier5.Add(c);
        }else if (c.cost == 6){
            tier6.Add(c);
        }else{
            
        }
    }
}
