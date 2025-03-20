using UnityEngine;

namespace UAppToolKit.Animations.EasingFunction
{
    public class SineEase : EasingFunctionBase
    {
        protected override float Function(float t)
        {
            return 1 - Mathf.Cos(t*(Mathf.PI/2));
        }
    }
}