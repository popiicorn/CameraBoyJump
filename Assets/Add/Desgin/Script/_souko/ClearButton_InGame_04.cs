using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearButton_InGame_04: MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("InGame_05");
    }
}
