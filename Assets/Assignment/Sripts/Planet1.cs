using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet1 : Planets
{
    public override void Update()
    {
        base.Update();
        if (Input.GetMouseButtonDown(0) && isCurrent && !ClickOnPlanet)
        {
            startPosition = new Vector3(-9, 0, 0);
            endPosition = new Vector3(-6, 0, 0);
            transform.position = Vector3.Lerp(startPosition, endPosition, timer);
        }
    }
}
