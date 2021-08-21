using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrototypeLSWProgrammingInterview.UI.Abstract;
using TMPro;
using PrototypeLSWProgrammingInterview.Utility.VariableReference;
using System.Threading.Tasks;

namespace  PrototypeLSWProgrammingInterview.UI.Dialog
{
    public class DialogMenuController : MenuController
    {
        [SerializeField] TMP_Text dialogText;
        [SerializeField] TMP_Text personText;
        public override string Path => MenuPath.Dialog.DialogPlayer;
        [SerializeField] VariableStringReference dialogValue;
        bool isReadyToSkip;
        bool isClicking;
        bool isPlaying;
        void OnEnable(){
            dialogValue.OnUpdateVariable += UpdateText;
        }

        void OnDisable(){
            dialogValue.OnUpdateVariable -= UpdateText;
        }

        void UpdateText(){
            dialogText.text = $"" + dialogValue.lerpValue;
            if(!isClicking && dialogText.text == dialogValue.Value) isReadyToSkip = true;
        }

        
        protected override void OnShow(string path, params object[] data)
        {
            if(!isPlaying){
                isClicking = false;
                isReadyToSkip = false;
                dialogText.text = "";
                base.OnShow(path, data);
            }
        }

        protected override void OnShown(string path, params object[] data)
        {
            if(!isPlaying){
                base.OnShown(path, data);
                dialogValue.ForceRefresh();
                isPlaying = true;
            }
        }
       public void ChangeToFastSpeed(){
           if(isPlaying){
               isClicking = true;
               if(!isReadyToSkip){
                   dialogValue.ChangeToFastSpeed();
               }else{
                   IMenuController thisMenu = this;
                   thisMenu.Close(Path);
                   isPlaying = false;
                   dialogText.text = "";
                   dialogValue.ChangeToNormalSpeed();
               }
           }
        }

        public void ChangeToNormalSpeed(){
            isClicking = false;
            if(dialogText.text != dialogValue.Value){
                dialogValue.ChangeToNormalSpeed();
            }else{
                isReadyToSkip =  true;
            }
        }
    }    
}

