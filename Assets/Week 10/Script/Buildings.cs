using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : MonoBehaviour
{
    public GameObject Base;
    private Vector3 startPosition1;
    private Vector3 scaleChange1;
    public GameObject Wall;
    private Vector3 startPosition2;
    private Vector3 scaleChange2;
    public GameObject Roof;
    private Vector3 startPosition3;
    private Vector3 scaleChange3;
    public SpriteRenderer sr;
    private float time;
    Coroutine build;

    // Start is called before the first frame update
    void Start()
    {
        Base.SetActive(false);
        Wall.SetActive(false);
        Roof.SetActive(false);

        build = StartCoroutine(buildBase());

        if(Roof.active == true)
        {
            StopAllCoroutines();
        }
    }

    private void Update()
    {
        time += Time.deltaTime;

    }

    private void BaseBuild()
    {
        startPosition1 = Base.transform.position;
        scaleChange1 = new Vector3(0, 0, 0);
        Base.transform.position = Vector3.Lerp(startPosition1, scaleChange1, time);
    }
    private void WallBuild()
    {
        startPosition2 = Wall.transform.position;
        scaleChange2 = new Vector3(0, +1f, 0);
        Wall.transform.position = Vector3.Lerp(startPosition2, scaleChange2, time);
    }
    private void RoofBuild()
    {
        startPosition3 = Roof.transform.position;
        scaleChange3 = new Vector3(0, +2f, 0);
        Roof.transform.position = Vector3.Lerp(startPosition3, scaleChange3, time);

    }

    IEnumerator buildBase()
    {
        yield return new WaitForSeconds(2);

        if (Base.active == false)
        {
            Base.SetActive (true);
            BaseBuild();
        }

        yield return new WaitForSeconds(2);

        if(Wall.active == false)
        {
            Wall.SetActive (true);
            WallBuild();
        }

        yield return new WaitForSeconds(2);

        if(Roof.active == false)
        {
            Roof.SetActive (true); 
            RoofBuild();

        }
       
    }
}
