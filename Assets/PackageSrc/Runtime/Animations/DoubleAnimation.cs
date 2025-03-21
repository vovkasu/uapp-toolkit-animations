﻿using UnityEngine;

namespace UAppToolKit.Animations
{
    public class DoubleAnimation : SimpleAnimationBase
    {
        public float From;
        public float To;

        public override void InitAnimation()
        {
            base.InitAnimation();

            IsEnabled = true;
            if (_timeStateSec > _durationSec)
            {
                IsEnabled = false;
            }
        }

        protected override object InternalTick()
        {
            if (_timeStateSec >= _durationSec)
            {
                var result = To;
                if (AutoReverse)
                {
                    var temp = From;
                    From = To;
                    To = temp;
                    InitAnimation();
                    if (!RepeatForever)
                    {
                        AutoReverse = false;
                    }
                }
                else
                {
                    IsEnabled = false;
                    _timeStateSec = 0;
                }
                return result;
            }

            return Mathf.LerpUnclamped(From, To, EasingFunction.FunctionAndMode(_timeStateSec / _durationSec));
        }
    }

}