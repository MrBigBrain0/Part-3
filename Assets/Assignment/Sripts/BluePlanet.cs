using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class BluePlanet : Planets
{   //things to spawn the meteor
    public GameObject Meteorite;
    public Transform Spawn;

    //variables for a random range geerator
    public bool shoot = false;
    public float MtSpeed;
    public float RandomDirectionModx, RandomDirectionMody,RandomSpeed;

    public override void OnMouseDown()
    {
        
        base.OnMouseDown();
        //basses for the curutine to start
        shoot = true;
        //calls the coroutine when the mouse button is pressed down in the area of the blue planet. it will loop has long as the 
        //button stays down
        StartCoroutine(ShootM());
    }
    IEnumerator ShootM()
    {
        //the curutine is spawing metiors esentually every frame as long as shoot is true.
        if (shoot == true)
        {
        meteor();
        }
        yield return null;
        yield return new WaitForSeconds(3);
        //loops the curoutine 
        StartCoroutine(ShootM());

    }
    protected void meteor()
    {
        //randomly spawns the meteor and gives it force to fly out at diffrent speeds
        GameObject newMetorite = Instantiate(Meteorite, Spawn.position, Spawn.rotation);
        RandomDirectionModx = Random.Range(-10, 10);
        RandomDirectionMody = Random.Range(-10, 10);
        RandomSpeed = Random.Range(20f, 60f);
        newMetorite.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f + RandomDirectionModx, RandomDirectionMody) * RandomSpeed);
    }

    public override void OnMouseUp()
    {
        base.OnMouseUp();
        //stops the coroutines once the left mouse key is finied being pressed.
        StopAllCoroutines();

    }
}
