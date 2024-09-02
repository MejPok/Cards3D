using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCounter : MonoBehaviour
{
    public static CardCounter instance;
    public CardHolder ch;
    public Dictionary< GameObject, int> hashMap= new Dictionary< GameObject, int>();

    public void Start(){
        instance = this;

        ch = GetComponent<CardHolder>();

        foreach(GameObject go in ch.cards){
            hashMap.Add(go, 0);
        }
    }

    public bool DrawThisCard(int number){
        GameObject chosen = ch.cards[number];

        if(hashMap[chosen] < 1){

            hashMap[chosen] += 1;
            return true;

        } else {

            return false;
        }
    }

}
