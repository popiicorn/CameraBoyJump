using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float jumpForce = 780.0f;
    public int outLine = -30;

    public GameObject buttonNoGood;
    public GameObject buttonGood;
    public GameObject okMark;


    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();

        buttonNoGood.SetActive(true);
        buttonGood.SetActive(false);
        okMark.SetActive(false);
    }

    void Update()
    {
        /*
        // ジャンプする
        if (Input.GetMouseButtonDown(0))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        */

        // 画面外に出た場合は最初から
        if (transform.position.y < outLine)
        {
            SceneManager.LoadScene("Main");
        }

    }

    /*
    // ゴールに到達
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ゴール");
        SceneManager.LoadScene("Clear");
    }
    */


    // ボタンでジャンプ
    public void OnClickButtonJump()
    {
        this.rigid2D.AddForce(transform.up * this.jumpForce);
    }


    
    // パンツ撮れちゃう領域！最高！
    public void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("パンツ撮れちゃう領域！最高！");
        buttonNoGood.SetActive(false);
        buttonGood.SetActive(true);
        okMark.SetActive(true);
    }

    
    // パンツ撮れない領域
    public void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("パンツ撮れない領域");
        buttonNoGood.SetActive(true);
        buttonGood.SetActive(false);
        okMark.SetActive(false);
    }
    
}