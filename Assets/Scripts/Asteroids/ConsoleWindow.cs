using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Abstrac_Factory
{
internal sealed class ConsoleWindow : IWindow
{
    public string Name => nameof(ConsoleWindow);
}
}

