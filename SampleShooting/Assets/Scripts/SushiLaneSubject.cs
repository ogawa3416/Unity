using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 監視対象 (寿司が流れてくるレーン)
public class SushiLaneSubject : ISubject
{
    // 流れてきた寿司
    public string Neta;

    // 寿司を待つ人々
    private List<IObserver> observers = new List<IObserver>();

    // 寿司が来たことを通知
    public void NotifyObservers()
    {
        foreach (var observer in this.observers)
        {
            observer.OnNotified();
        }
    }

    // 寿司を監視する (イベントを購読する)
    public void Subscribe(IObserver observer)
    {
        this.observers.Add(observer);
    }

    // 寿司の監視をやめる (イベントを非購読する)
    public void Unsubscribe(IObserver observer)
    {
        this.observers.Remove(observer);
    }
}

// 監視者 (寿司を食べる人)
public class SushiObserver : IObserver
{
    public SushiLaneSubject Subject;

    // 寿司が来た
    public void OnNotified()
    {
        Debug.LogFormat("{0}おいしいです (^q^)", this.Subject.Neta);
    }
}
