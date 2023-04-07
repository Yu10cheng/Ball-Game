using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScoreScreen
{


    public class Back : MonoBehaviour

    {
        [SerializeField] FloatSO coinSO;
        [SerializeField] private FloatSO scoreSO;
        public void BackToMenu()
        {
            scoreSO.ResetScore();
            coinSO.ResetScore();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }


    }

}