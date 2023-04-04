using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScoreScreen
{


    public class TryAgain : MonoBehaviour
    {
        [SerializeField] private FloatSO coinSO;
        [SerializeField] private FloatSO scoreSO;
        public void PlayAgain()
        {
            scoreSO.Value = 0;
            coinSO.Value = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}