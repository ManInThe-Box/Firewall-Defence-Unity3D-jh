﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonDebuff : Debuff
{
    private float tickTime;
    private float timeSinceTick;
    private float tickDamage;

    public PoisonDebuff(float tickDamage, float tickTime, float duration, Viruses target) : base(target, duration)
    {


        this.tickDamage = tickDamage;
        this.tickTime = tickTime;

    }



    public override void Update()
    {
        if (target != null)
        {
            timeSinceTick += Time.deltaTime;

            if (timeSinceTick >= tickTime)
            {
                timeSinceTick = 0;
                target.TakeDamage(tickDamage, Element.Corrupt);
            }
        }
      
        base.Update();
    }

}
