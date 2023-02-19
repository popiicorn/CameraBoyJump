using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Text_Tips_Tutorial : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
