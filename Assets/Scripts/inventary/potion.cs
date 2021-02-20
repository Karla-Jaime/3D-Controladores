using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "potion", menuName = "Items/potion", order = 1)]

public class potion : Consumable
{

    [SerializeField]
    int points;
    

    public int Points { get => points; }

    public override void Drink()
    {
        base.Drink();
        Debug.Log("consumed");
    }

}
