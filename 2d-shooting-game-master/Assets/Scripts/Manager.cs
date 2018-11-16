﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Playerプレハブ
    public GameObject player;

    // タイトル
    private GameObject title;

    // ゲームオーバー時のテキスト
    public GameObject GameOverText1;
    public GameObject GameOverText2;


    void Start ()
    {
        // Titleゲームオブジェクトを検索し取得する
        title = GameObject.Find ("Title");
    }

    void Update ()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {

            // タッチ情報を取得する
            Touch touch = Input.GetTouch(i);

            // ゲーム中ではなく、タッチ直後であればtrueを返す。
            if (IsPlaying() == false && touch.phase == TouchPhase.Began)
            {
                if (GameOverText1.GetComponent<Text>().enabled == enabled)
                {
                    SceneManager.LoadScene("Title");
                }
                else
                    GameStart();
            }

            // ゲーム中ではなく、マウスクリックされたらtrueを返す。
            if (IsPlaying() == false && Input.GetMouseButtonDown(0))
            {
                GameStart();
            }
        }
    }

    void GameStart ()
    {
        // ゲームスタート時に、タイトルを非表示にしてプレイヤーを作成する
        title.SetActive (false);
        GameOverText2.gameObject.GetComponent<Text>().enabled = false;
        Instantiate (player, player.transform.position, player.transform.rotation);
    }

    public void GameOver ()
    {
        // ゲームオーバー時に、タイトルを表示する
        title.SetActive (true);
        GameOverText1.SendMessage("Lose");
        GameOverText2.SendMessage("Lose");
    }

    public bool IsPlaying ()
    {
        // ゲーム中かどうかはタイトルの表示/非表示で判断する
        return title.activeSelf == false;
    }

}