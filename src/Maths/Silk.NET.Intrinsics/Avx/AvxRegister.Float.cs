// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Intrinsics.Avx
{
    public partial class AvxRegister : IRegister<float>
    {
        public unsafe WorkUnit<float>* LengthSquared(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Length(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Normalize2(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* NormalizeApprox2(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Normalize3(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* NormalizeApprox3(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Normalize4(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* NormalizeApprox4(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Conjugate(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Inverse(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* DotProduct2(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* DotProduct3(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* DotProduct4(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Add(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Subtract(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Equal(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* NotEqual(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Negate(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Lerp(WorkUnit<float>* left, WorkUnit<float>* right, WorkUnit<float>* amount)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Slerp(WorkUnit<float>* left, WorkUnit<float>* right, WorkUnit<float>* amount)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Concatenate(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Multiply(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Transform2(WorkUnit<float>* value, WorkUnit<float>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Transform3(WorkUnit<float>* value, WorkUnit<float>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Transform4(WorkUnit<float>* value, WorkUnit<float>* quaternion)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Abs(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* HorizontalAdd(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Shuffle(WorkUnit<float>* value, byte control)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* X(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Y(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Z(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* W(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Sin(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* SinApprox(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Cos(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* CosApprox(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Tan(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* TanApprox(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void SinCos(WorkUnit<float>* vector, out WorkUnit<float>* sin, out WorkUnit<float>* cos)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Shuffle(WorkUnit<float>* left, WorkUnit<float>* right, byte control)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* MultiplyAddFused(WorkUnit<float>* x, WorkUnit<float>* y, WorkUnit<float>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* MultiplyAddFast(WorkUnit<float>* x, WorkUnit<float>* y, WorkUnit<float>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* NegateMultiplyAddFused(WorkUnit<float>* x, WorkUnit<float>* y, WorkUnit<float>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* NegateMultiplyAddFast(WorkUnit<float>* x, WorkUnit<float>* y, WorkUnit<float>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* MultiplySubtractFused(WorkUnit<float>* x, WorkUnit<float>* y, WorkUnit<float>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* MultiplySubtractFast(WorkUnit<float>* x, WorkUnit<float>* y, WorkUnit<float>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* NegateMultiplySubtractFused(WorkUnit<float>* x, WorkUnit<float>* y, WorkUnit<float>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* NegateMultiplySubtractFast(WorkUnit<float>* x, WorkUnit<float>* y, WorkUnit<float>* z)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Divide(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Sqrt(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Max(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* Min(WorkUnit<float>* vector)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* GreaterThan(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* LessThan(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* GreaterThanOrEqualTo(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* LessThanOrEqualTo(WorkUnit<float>* left, WorkUnit<float>* right)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreScalar(WorkUnit<float>* vector, float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector2(WorkUnit<float>* vector, float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector3(WorkUnit<float>* vector, float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe void StoreVector4(WorkUnit<float>* vector, float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* ToScalar(float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* ToVector2(float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* ToVector3(float* ptr)
        {
            throw new System.NotImplementedException();
        }

        public unsafe WorkUnit<float>* ToVector4(float* ptr)
        {
            throw new System.NotImplementedException();
        }
    }
}
