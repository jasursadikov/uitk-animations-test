using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Example : MonoBehaviour
{
    IEnumerator Start()
    {
        var doc = GetComponent<UIDocument>();
        yield return new WaitForSeconds(1);
        doc.rootVisualElement.Q("Button2").AddToClassList("multistate_element__state3");
    }
}