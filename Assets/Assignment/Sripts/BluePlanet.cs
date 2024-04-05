using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class BluePlanet : Planets
{
    private Rigidbody2D MT;
    public GameObject Meteorite;
    public Transform Spawn;

    public bool shoot = false;
    public float MtSpeed;
    public float RandomDirectionMod,RandomSpeed;

    Coroutine turbulence;
    public override void OnMouseDown()
    {
        base.OnMouseDown();
        shoot = true;
        StartCoroutine(ShootM());
    }
    IEnumerator ShootM()
    {
        if (shoot == true)
        {
        meteor();
        }
        yield return null;
        yield return new WaitForSeconds(3);
        StartCoroutine(ShootM());

    }
    protected void meteor()
    {
        GameObject newMetorite = Instantiate(Meteorite, Spawn.position, Spawn.rotation);
        RandomDirectionMod = Random.Range(-10, 10);
        RandomSpeed = Random.Range(40f, 80f);
        newMetorite.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f + RandomDirectionMod, 5f) * RandomSpeed);
    }

    public override void OnMouseUp()
    {
        base.OnMouseUp();
        StopAllCoroutines();

    }
}
