using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDealer : MonoBehaviour
{
    public static CardDealer instance;

    public void Start(){
        instance = this;
    }

    public void DealRandomCard(string user){
        int randomNumber = Random.Range(0, 32);

        while(!CardCounter.instance.DrawThisCard(randomNumber) && !CardCounter.instance.IsEveryCardOut()){
            randomNumber = Random.Range(0, 32);
        }

        if(!CardCounter.instance.IsEveryCardOut()){
            GameObject newCard = Instantiate(CardCounter.instance.ch.cards[randomNumber]);
        }
        
        
    }
}
