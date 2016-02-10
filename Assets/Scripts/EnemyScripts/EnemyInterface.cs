using UnityEngine;
using System.Collections;
using System;

 public abstract class Enemy : Unit {

    public abstract void DoMove();

    public abstract void PrimaryMove();

    public abstract void SpecialMove();

}
