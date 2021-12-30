using System;
using TMPro;
using UnityEngine;
using Object = UnityEngine.Object;

namespace KiraiMod.KiraiButtonAPI.UI
{
    public class Group : KBase
    {
        public static Transform BaseHeader;
        public static Transform BaseButtons;

        internal static void Initialize(Transform QuickMenu)
        {
            BaseHeader = QuickMenu.Find("Header_QuickLinks");
            BaseButtons = QuickMenu.Find("Buttons_QuickLinks");
        }

        public Transform header;
        public Transform buttons;
        public TextMeshProUGUI headerText;

        public Group(string name, Transform parent, bool managed = true) : base(name, managed)
        {
            header = Object.Instantiate(BaseHeader, parent ?? BaseHeader.parent);
            buttons = Object.Instantiate(BaseButtons, parent ?? BaseButtons.parent);

            headerText = header.GetComponentInChildren<TextMeshProUGUI>();
            headerText.text = name;

            for (int i = 0; i < buttons.childCount; i++)
                Object.Destroy(buttons.GetChild(i).gameObject);
        }

        public override void Destroy()
        {
            Object.Destroy(header.gameObject);
            Object.Destroy(buttons.gameObject);
        }
        
        public void CreateButton(string name, Action onClick) => new UI.KButton(name, buttons, onClick);
    }
}
