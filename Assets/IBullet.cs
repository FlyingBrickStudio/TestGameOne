using UnityEngine;
using System.Collections;

public interface IBullet
{
    //Basic bullet params Kirk Montrose
    double BulletVelocity();
    bool HasProjectileArc();
    double BulletPower();
    int BulletID();
    int ColorOfExplsion();
}
