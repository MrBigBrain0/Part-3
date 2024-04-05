using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetControler : MonoBehaviour
{

    public static PlanetControler Instance;
    public static Planets CurrentPlanet { get; private set; }

    //setting up the controler
    public static void setCurrentPlanet(Planets planet)
    {
        //telling the programing how to identiy a current planet
        if(CurrentPlanet != null)
        {
            CurrentPlanet.Current(false);
        }
        CurrentPlanet = planet;
        CurrentPlanet.Current(true);

    }
    // Start is called before the first frame update
    void Start()
    {
        //allows instance to be called from any class.
        Instance = this;
    }
}
