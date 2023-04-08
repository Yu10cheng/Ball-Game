using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class useButton : MonoBehaviour
{
    public Button pressButton;
    private ColorBlock mycolors;
    [SerializeField] FloatSO UpgradeSO;
    [SerializeField] BoolSO upgrade;
    public bool ifUsedUpgrade;


    private void Awake()
    {
        pressButton = GetComponentInChildren<Button>();
        
    }

    public void DisableButton()
    {
        if (UpgradeSO.Value > 0)
        {
            pressButton.enabled = false;
            UpgradeSO.Value--;
            ifUsedUpgrade = true;
            
        }
        else
        {
            pressButton.enabled = true;
        }
    }

    public void ChangeButtonColor()
    {
        mycolors = pressButton.colors;
        mycolors.normalColor = new Color(0.51f, 0.51f, 0.51f, 1f);
        pressButton.colors = mycolors;
    }



    public void UpgradeExpired()
    {
        ifUsedUpgrade = false;
        upgrade.value = false;
    }

    public void Start()
    {
          //upgrade.value =  ifUsedUpgrade;

        if (upgrade.value == false)
        {
            pressButton.enabled = true;
            mycolors = pressButton.colors;
            mycolors.normalColor = new Color(1f, 1f, 1f, 1f);
            pressButton.colors = mycolors;
        }
        else if (upgrade.value == true)
        {
            DisableButton();
            ChangeButtonColor();
        }
    }
    public void ChangeSO()
    {
        upgrade.value = true;
    }
}
