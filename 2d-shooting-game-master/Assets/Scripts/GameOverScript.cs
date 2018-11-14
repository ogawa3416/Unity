﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScript : MonoBehaviour {

    void Start()
    {
        this.gameObject.GetComponent<Text>().enabled = false;
    }

    public void Lose()
    {
        this.gameObject.GetComponent<Text>().enabled = true;
    }
}
