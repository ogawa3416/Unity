using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 監視者
public interface IObserver
{
    // 通知がきた
    void OnNotified();
}

// 監視対象
public interface ISubject
{
    // 監視者に通知する
    void NotifyObservers();

    // 監視者が購読する
    void Subscribe(IObserver observer);

    // 監視者が購読をやめる
    void Unsubscribe(IObserver observer);
}
