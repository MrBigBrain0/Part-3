using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Planets : MonoBehaviour
{
    protected Vector3 startPosition;
    protected Vector3 endPosition;

    protected float timer;
    protected bool ClickOnPlanet;
    protected bool isCurrent;

    public void Current(bool value)
    {
        isCurrent = value;
    }

    public virtual void OnMouseDown()
    {
        PlanetControler.setCurrentPlanet(this);
        ClickOnPlanet = true;
    }

    public virtual void Update()
    {
        timer += Time.deltaTime;
    }

    public virtual void OnMouseUp()
    {
        ClickOnPlanet = false;
    }
}
