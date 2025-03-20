﻿namespace UAppToolKit.Core.Animations.EasingFunction
{
    public class CubicEase : EasingFunctionBase
    {
        protected override float Function(float t)
        {
            return t*t*t;
        }
    }
}