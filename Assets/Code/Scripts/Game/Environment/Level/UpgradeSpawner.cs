using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpawner : MonoBehaviour
{
    float upgradePosibility = 0.1f;
    public Transform upgradeSpawnPoint;
    public GameObject upgradePrefab;
    [SerializeField] float _levelWidth;
    private float _spawnX;

    float GetUpgradePosibility()
    {
        if (upgradePosibility >= 1f)
        {
            upgradePosibility = 0.1f;
            return 1f;

        }
        else if (upgradePosibility >= 0.7f && upgradePosibility < 1f)
        {
            upgradePosibility += 0.1f;
            return Random.value < 0.3f ? 1f : 0f;
        }
        else
        {
            upgradePosibility += 0.1f;
            return 0.1f;
        }
    }

    private void Start()
    {
        
        _spawnX = Random.Range(-_levelWidth, _levelWidth);
        spawnUpgrade();
    }

    

    void spawnUpgrade()
    {
        if (Random.value < GetUpgradePosibility())
        {
            upgradeSpawnPoint.position = new Vector3(_spawnX, upgradeSpawnPoint.position.y, upgradeSpawnPoint.position.z);
            upgradeSpawnPoint.rotation = Quaternion.Euler(45, upgradeSpawnPoint.rotation.y, 45);
            Instantiate(upgradePrefab, upgradeSpawnPoint.position, upgradeSpawnPoint.rotation);
            
        }
        
    }
    
}
