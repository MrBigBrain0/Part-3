using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet1 : Planets
{
    //vector 3 for the lerp animation
    private Vector3 startPosition = new Vector3(-9,0,0);
    private Vector3 endPosition = new Vector3(-6,0,0);
    public float desiredTime = 3f;
    //bool variable to call the Ienumerator
    public bool move = false;

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        //basses for the curutine to start
        move = true;
        StartCoroutine(shiftH());
    }
    //curutine wich loops the lerp animation as long as the curser was pressed and held down in the raduis of the planet.
    IEnumerator shiftH()
    {
        if (move == true)
        {
            Planet1Move();
        }
        yield return null;
        StartCoroutine(shiftH());
    }
    //lerp animation
    protected void Planet1Move()
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
