using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Car))]

public class CarEditor : Editor
{

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Car myTarget = (Car)target;

        myTarget.carPrefab = (GameObject)EditorGUILayout.ObjectField(myTarget.carPrefab, typeof(GameObject), true);

        myTarget.speed = EditorGUILayout.IntField("Minha Velocidade", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("Marcha", myTarget.gear);

        EditorGUILayout.LabelField("Velocidade total", myTarget.Totalspeed.ToString());

        EditorGUILayout.HelpBox("Calcule a velocidade total do carro!", MessageType.Info);

        if(myTarget.Totalspeed > 200)
        {
            EditorGUILayout.HelpBox("Velocidade acima do permitido", MessageType.Error);
        }

        GUI.color = Color.blue;

        if (GUILayout.Button("Create Car"))
        {
            myTarget.CreateCar();
        }
    } 
}
