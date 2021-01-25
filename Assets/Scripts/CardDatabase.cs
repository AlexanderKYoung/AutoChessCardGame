using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card Database", menuName = "Assets/Databases/CardDatabase")]
public class CardDatabase : ScriptableObject
{
    public struct CardData {
        
        public Card prefab;
        public string name;
        public Sprite token;
        public int cost;

    }
    
    public List<Card> cardList;

    //void Awake(){
        //cardList.Add(new Card( ));
    //}


}
