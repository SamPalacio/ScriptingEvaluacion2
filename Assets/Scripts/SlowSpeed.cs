using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowSpeedState : MonoBehaviour, ICarState
{
    public void Execute(Car car)
    {
        car.Speed = 5f;
    }
}
