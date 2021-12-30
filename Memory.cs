using UnityEngine;

namespace KiraiMod.KiraiButtonAPI
{
    public static class Memory
    {
        internal static void Initialize()
        {
            UserInterface = GameObject.Find("UserInterface").transform;
            QuickMenu = UserInterface.Find("Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup");
            Banner = QuickMenu.Find("Carousel_Banners");

            BaseButton = QuickMenu.Find("Buttons_QuickLinks/Button_Worlds");
        }

        public static Transform UserInterface;
        public static Transform QuickMenu;
        public static Transform Banner;

        public static Transform BaseButton;
    }
}
