using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class FileScripts : MonoBehaviour
{
    public string stringName = "Shuvam";
    public int age = 24;
    public float marks = 76.6f;
    public string filePath = @"C:\Users\Shuvam Sahoo\Unity Project\MyData\Shuvam.txt";
    // Start is called before the first frame update
    void Start()
    {/*
        StreamWriter streamWriter = new StreamWriter(filePath);
        //BinaryWriter binaryWriter = new BinaryWriter();
        streamWriter.WriteLine(age);                     
        streamWriter.WriteLine(name);
        streamWriter.Close();
        
        StreamReader streamReader = new StreamReader(filePath);
        //print(streamReader.ReadLine());
        print(streamReader.ReadToEnd());
        streamWriter.Close();
        */
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            CreateText();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ReadText();
        }
    }

    private void CreateText()
    {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        BinaryWriter binaryWriter = new BinaryWriter(fileStream);
        binaryWriter.Write(age);
        binaryWriter.Close();
        fileStream.Close();
    }

    private void ReadText()
    {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        BinaryReader binaryReader = new BinaryReader(fileStream);
        print(binaryReader.Read());
        binaryReader.Close();
        fileStream.Close();
        
    }

}
