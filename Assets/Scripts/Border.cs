using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D colli){
    if(colli.gameObject.name != "PlayerShip")
        Destroy(colli.gameObject);
   }
}
