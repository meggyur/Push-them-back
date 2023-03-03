using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
[SerializeField] bool isPlaceable;
[SerializeField] GameObject machinegunI;

   void OnMouseDown() 
   {
        if(isPlaceable)
        {
            Instantiate(machinegunI, transform.position, Quaternion.identity);
            isPlaceable = false;
        }

   }
}
