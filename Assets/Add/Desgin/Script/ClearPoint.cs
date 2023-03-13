using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearPoint : MonoBehaviour
{
    public int clearpoint = 0;
    public Text textClearPoint;

    void Start()
    {
        //ポイント値のロード
        clearpoint = ES3.Load("Clearkey", clearpoint);

        // メニュー画面表示用
        textClearPoint.text = "" + clearpoint;

        Debug.Log("クリアポイントロード");
    }


    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Main_test");

        clearpoint += 1;
        AddPoint();
    }


    //ポイント数代入------------------------------------------
    void AddPoint()
    {
        textClearPoint.text = clearpoint + "";

        //ポイント値のセーブ
        ES3.Save<int>("Clearkey", clearpoint);

        Debug.Log("クリアポイント獲得");
    }


}
