using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class NestedData : MonoBehaviour
{
    string name = "Shuvam";
    int myScore = 50;
    int maxScore = 100;
    int maxHealth = 100;
    int myHealth = 80;

    public string filePath;

    [System.Serializable]
    public class ToSerializeData
    {
        public string name;
        public int myScore;
        public int myHealth;


    }
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SavaData();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            LoadData();
        }
    }

    public void SavaData()
    {
        BinaryFormatter binary = new BinaryFormatter();
        filePath = Application.persistentDataPath + "/Sahoo.Shuvam";
        FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
        //FileStream fileStream = File.Open(filePath,FileMode.Open);
        //BinaryWriter binary = new BinaryWriter(fileStream);
        
        ToSerializeData toSerializeData = new ToSerializeData();
        toSerializeData.name = name;
        toSerializeData.myScore = myScore;
        toSerializeData.myHealth = myHealth;
        binary.Serialize(fileStream, toSerializeData);
        fileStream.Close();
        
    }

    public void LoadData()
    {
        filePath = Application.persistentDataPath + "/Sahoo.Shuvam";
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream fileStream = File.Open(filePath, FileMode.Open);
        ToSerializeData toDeserializeData = binaryFormatter.Deserialize(fileStream) as ToSerializeData;
        print(toDeserializeData.name);
        print(toDeserializeData.myScore);
        print(toDeserializeData.myHealth);
        fileStream.Close();
    }
}


