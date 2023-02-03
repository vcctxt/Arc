using System.Collections.Generic;
using UnityEngine;

namespace ArcCreate.Compose.Grid
{
    public interface IGridSettings
    {
        Rect ColliderArea { get; }

        Color PanelColor { get; }

        float SnapTolerance { get; }

        List<Line> Lines { get; }

        List<Area> Areas { get; }
    }
}