using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton_InGame_04 : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("InGame_04");
    }
}
