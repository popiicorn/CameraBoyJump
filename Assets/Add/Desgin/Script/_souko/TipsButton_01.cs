using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TipsButton_01 : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Tips_01");
    }

}
