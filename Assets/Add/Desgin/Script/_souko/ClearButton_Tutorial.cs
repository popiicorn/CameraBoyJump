using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClearButton_Tutorial: MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("InGame_01");
    }

}
