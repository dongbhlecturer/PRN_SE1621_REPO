﻿using System.IO;
using System.Text;
namespace Prn.FileStreamDemo;

public class Program
{
    public static void Main()
    {
        //1. msg ta muon write vao file (FileStream)
        string msg = "ABCDEFGH";
        //2. convert msg => array bytes
        byte[] bufferBytes = Encoding.Default.GetBytes(msg);
        //3. dung FileStream to write to file by path
        using FileStream fileStream = File.Open("data.dat", FileMode.Create);
        //4. execute insert data to file
        fileStream.Write(bufferBytes, 0, bufferBytes.Length);
        fileStream.Position = 0;


    }
}