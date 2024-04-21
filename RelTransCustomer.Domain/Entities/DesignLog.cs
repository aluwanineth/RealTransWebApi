﻿using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignLog
{
    public int Id { get; set; }

    public string? SpecNo { get; set; }

    public string? CheckedInOut { get; set; }

    public string? User { get; set; }

    public DateTime? Date { get; set; }

    public int? ChangesMade { get; set; }

    public int? RevNo { get; set; }
}
