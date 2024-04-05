using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlanet : Planets
{
    GameObject PL;
    public float RandomLocationX, RandomLocationY;

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        Spawner();

    }

    public void Spawner()
    {
        RandomLocationX = Random.Range(-9, 9);
        RandomLocationY = Random.Range(-3, 9);
    }

}
