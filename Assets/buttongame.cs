using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttongame : MonoBehaviour
{
    public void onClickPlay()
    {
        SceneManager.LoadScene("kkkkkkkk");
    }

    public void onClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void onClickExit()
    {
        Application.Quit();
    }
}
