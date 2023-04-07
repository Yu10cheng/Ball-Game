using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatSO : ScriptableObject
{
    [SerializeField]
    private float _value;

    public float Value
    {
        get { return _value; }
        set { _value = value; }
    }
    public void AddScore(float amount)
    {
        Value += amount;
    }

    public void ResetScore()
    {
        Value = 0f;
    }

    public void SaveScore()
    {
        PlayerPrefs.SetFloat("Value", Value);
        PlayerPrefs.Save();
    }

    public void LoadScore()
    {
        Value = PlayerPrefs.GetFloat("Value", 0f);
    }
}
