using UnityEngine;

namespace Ellyality.Display
{
    [AddComponentMenu("Ellyality/Visual/Display Control")]
    public class DisplayControl : MonoBehaviour
    {
        [SerializeField] bool StartAtBegining;
        [SerializeField] int ActiveCount;

        private void Start()
        {
            if (!StartAtBegining) return;

            for(int i = 0; i < ActiveCount; i++)
            {
                Activate(i);
            }
        }

        public void ActivateDisplay1() => Activate(1);
        public void ActivateDisplay2() => Activate(2);
        public void ActivateDisplay3() => Activate(3);
        public void ActivateDisplay4() => Activate(4);
        public void ActivateDisplay5() => Activate(5);
        public void ActivateDisplay6() => Activate(6);
        public void ActivateDisplay7() => Activate(7);
        public void ActivateDisplay8() => Activate(8);
        public void ActivateDisplay9() => Activate(9);

        public void Activate(int i)
        {
            UnityEngine.Display.displays[i].Activate();
        }
    }
}
