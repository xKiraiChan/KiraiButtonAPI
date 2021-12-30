using UnityEngine;

namespace KiraiMod.KiraiButtonAPI.UI
{
    public class Page
    {
        public Transform transform;

        public Page(Transform transform)
        {
            this.transform = transform;
        }

        public Group CreateGroup(string name, bool managed = true) => new Group(name, transform, managed);
    }
}
