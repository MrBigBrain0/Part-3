using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurplePl : Planets
{
    //vector 3 for the lerp animation
    private Vector3 startPosition = new Vector3(8, 3, 0);
    private Vector3 endPosition = new Vector3(8, -3, 0);
    public float desiredTime = 3f;
    //bool variable to call the Ienumerator
    public bool move = false;

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        //basses for the curutine to start
        move = true;
        StartCoroutine(shiftV());
    }
    //curutine wich loops the lerp animation as long as the curser was pressed and held down in the raduis of the planet.
    IEnumerator shiftV()
    {
        if (move == true)
        {
            Planet2Move();
        }
        yield return null;
        //loops the curoutine
        StartCoroutine(shiftV());
    }

    //lerp animation
    protected void Planet2Move()
    {
        float total = timer / desiredTime;
        transform.position = Vector3.Lerp(startPosition, endPosition, curve.Evaluate(total));
    }
    //stops the animation once the player realses pressure from the mouse leaving the planet in its last location 
    public override void OnMouseUp()
    {
        base.OnMouseUp();
        StopAllCoroutines();

    }
}
