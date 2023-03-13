using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ButtonGood()
    {
        SceneManager.LoadScene("Clear_Good");
    }

    public void ButtonNoGood()
    {
        SceneManager.LoadScene("Clear_NoGood");
    }
}
