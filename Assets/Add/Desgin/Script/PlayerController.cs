using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float jumpForce = 780.0f;
    public int outLine = -30;


    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        // ジャンプする
        if (Input.GetMouseButtonDown(0))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }


        // 画面外に出た場合は最初から
        if (transform.position.y < outLine)
        {
            SceneManager.LoadScene("Main");
        }

    }

    // ゴールに到達
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ゴール");
        SceneManager.LoadScene("Clear");
    }
}