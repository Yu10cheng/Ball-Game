using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsUI : MonoBehaviour
{
    public PlayerMovement playermovement;
    public TextMeshProUGUI coinsText;
    private int coinsCount;
    public int coinsMultiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        playermovement = FindAnyObjectByType<PlayerMovement>();
        coinsText = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        coinsCount = playermovement.coins * coinsMultiplier;
        coinsText.text = coinsCount.ToString("0");
    }
}
