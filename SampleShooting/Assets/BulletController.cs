using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0.2f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        // 衝突したときにスコアを更新する
        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

        Destroy(coll.gameObject);
        Destroy(gameObject);
    }

}
