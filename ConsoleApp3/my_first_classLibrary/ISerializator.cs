﻿namespace UniversityPET.dll
{
    public interface ISerializator<T>
    {
        public string Serialize(T obj);
        public T Deserialize(string buffer);
    }
}