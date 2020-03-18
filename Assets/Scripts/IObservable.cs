using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservable {

    public void Register(IObserver observer);
    public void Unregister(IObserver observer);
    public void Notify();

}
