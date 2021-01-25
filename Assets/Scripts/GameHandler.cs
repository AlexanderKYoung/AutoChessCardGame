using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    //first generate card pool
    //second step determine heroes and number of players
    //third call first market
    //battle market loop


    public GameObject CardTemplate;
    public int numberOfPlayers;
    public CardPool cardPool;
    public Market gameMarket;
    public bool isGameOver = true;
    public bool buttonLocked = false;
    
    public Player currentPlayer;

    //private IEnumerator coroutine = timerStart();

    public float seconds;
    public float secondsStart = 40f;
    public TextMeshProUGUI timerDisp;

    void Start() {
        cardPool.generateCardPool();
        //heroes
        //populatePlayers();
        //call first market
        gameMarket.startMarket(cardPool, currentPlayer);
        StartCoroutine(GameLoop());   
    }

    IEnumerator GameLoop(){
        //main game loop
        while (isGameOver) {
            currentPlayer.setGold(currentPlayer.goldTotal++);
            //call market
            if (buttonLocked == false){
                gameMarket.generateCards(cardPool, currentPlayer);
            }
            //start timer
            while (seconds >= 0f){
                timerDisp.text = seconds.ToString();
                seconds--;
                yield return new WaitForSeconds(1);
            }
            //call battle when timer ends
            SceneManager.LoadScene("BattleScene");
            //check if end
            if (currentPlayer.getHealth() <= 0){
                isGameOver = false;
            }
            
            secondsStart += 5;
            seconds = secondsStart;
        }
    }

    public void refreshMarket(){
        gameMarket.generateCards(cardPool, currentPlayer);
    }

    //private void populatePlayers() {
    //    for (int i = 0; i < numberOfPlayers; i++) {
    //        players.Add(new Player(playerHealth, playerGold, playerTier));
    //    }
    
    //}
    
    public void isButtonLocked(){
        buttonLocked = !buttonLocked;
    }
}