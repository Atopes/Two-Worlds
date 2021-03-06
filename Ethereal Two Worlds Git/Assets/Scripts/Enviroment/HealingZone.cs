using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingZone : MonoBehaviour
{
    public BoxCollider2D zoneCollision, playerCollision; //Colliders of the Zone and the Player
    public PlayerStatistics playerStatistics; //Reference to the playerStatistics script
    bool isIn = false;
    void Update(){
        if (playerCollision.IsTouching(zoneCollision)) { //Checking for collision 
            if (!isIn) {
                isIn = true; // Setting player state in the hazard zone
                StartCoroutine(HealOverTime()); // Starting Coroutine for taking dmg over time
            }
        }
        else {
            if (isIn){
                isIn = false; // Setting player state out of hazard zone
                StopCoroutine(HealOverTime()); // Stoping Coroutine for taking dmg over time
            }
        }
    }
    IEnumerator HealOverTime(){//Damage over time Courutine , while in hazard zone deals 1 dmg each second
        while (isIn){
            playerStatistics.healPlayer(1);
            yield return new WaitForSeconds(1f);
        }
    }
}
