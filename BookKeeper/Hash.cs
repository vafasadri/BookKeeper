using System;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Security;

namespace BookKeeper
{
    public readonly struct Hash
    {
        public static readonly Hash Empty = new Hash();       
        public readonly long s_0;
        public readonly long s_1;
        public readonly long s_2;
        public readonly long s_3;
        public override bool Equals(object obj)
        {
            return obj is Hash other &&
                s_0 == other.s_0 &&
                s_1 == other.s_1 &&
                s_2 == other.s_2 &&
                s_3 == other.s_3;
        }
        public static bool operator ==(Hash one, Hash other)
        {
            return one.Equals(other);
        }
        public static bool operator !=(Hash one, Hash other)
        {
            return !one.Equals(other);
        }
        public override int GetHashCode()
        {
            return (s_0 ^ s_1 ^ s_2 ^ s_3).GetHashCode();
        }
        public Hash(byte[] input)
        {
            if (input.Length != 32) throw new ArgumentException();
            s_0 = BitConverter.ToInt64(input, 0);
            s_1 = BitConverter.ToInt64(input, 8);
            s_2 = BitConverter.ToInt64(input, 16);
            s_3 = BitConverter.ToInt64(input, 24);
        }
        [SecuritySafeCritical]
        public unsafe byte[] GetBytes()
        {
            var bytes = new byte[32];       
            fixed (byte* _ptr = bytes)
            {
                long* ptr = (long*) _ptr;
                ptr[0] = s_0;
                ptr[1] = s_1;
                ptr[2] = s_2;
                ptr[3] = s_3;
            }         
            return bytes;
        }
    };
}