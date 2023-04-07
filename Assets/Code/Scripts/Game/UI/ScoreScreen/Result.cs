using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Result : MonoBehaviour
{
    [SerializeField] private FloatSO resultSO;

    public TextMeshProUGUI textResult;
    // Start is called before the first frame update
    void Start()
    {
        textResult = GetComponent<TextMeshProUGUI>();
        textResult.text = this.name + "  =  " + resultSO.Value.ToString("0");
    }

    
}
