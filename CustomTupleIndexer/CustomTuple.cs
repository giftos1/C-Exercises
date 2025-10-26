using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTupleIndexer
{
    public class PairOfArrays<TLeft, TRight>
    {
        private readonly TLeft[] _left;
        private readonly TRight[] _right;
        public PairOfArrays(TLeft[] left, TRight[] right)
        {
            _left = left;
            _right = right;
        }

        public (TLeft, TRight) this[int leftIndex, int rightIndex]
        {
            get
            {
                try
                {
                    return (_left[leftIndex], _right[rightIndex]);
                }
                catch (IndexOutOfRangeException)
                {

                    throw new IndexOutOfRangeException();
                }

            }
            set
            {

                try
                {
                    _left[leftIndex] = value.Item1;
                    _right[rightIndex] = value.Item2;
                }
                catch (IndexOutOfRangeException)
                {

                    throw new IndexOutOfRangeException();
                }

            }
        }
    }
}
