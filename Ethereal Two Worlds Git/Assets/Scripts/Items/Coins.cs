using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private BoxCollider2D playerColision; //Player physical collider
    public CircleCollider2D coinCollision; //Coin trigger collider variable
    public PlayerStatistics playerStatistics;
   // public UIController uiController;
    public int moneyAmount=1;
    public void Start()
    {
        playerColision = GameObject.Find("Player").GetComponent<BoxCollider2D>();
    }
    void FixedUpdate(){
            if (playerColision.IsTouching(coinCollision)){ //Actually checking for the collision{
               // uiController.SetCoins(moneyAmount);
            FindObjectOfType<UIController>().SetCoins(moneyAmount);
            Destroy(gameObject); //Destroying the object in the scene
            }
        }
    }