using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AdapterDecorator
{
    public class MyStringBuilder
    {
        private StringBuilder m_sb = new StringBuilder();

        public static implicit operator MyStringBuilder(string s)
        {
            var msb = new MyStringBuilder();
            msb.m_sb.Append(s);
            return msb;
        }

        public static MyStringBuilder operator +(MyStringBuilder msb, string s)
        {
            msb.Append(s);
            return msb;
        }

        public override string ToString()
        {
            return m_sb.ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ((ISerializable) m_sb).GetObjectData(info, context);
        }

        public StringBuilder Append(bool value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(byte value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(char value)
        {
            return m_sb.Append(value);
        }

        

        public StringBuilder Append(char value, int repeatCount)
        {
            return m_sb.Append(value, repeatCount);
        }

        public StringBuilder Append(char[]? value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(char[]? value, int startIndex, int charCount)
        {
            return m_sb.Append(value, startIndex, charCount);
        }

        public StringBuilder Append(decimal value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(double value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(short value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(int value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(long value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(object? value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(ReadOnlyMemory<char> value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(ReadOnlySpan<char> value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(sbyte value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(float value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(string? value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(string? value, int startIndex, int count)
        {
            return m_sb.Append(value, startIndex, count);
        }

        public StringBuilder Append(StringBuilder? value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(StringBuilder? value, int startIndex, int count)
        {
            return m_sb.Append(value, startIndex, count);
        }

        public StringBuilder Append(ushort value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(uint value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder Append(ulong value)
        {
            return m_sb.Append(value);
        }

        public StringBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0)
        {
            return m_sb.AppendFormat(provider, format, arg0);
        }

        public StringBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1)
        {
            return m_sb.AppendFormat(provider, format, arg0, arg1);
        }

        public StringBuilder AppendFormat(IFormatProvider? provider, string format, object? arg0, object? arg1, object? arg2)
        {
            return m_sb.AppendFormat(provider, format, arg0, arg1, arg2);
        }

        public StringBuilder AppendFormat(IFormatProvider? provider, string format, params object?[] args)
        {
            return m_sb.AppendFormat(provider, format, args);
        }

        public StringBuilder AppendFormat(string format, object? arg0)
        {
            return m_sb.AppendFormat(format, arg0);
        }

        public StringBuilder AppendFormat(string format, object? arg0, object? arg1)
        {
            return m_sb.AppendFormat(format, arg0, arg1);
        }

        public StringBuilder AppendFormat(string format, object? arg0, object? arg1, object? arg2)
        {
            return m_sb.AppendFormat(format, arg0, arg1, arg2);
        }

        public StringBuilder AppendFormat(string format, params object?[] args)
        {
            return m_sb.AppendFormat(format, args);
        }

        public StringBuilder AppendJoin(char separator, params object?[] values)
        {
            return m_sb.AppendJoin(separator, values);
        }

        public StringBuilder AppendJoin(char separator, params string?[] values)
        {
            return m_sb.AppendJoin(separator, values);
        }

        public StringBuilder AppendJoin(string? separator, params object?[] values)
        {
            return m_sb.AppendJoin(separator, values);
        }

        public StringBuilder AppendJoin(string? separator, params string?[] values)
        {
            return m_sb.AppendJoin(separator, values);
        }

        public StringBuilder AppendJoin<T>(char separator, IEnumerable<T> values)
        {
            return m_sb.AppendJoin(separator, values);
        }

        public StringBuilder AppendJoin<T>(string? separator, IEnumerable<T> values)
        {
            return m_sb.AppendJoin(separator, values);
        }

        public StringBuilder AppendLine()
        {
            return m_sb.AppendLine();
        }

        public StringBuilder AppendLine(string? value)
        {
            return m_sb.AppendLine(value);
        }

        public StringBuilder Clear()
        {
            return m_sb.Clear();
        }

        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            m_sb.CopyTo(sourceIndex, destination, destinationIndex, count);
        }

        public void CopyTo(int sourceIndex, Span<char> destination, int count)
        {
            m_sb.CopyTo(sourceIndex, destination, count);
        }

        public int EnsureCapacity(int capacity)
        {
            return m_sb.EnsureCapacity(capacity);
        }

        public bool Equals(ReadOnlySpan<char> span)
        {
            return m_sb.Equals(span);
        }

        public bool Equals(StringBuilder? sb)
        {
            return m_sb.Equals(sb);
        }

        public StringBuilder.ChunkEnumerator GetChunks()
        {
            return m_sb.GetChunks();
        }

        public StringBuilder Insert(int index, bool value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, byte value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, char value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, char[]? value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, char[]? value, int startIndex, int charCount)
        {
            return m_sb.Insert(index, value, startIndex, charCount);
        }

        public StringBuilder Insert(int index, decimal value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, double value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, short value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, int value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, long value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, object? value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, ReadOnlySpan<char> value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, sbyte value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, float value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, string? value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, string? value, int count)
        {
            return m_sb.Insert(index, value, count);
        }

        public StringBuilder Insert(int index, ushort value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, uint value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Insert(int index, ulong value)
        {
            return m_sb.Insert(index, value);
        }

        public StringBuilder Remove(int startIndex, int length)
        {
            return m_sb.Remove(startIndex, length);
        }

        public StringBuilder Replace(char oldChar, char newChar)
        {
            return m_sb.Replace(oldChar, newChar);
        }

        public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
        {
            return m_sb.Replace(oldChar, newChar, startIndex, count);
        }

        public StringBuilder Replace(string oldValue, string? newValue)
        {
            return m_sb.Replace(oldValue, newValue);
        }

        public StringBuilder Replace(string oldValue, string? newValue, int startIndex, int count)
        {
            return m_sb.Replace(oldValue, newValue, startIndex, count);
        }

        public string ToString(int startIndex, int length)
        {
            return m_sb.ToString(startIndex, length);
        }

        public int Capacity
        {
            get => m_sb.Capacity;
            set => m_sb.Capacity = value;
        }

        public char this[int index]
        {
            get => m_sb[index];
            set => m_sb[index] = value;
        }

        public int Length
        {
            get => m_sb.Length;
            set => m_sb.Length = value;
        }

        public int MaxCapacity => m_sb.MaxCapacity;
    }
}