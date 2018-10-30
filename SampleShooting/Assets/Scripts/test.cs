using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var subject = new SushiLaneSubject();
        var observer1 = new SushiObserver() { Subject = subject };
        var observer2 = new SushiObserver() { Subject = subject };

        subject.Subscribe(observer1);
        subject.Subscribe(observer2);

        subject.Neta = "まぐろ";
        subject.NotifyObservers();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
