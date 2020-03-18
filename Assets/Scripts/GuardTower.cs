using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardTower : IObservable {

    private List<IObserver> observers;
    

    void Awake() {
        observers = new List<IObserver>();
    }

    void Update() {
        
    }

    public void Register(IObserver observer) {
        observers.Add(observer);
    }

    public void Unregister(IObserver observer) {
        observers.Remove(observer);
    }

    public void Notify() {

    }

}
