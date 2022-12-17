using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Abstrac_Factory
{
    internal sealed class ConsoleInput : IInput
    {
        public string Name => nameof(ConsoleInput);
    }
}
