using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Prototype
{
    internal sealed class Hp
    {
        public float MaxHP;
        public float CurrentHP;
        public override string ToString()
        {
            return $"MaxHP {MaxHP} CurrentHP {CurrentHP}";
        }
    }
}

