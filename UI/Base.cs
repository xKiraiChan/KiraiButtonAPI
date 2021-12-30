using System.Collections.Generic;

namespace KiraiMod.KiraiButtonAPI.UI
{
    public class KBase
    {
        public static Dictionary<string, KBase> elements = new();

        internal static void Unload()
        {
            foreach (var element in elements.Values)
                element.Destroy();
            elements.Clear();
        }

        public KBase(string name, bool managed = true)
        {
            if (managed) elements.Add(name, this);
        }

        public virtual void Destroy() { }
    }
}
