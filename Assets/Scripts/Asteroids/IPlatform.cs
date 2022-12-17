using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Abstrac_Factory
{
    public interface IPlatform
    {
        IInput Input { get; }
        IWindow Window { get; }
    }
}
