using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Manager : MonoBehaviour
{
    // Playerプレハブ
    public GameObject player;

    // タイトル
    private GameObject title;

    // ゲームオーバー時のテキスト
    public GameObject GameOverText1;


    void Start ()
    {
        // Titleゲームオブジェクトを検索し取得する
        title = GameObject.Find ("Title");
    }

    void Update ()
    {
        // ゲーム中ではなく、Xキーが押されたらtrueを返す。
        if (IsPlaying () == false && Input.GetKeyDown (KeyCode.X)) {
            GameStart ();
            GameOverText1.GetComponent<Text>().enabled = false;
        }
    }

    void GameStart ()
    {
        // ゲームスタート時に、タイトルを非表示にしてプレイヤーを作成する
        title.SetActive (false);
        Instantiate (player, player.transform.position, player.transform.rotation);
    }

    public void GameOver ()
    {
        // ゲームオーバー時に、タイトルを表示する
        title.SetActive (true);
        GameOverText1.SendMessage("Lose");
    }

    public bool IsPlaying ()
    {
        // ゲーム中かどうかはタイトルの表示/非表示で判断する
        return title.activeSelf == false;
    }

}