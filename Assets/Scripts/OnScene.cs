using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnScene : MonoBehaviour
{

    public void OnRetry()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnSelect()
    {
        SceneManager.LoadScene("SelectGames");
    }

}
