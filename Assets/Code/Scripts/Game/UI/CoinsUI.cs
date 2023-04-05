using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsUI : MonoBehaviour
{
    [SerializeField] private PlayerMovement playermovement;
    [SerializeField] private FloatSO coinsSO;

    public TextMeshProUGUI coinsText;
    private float coinsCount;
    public float coinsMultiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        coinsText = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        coinsCount = coinsSO.Value * coinsMultiplier;
        coinsText.text = coinsCount.ToString("0");
    }
}
 