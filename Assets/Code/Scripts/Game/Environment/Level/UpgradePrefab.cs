using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePrefab : MonoBehaviour
{
    [SerializeField] FloatSO coinSO; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            coinSO.Value += 5;
            Destroy(gameObject);
        }
    }
}
