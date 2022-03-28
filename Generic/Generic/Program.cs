using System;
using System.IO;

namespace Generic
{
    partial class Program
    {
        static void Main(string[] args)
        {
            LocalFileLogger<int> loger1 = new LocalFileLogger<int>("D:\\visual studio\\projects\\Generic\\File.txt");
            loger1.LogInfo("message1");
            loger1.LogWarning("message2");
            loger1.LogError("message3", new Exception("error"));

            LocalFileLogger<string> loger2 = new LocalFileLogger<string>("D:\\visual studio\\projects\\Generic\\File.txt");
            loger2.LogInfo("message1");
            loger2.LogWarning("message2");
            loger2.LogError("message3", new Exception("error"));

            LocalFileLogger<char> loger3 = new LocalFileLogger<char>("D:\\visual studio\\projects\\Generic\\File.txt");
            loger3.LogInfo("message1");
            loger3.LogWarning("message2");
            loger3.LogError("message3", new Exception("error"));
        }
    }
}