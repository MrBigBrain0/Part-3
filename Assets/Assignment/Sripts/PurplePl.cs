using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurplePl : Planets
{
    public override void Update()
    {
        base.Update();
        if (Input.GetMouseButtonDown(0) && isCurrent && !ClickOnPlanet)
        {
            startPosition = new Vector3(0, 3, 0);
            endPosition = new Vector3(0, -3, 0);
            transform.position = Vector3.Lerp(startPosition, endPosition, timer);
        }
    }
}
