﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCardScript : MonoBehaviour {

    // Variables
    // Card Manager
    public CardsManager cardManager;
    // All Cards
    public List<GameObject> Cards;
    public GameObject[] totalCards;
    // Random Card selector
    private int randomCard;
    // Draw Button
    public Button drawButton;

    public void mouseEnter()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void mouseExit()
    {
        this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    private void Start()
    {
        Cards = cardManager.Cards;
        totalCards = cardManager.TotalCards.ToArray();
    }

    private void OnEnable()
    {
        // Sets all cards to inactive
        foreach (var card in totalCards)
        {
            card.SetActive(false);
        }
        // Sets Draw Button to Interactable
        drawButton.interactable = true;
    }

    public void DrawCard()
    {
        // Chooses a random card
        randomCard = Random.Range(0, Cards.Count);
        // Sets the card to active
        Cards[randomCard].SetActive(true);
        // Changes the card's tag to currentCard
        Cards[randomCard].tag = "currentCard";
        // Make Button Uninteractable
        drawButton.interactable = false;
    }

    public void Update()
    {
        if(Input.GetKeyDown("space") && drawButton.interactable == true)
        {
            drawButton.onClick.Invoke();
        }
    }
}
