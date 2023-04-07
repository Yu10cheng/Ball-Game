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
        [SerializeField] private FloatSO totalSO;
        public void PlayAgain()
        {

            scoreSO.ResetScore();
            coinSO.ResetScore();
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}