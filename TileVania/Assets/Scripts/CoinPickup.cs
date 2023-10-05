using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip CoinPickupSFX;
    [SerializeField]  int pointsForCoinPickup = 100;

    private bool wasCollected = false;


  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && wasCollected == false)
        {
            wasCollected = true;
            FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);
            AudioSource.PlayClipAtPoint(CoinPickupSFX, Camera.main.transform.position);
            Destroy(gameObject);
            
        }
    }

    
}
