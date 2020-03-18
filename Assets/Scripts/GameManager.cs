using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GuardTower guardTower;
    public List<GuardAgent> observers;


    void Start() {
        foreach(IObserver observer in observers) {
            guardTower.Register(observer);
        }
    }

    void Update() {

    }

}
