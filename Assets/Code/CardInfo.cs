using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo : MonoBehaviour
{
    public int number; // 7 8 9 10, spodek 11, svrsek 12, kral 13, eso 14.
    public string color;

    public void Start(){
        gameObject.name = number + " " + color; 
    }
}
