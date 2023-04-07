using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    [SerializeField] FloatSO UpgradeAmount;
    [SerializeField] FloatSO TotalSO;

    
    private void BuyUpgrade()
    {
        if (TotalSO.Value >= 10f)
        {
            UpgradeAmount.AddScore(1);
            TotalSO.AddScore(-10f);
        }
        

    }
}
