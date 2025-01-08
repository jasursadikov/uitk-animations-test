using System.Diagnostics;
using System.Linq;
using Figma;
using Figma.Attributes;
using UnityEngine.UIElements;

namespace UITKAnimationsTest
{
    [Uxml("Main/DummyFrame")]
    public class DummyFrame : Element
    {
        [Query("SyncList")] VisualElement syncList;
        [Query("SyncList/Element")] CustomElement syncListElement;

        void Start()
        {
            UnityEngine.Debug.Log("Sync is invoked");
            Stopwatch watch = Stopwatch.StartNew();
            // syncListElement.Sync(syncList, 0, Enumerable.Range(0, 100));
            UnityEngine.Debug.Log(watch.ElapsedMilliseconds);
        }
    }

    public class CustomElement : SyncButtonSimple<int>
    {
        public new class UxmlFactory : UxmlFactory<CustomElement> { }

        public override bool IsVisible(int index, int data) => true;
    }
}