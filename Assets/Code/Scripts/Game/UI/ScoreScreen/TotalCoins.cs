using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TotalCoins : MonoBehaviour
{
    [SerializeField] FloatSO totalCoinsSO;
    [SerializeField] FloatSO coinsSO;

    float cointhisTurn;

    private bool calculateOnce = true;
    public TextMeshProUGUI totalResult;


    private void Start()
    {
        totalCoinsSO.AddScore(coinsSO.Value);
        totalResult.text = this.name + "  =  " + totalCoinsSO.Value.ToString("0");
    }

    private void OnDisable()
    {
        totalCoinsSO.SaveScore();
    }

    private void Awake()
    {
        totalCoinsSO.LoadScore();
    }
    /*private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.buildIndex == 2)
        {
            if (calculateOnce)
            {
                cointhisTurn = coinsSO.Value;
                totalCoinsSO.Value += cointhisTurn;
                totalResult.text = this.name + "  =  " + totalCoinsSO.Value.ToString("0");

                calculateOnce = false;
            }
            
        }
        else
        {
            calculateOnce = true;
        }
       
    }
    */



}
