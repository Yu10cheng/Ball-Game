using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentAmount : MonoBehaviour
{
    [SerializeField] FloatSO upgradeSO;
    public TextMeshProUGUI currentText;
    private void Update()
    {
        currentText.text = "Own" + " : " + upgradeSO.Value.ToString("0");
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("UpgradeValue", upgradeSO.Value);
        PlayerPrefs.Save();
    }

    private void Awake()
    {
        upgradeSO.Value = PlayerPrefs.GetFloat("UpgradeValue", 0f);
    }
}
