namespace UAppToolKit.Animations.EasingFunction
{
    public class QuinticEase : EasingFunctionBase
    {
        protected override float Function(float t)
        {
            return t*t*t*t*t;
        }
    }
}