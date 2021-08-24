using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypeLSWProgrammingInterview.Utility{
    public static class LswScriptableObjectResource<T> where T : LswScriptableObject
    {
        static Dictionary<string, T> assetStored = new Dictionary<string, T>();
        public static T CreateInstanceObject(string path){
            if(!assetStored.ContainsKey(path)){
                T tObject = ScriptableObject.CreateInstance<T>();
                tObject.InitPath(path);
                RegisterAsset(path, tObject);
                return tObject;
            }else{
                return assetStored[path];
            }
        }

        public static void RegisterAsset(string path, T t){
            if(!assetStored.ContainsKey(path)){
                assetStored.Add(path, t);
            }else{
                Debug.Log("Asset Has Registered");
            }
        }

        public static void UnRegisterAsset(string path, T t){
            if(assetStored.ContainsKey(path)){
                assetStored.Remove(path);
            }else{
                Debug.Log("There is no Asset " + t.Path);
            }
        }


    }
}
