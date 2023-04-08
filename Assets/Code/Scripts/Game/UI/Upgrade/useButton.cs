using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class useButton : MonoBehaviour
{
    public  Button _use;
    private ColorBlock mycolors;
    [SerializeField] FloatSO UpgradeSO;
    public bool ifUsedUpgrade = false;
    
    public void DisableButton()
    {
        if (UpgradeSO.Value > 0)
        {
            _use.enabled = false;
            UpgradeSO.Value--;
            ifUsedUpgrade = true;
        }
        else
        {
            _use.enabled = true;
        }
    }

    public void ChangeButtonColor()
    {
        mycolors = _use.colors;
        mycolors.normalColor = new Color(0.51f, 0.51f, 0.51f, 1f);
        _use.colors = mycolors;
    }


}
