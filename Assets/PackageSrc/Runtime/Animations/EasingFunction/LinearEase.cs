﻿namespace UAppToolKit.Animations.EasingFunction
{
    public class Linear : EasingFunctionBase
    {
        protected override float Function(float timeProgress)
        {
            return timeProgress;
        }
    }
}