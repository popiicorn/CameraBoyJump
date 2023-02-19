using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearButton_InGame_05: MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Ending");
    }
}
