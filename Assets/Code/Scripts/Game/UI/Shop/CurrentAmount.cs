using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentAmount : MonoBehaviour
{
    [SerializeField] FloatSO upgradeSO;
    private TextMeshProUGUI currentText;
    private void Update()
    {
        currentText.text = "Current" + " = " + upgradeSO.Value.ToString("0");
    }
}
