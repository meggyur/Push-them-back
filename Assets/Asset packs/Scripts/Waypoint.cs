using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
[SerializeField] Tower machinegunI;

[SerializeField] bool isPlaceable;
public bool IsPlaceable { get { return isPlaceable; } }


   void OnMouseDown() 
   {
        if(isPlaceable)
        {
            bool isPlaced = machinegunI.CreateTower(machinegunI, transform.position);
            isPlaceable = !isPlaced;
        }

   }
}
