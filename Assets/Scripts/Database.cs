using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Database : MonoBehaviour
{
    public CardDatabase cards;
    private static Database instance;

    private void Awake(){
        if (instance == null){
            instance = this;
        }
    }

    public static Card getCardByID(string ID){
        return instance.cards.cardList.FirstOrDefault(i => i.id == ID);
    }
    
    public static Card getRandCard(){
        return instance.cards.cardList[Random.Range(0, instance.cards.cardList.Count())];
    }
}
