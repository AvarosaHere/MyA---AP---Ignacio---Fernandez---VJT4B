﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBasicSlowBehaviour : UnitBullet
{
    void Start()
    {
        _strategy[0] = new BulletBasicAdvance(FlyweightPointer.BulletSphere.speed, _transform);
        _currentStrategy = _strategy[0];
    }

    void Update()
    {
        if (_currentStrategy != null)
            _currentStrategy.BulletAdvance();
    }

    public void OnTriggerEnter(Collider other)
    {
        BackStock.Invoke(this);
    }
}
