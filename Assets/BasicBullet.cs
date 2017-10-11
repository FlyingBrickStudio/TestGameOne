using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBullet : MonoBehaviour, IBullet {
    Vector3 v = new Vector3();
    // Use this for initialization
    void Start () {
        
       

    }
	
	// Update is called once per frame
	void Update () {
        double movementSpeed = BulletVelocity();

       v.y = (float)  movementSpeed * Time.deltaTime;
       transform.Translate(v);


    }

    public  double BulletVelocity()
    {
        return 50;
    }

    public bool HasProjectileArc()
    {
        return false;
    }

    public double BulletPower()
    {
        return 10;
    }

    public int BulletID()
    {
        return 1;
    }

    public int ColorOfExplsion()
    {
        return 1;
    }
}
