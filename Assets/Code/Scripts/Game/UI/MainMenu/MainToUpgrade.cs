using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainToUpgrade : MonoBehaviour
{
    public void MainmenuToUpgrade()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
}
