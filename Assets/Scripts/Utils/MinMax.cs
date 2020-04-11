using System;
using Sirenix.OdinInspector;

namespace Utils
{
    [Serializable]
    [InlineProperty(LabelWidth = 30)]
    public struct MinMax<T> where T : IComparable
    {
        [HorizontalGroup(MarginRight = 10)]
        public T min;

        [HorizontalGroup]
        [ValidateInput("ValidRange")]
        public T max;

#if UNITY_EDITOR
        private bool ValidRange(T value, ref string msg)
        {
            if (value.CompareTo(min) >= 0)
                return true;

            msg = "The max value should be larger than or equal to the min value";
            return false;
        }
#endif
    }
}
