using System;

namespace ValidationAttributes.Attributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxValue;

        public MyRangeAttribute(int min, int max)
        {
            this.minValue = min;
            this.maxValue = max;
        }
        public override bool IsValid(object obj)
        {
            var currentAge = Convert.ToInt32(obj);

            if (currentAge < this.minValue || currentAge > this.maxValue)
            {
                return false;
            }
            return true;
        }
    }
}
