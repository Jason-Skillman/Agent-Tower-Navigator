using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardTower : MonoBehaviour, IObservable {

    private List<IObserver> observers;
    

    void Awake() {
        observers = new List<IObserver>();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            Notify();
        }
    }

    public void Register(IObserver observer) {
        observers.Add(observer);
    }

    public void Unregister(IObserver observer) {
        observers.Remove(observer);
    }

    public void Notify() {
        foreach(IObserver observer in observers)
            observer.Update();
    }

}
