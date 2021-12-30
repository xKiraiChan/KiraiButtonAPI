using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace KiraiMod.KiraiButtonAPI.UI
{
    public class KButton : KBase
    {
        public GameObject self;
        public TMP_Text text;
        public Button button;

        public KButton(string name, Transform parent, Action onClick, bool managed = true) : base(name + parent.name, managed)
        {
            self = Object.Instantiate(Memory.BaseButton.gameObject, parent);

            text = self.transform.Find("Text_H4").GetComponent<TextMeshProUGUI>();
            text.text = name;

            button = self.transform.GetComponent<Button>();
            button.onClick = new Button.ButtonClickedEvent();
            button.onClick.AddListener(onClick);
        }

        public override void Destroy() => Object.Destroy(self);
    }
}
