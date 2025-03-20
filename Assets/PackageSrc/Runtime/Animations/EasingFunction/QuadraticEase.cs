namespace UAppToolKit.Animations.EasingFunction
{
    public class QuadraticEase : EasingFunctionBase
    {
        protected override float Function(float t)
        {
            return t*t;
        }
    }
}