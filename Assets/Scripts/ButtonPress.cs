using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    public void OnClick_Restart()
    {
        SceneManager.LoadScene(0);

    }
    public void OnClick_Exit()
    {
        Application.Quit();
    }
}
