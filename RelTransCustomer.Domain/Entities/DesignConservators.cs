﻿using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignConservators
{
    public string? SpecNo { get; set; }

    public int? RevNo { get; set; }

    public double? TopPanel { get; set; }

    public double? SidePanel { get; set; }

    public double? Rim { get; set; }

    public double? Length { get; set; }

    public double? OilLevel { get; set; }

    public double? FeetHeight { get; set; }

    public double? FeetCentres { get; set; }

    public double? FlangeGuage { get; set; }

    public double? BodyGuage { get; set; }

    public double? CoverGuage { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }

    public int? ConsRevision { get; set; }

    public string? ConsStandard { get; set; }

    public double? FeetGauge { get; set; }

    public double? NettOilLitres { get; set; }

    public string? CorkMaterial { get; set; }

    public float? CorkGauge { get; set; }

    public float? CorkWidth { get; set; }

    public float? CorkLength { get; set; }

    public string? PaintMaterial { get; set; }

    public float? PaintThickness { get; set; }
}
