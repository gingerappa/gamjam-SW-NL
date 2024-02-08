using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace VNEngine
{
    /*
    This class looks in your LocalizedUI.csv for a given key and puts it in the language given by LocalizationManager.Language
    Attach this to any text element you wish to translate 
    */
    [RequireComponent(typeof(Text))]
    public class LocalizeTextElement : MonoBehaviour
    {
        public string Key;


        void Start()
        {
            LocalizeText();
        }

        public void LocalizeText()
        {
            if (string.IsNullOrEmpty(Key))
            {
                Debug.Log("Key not specified for LocalizeTextElement", this.gameObject);
            }
        }
    }
}