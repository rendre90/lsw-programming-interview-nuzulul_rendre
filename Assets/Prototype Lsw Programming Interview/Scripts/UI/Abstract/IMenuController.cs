using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PrototypeLSWProgrammingInterview.UI.Abstract
{
    public interface IMenuController
    {
        string Path { get; }
        bool HidePreviousMenu { get; }
        void Show(string path, params object[] data);
        void Disable(string path);
        void Enable(string path);
        void Hide(string path);
        void Unhide(string path);
        void Close(string path);
    }
}
