using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;

namespace Screens
{
public enum ScreenType
{
        Panel,
        Info_Panel,
        Shop
}
    public class ScreenBase : MonoBehaviour
    {
        public ScreenType screenType;

        public List<Transform> listofObjetcs;
        public List<Typper> listofPhrases;

        public Image uiBackgroung; 
        public bool startHided = false;

        [Header("Animation")]
        public float delayBetweenObjects = .5f;
        public float animationDuration = .3f;


        // Start is called before the first frame update
        void Start()
        {
            if (startHided)
            {
                HideObjects();
            }

        }
        [Button]
        public virtual void Show()
        {
            ShowObjects();
            Debug.Log("Show");
        }

        [Button]
        public virtual void Hide()
        {
            Debug.Log("Hide");
            HideObjects();
        }

        private void HideObjects()
        {
            listofObjetcs.ForEach(i => i.gameObject.SetActive(false));
            uiBackgroung.enabled = false; 
        }
        private void ShowObjects()
        {
            for(int i = 0; i < listofObjetcs.Count; i++)
            {
                var obj = listofObjetcs[i];

                obj.gameObject.SetActive(true);
                //obj.DOScale(0, animationDuration).From().SetDelay(i * delayBetweenObjects);
            }

            Invoke(nameof(StartType), delayBetweenObjects * listofObjetcs.Count);
            uiBackgroung.enabled = true;
        }

        private void StartType()
        {
            for (int i = 0; i < listofPhrases.Count; i++)
            {
                listofPhrases[i].StartType();
            }

        }

        private void ForceShowObjects()
        {
            listofObjetcs.ForEach(i => i.gameObject.SetActive(true));
            uiBackgroung.enabled = true;

        }
    }


}
