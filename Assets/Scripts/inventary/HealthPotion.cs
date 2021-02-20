using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField] 
    
    potion potion;

    private void OnTriggerEnter(Collider other) 
    {
        potion.Drink();
        Debug.Log("Healt Restored");
        Destroy(gameObject);
    }
}
