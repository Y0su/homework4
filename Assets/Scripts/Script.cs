using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public abstract class Vehicle
    {
        public abstract void Go();
    }
    public class Car : Vehicle
    {
        public override void Go()
        {
            Debug.Log("vroom-vroom");
        }
    }
    public class Ship : Vehicle
    {
        public override void Go()
        {
            Debug.Log("toot-toot");
        }
    }
    public class Plane : Vehicle
    {
        public override void Go()
        {
            Debug.Log("whoosh whoosh");
        }
    }
    public void Start()
    {
        Vehicle car = new Car();
        Vehicle ship = new Ship();
        Vehicle plane = new Plane();
        car.Go();
        ship.Go();
        plane.Go();
    }
}

