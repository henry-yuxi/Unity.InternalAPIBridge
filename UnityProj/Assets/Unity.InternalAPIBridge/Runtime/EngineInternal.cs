using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public static partial class EngineInternal
{
    public static Event GetCurrent()
    {
        var fieldInfo = typeof(Event).GetField
        (
            name: "s_Current",
            bindingAttr: BindingFlags.Static | BindingFlags.NonPublic
        );

        return (Event)fieldInfo.GetValue(null);
    }
}
