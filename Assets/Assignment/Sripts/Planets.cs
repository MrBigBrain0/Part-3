using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Planets : MonoBehaviour
{
    public GameObject Planet;
    public Vector3 startPosition;
    public Vector3 endPosition;

    public float timer;
    bool ClickOnPlanet;
    bool isCurrent;

    public void Current(bool value)
    {
        isCurrent = value;
    }
    private void OnMouseDown()
    {
        PlanetControler.setCurrentPlanet(this);
        ClickOnPlanet = true;
    }
    private void OnMouseUp()
    {
        ClickOnPlanet = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
