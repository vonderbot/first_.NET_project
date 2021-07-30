﻿using System.IO;

namespace UniversityPET.dll
{
    public class FileReader : IReader
    {
        private readonly string _path;

        public FileReader(string path)
        {
            _path = path;
        }

        public string Read()
        {
            using var sr = new StreamReader(_path);
            return sr.ReadToEnd();
        }
    }
}