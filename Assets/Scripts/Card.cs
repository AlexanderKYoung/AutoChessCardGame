using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

[CreateAssetMenu(fileName = "New Card", menuName = "Assets/Card")]
public class Card : ScriptableObject {
    
    public string id;
    public Card card;
    
    public new string name;
    [TextArea]
    public string description;
    
    public string type;
    public string faction;
    public string faction2;
    
    public int cost;
    public int strength;
    public int health;

    public Sprite artwork;
    public Sprite frame;
    public Sprite reach;
    public Sprite factionDisp;
    public Sprite faction2Disp;
    public Sprite token;

    public Card(){

    }

    public Card(string Id, string Name, string Description, string Type, string Faction, 
    string Faction2, int Cost, int Strength, int Health, Sprite Artwork, Sprite Frame, 
    Sprite Reach, Sprite FactionDisp, Sprite Faction2Disp, Sprite Token){
        id = Id;
        name = Name;
        description = Description;
        type = Type;
        faction = Faction;
        faction2 = Faction2;
        cost = Cost;
        strength = Strength;
        health = Health;
        artwork = Artwork;
        frame = Frame;
        reach = Reach;
        factionDisp = FactionDisp;
        faction2Disp = Faction2Disp;
        token = Token;
    }
}
