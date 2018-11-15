using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressScript : MonoBehaviour {

    void Start()
    {
        this.gameObject.GetComponent<Text>().enabled = true;
    }

    public void Lose()
    {
        this.gameObject.GetComponent<Text>().enabled = true;
    }
}
