﻿using System.Reflection;

using DataBucket.Properties;

namespace DataBucket
{
    public readonly struct Settings
    {
        public static readonly string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //public static readonly string signalPath = Path.Combine(rootPath, "SignalPics");
        public static readonly string signalPath = @"D:\SignalPics\";
        public static readonly Bitmap plusImage = Resources.plus;
        public static readonly Bitmap plus2Image = Resources.plus2;
        public static readonly Bitmap minusImage = Resources.minus;
    }
}
