﻿using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    public AudioClip sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioManager.instance.PlayClipAt(sound, transform.position);
            CurrentSceneManager.instance.coinsPickedUpInThisSceneCount++;
            Inventory.instance.AddCoins(1);
            Destroy(gameObject);
            
        }
    }
}
