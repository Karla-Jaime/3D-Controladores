using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Item", menuName = "3DyControlador/Item", order = 0)]
public class Item : ScriptableObject 
{

    [SerializeField]
    Sprite icon;
   
    [SerializeField]
    protected string objectName = "Item";

    [SerializeField,TextArea(3,10)]
    protected string description;

    
}
