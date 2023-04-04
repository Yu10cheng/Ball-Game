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
            coinSO.Value = 0;
            scoreSO.Value = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }


    }

}