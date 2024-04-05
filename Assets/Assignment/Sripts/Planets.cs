using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Planets : MonoBehaviour
{
    // veriables in the parent class for the children to take

    //animation curve for the green and purple planet
    public AnimationCurve curve;

    //timer for green and purple planet 
    protected float timer;

    //sets up controler which effects all other planets 
    protected bool ClickOnPlanet;
    protected bool isCurrent;

    private void Start()
    {
        Current(false);
    }
    public void Current(bool value)
    {
        isCurrent = value;
    }

    public virtual void OnMouseDown()
    {
        //sets current planet to the planet clicked on
        PlanetControler.setCurrentPlanet(this);
        ClickOnPlanet = true;
    }
    public virtual void OnMouseUp()
    {
        //resets current planet when mouse button is up.
        ClickOnPlanet = false;
    }

    public virtual void FixedUpdate()
    {
        //timer for blue ad purple planet
        timer += Time.deltaTime;
    }

}
