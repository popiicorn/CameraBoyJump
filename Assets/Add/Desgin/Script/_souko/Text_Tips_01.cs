using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Text_Tips_01 : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("InGame_01");
    }
}
