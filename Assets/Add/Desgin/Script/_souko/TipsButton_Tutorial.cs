using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TipsButton_Tutorial : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Tips_Tutorial");
    }

}
