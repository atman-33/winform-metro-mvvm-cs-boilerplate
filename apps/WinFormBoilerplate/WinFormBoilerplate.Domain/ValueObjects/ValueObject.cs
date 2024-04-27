﻿namespace WinFormBoilerplate.Domain.ValueObjects
{
    /// <summary>
    /// ValueObjectの基底クラス
    /// </summary>
    /// <typeparam name="T">型</typeparam>
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object? obj)
        {
            var vo = obj as T;
            switch (vo)
            {
                case null:
                    return false;
                default:
                    return EqualsCore(vo);
            }
        }

        public static bool operator ==(ValueObject<T> vo1, ValueObject<T> vo2)
        {
            return Equals(vo1, vo2);
        }

        public static bool operator !=(ValueObject<T> vo1, ValueObject<T> vo2)
        {
            return !Equals(vo1, vo2);
        }

        protected abstract bool EqualsCore(T other);

        protected abstract int GetHashCodeCore();

        public override string? ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return GetHashCodeCore();
        }
    }
}