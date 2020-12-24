﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
                Debug.Log("Player 2 scored...");
                GameObject.Find("GameManager").GetComponent<GameManagerScript>().Player2Scored();
            }
            else
            {
                Debug.Log("Player 1 scored...");
                GameObject.Find("GameManager").GetComponent<GameManagerScript>().Player1Scored();
            }
        }
    }
}
