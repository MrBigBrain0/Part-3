using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetControler : MonoBehaviour
{

    public static PlanetControler instance;
    public static Planets CurrentPlanet { get; private set; }

    public static void setCurrentPlanet(Planets planet)
    {
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
        instance = this;
    }
}
