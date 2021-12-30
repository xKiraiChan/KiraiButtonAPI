using MelonLoader;
using System;

[assembly: MelonInfo(typeof(KiraiMod.KiraiButtonAPI.Controller), "KiraiButtonAPI", "0.1.0", "Kirai Chan", "github.com/xKiraiChan/KiraiButtonAPI")]
[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonColor(ConsoleColor.Yellow)]

namespace KiraiMod.KiraiButtonAPI
{
    public class Controller : MelonMod
    {
        public static event Action<UI.Page> OnUILoad = new(DefaultLoad);
        public static event Action OnUIUnload = new(DefaultUnload);

        public static void Load() => OnUILoad(new UI.Page(Memory.Banner.parent));
        public static void Unload() => OnUIUnload();

        public static bool loaded = false;

        private static void DefaultLoad(UI.Page ui)
        {
            Memory.Banner.gameObject.active = false;
        }

        private static void DefaultUnload()
        {
            Memory.Banner.gameObject.active = true;
            UI.KBase.Unload();
        }

        public override void OnApplicationStart() => MelonCoroutines.Start(CoInitialize());

        private static System.Collections.IEnumerator CoInitialize()
        {
            for (int i = 0; i < 3; i++)
                yield return null;

            Memory.Initialize();
            UI.Group.Initialize(Memory.QuickMenu);

            Load();
        }
    }
}
