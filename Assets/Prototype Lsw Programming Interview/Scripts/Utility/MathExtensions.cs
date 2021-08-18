using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using PrototypeLSWProgrammingInterview.Utility.VariableReference;
public static class MathExtensions
{
    static Dictionary<string, Tween> dotweenProcess = new Dictionary<string, Tween>();
    public static void LerpFloat(this VariableFloatReference variable, float targetValue, float duration, string hash = "", Action onUpdate = null){
        if(!string.IsNullOrEmpty(hash) && !dotweenProcess.ContainsKey(hash)){
            dotweenProcess.Add(hash, DOTween.To(()=> variable.lerpValue, x => variable.lerpValue = x, targetValue, duration).OnUpdate(
                ()=>onUpdate?.Invoke())
                .OnComplete(()=>onUpdate?.Invoke()));
            dotweenProcess[hash].Play();
        }else{
            if(dotweenProcess.ContainsKey(hash)){
                dotweenProcess[hash].Kill();
                dotweenProcess[hash] = DOTween.To(()=> variable.lerpValue, x => variable.lerpValue = x, targetValue, duration)
                .OnUpdate(()=>onUpdate?.Invoke())
                .OnComplete(()=>onUpdate?.Invoke());
            }
        }
    }
}
