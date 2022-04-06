using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SerializeAndDeserialize : MonoBehaviour
{
    public string filePath;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
    }

    private void Load()
    {
        filePath = Application.persistentDataPath + "/MyFile.Shuvam";
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        BinaryReader binary = new BinaryReader(fileStream);
        print(binary.ReadString());
        //print(binary.ReadInt32());
        binary.Close();
        fileStream.Close();
    }

    private void Save()
    {
        filePath = Application.persistentDataPath + "/MyFile.Shuvam";
        FileStream fileStream = new FileStream(filePath,FileMode.OpenOrCreate);
        BinaryWriter binary = new BinaryWriter(fileStream);
        binary.Write("Hello!!! My Name is Shuvam\n I am working on PurpleTalk\n Now I am in Hyderabad");
        binary.Write(65);
        binary.Close();
        //fileStream.Close();
    }
}
