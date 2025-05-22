// Get reference to the target table
var table = Model.Tables["# Measures"];


// Quantity



// QuantityPreviousMonth
var QuantityPreviousMonth = table.AddMeasure("QuantityPreviousMonth", 
@"CALCULATE(
    [Quantity],
    DATEADD(DimDate[Datekey], -1, MONTH)
)");
QuantityPreviousMonth.FormatString = "#,##0,.0";

// QuantityPreviousMonthLineChart
var QuantityPreviousMonthLineChart = table.AddMeasure("QuantityPreviousMonthLineChart", 
@"CALCULATE(
    [Quantity],
    DATEADD(DimDate[Datekey], -1, MONTH),
    ALL('DimDate - (LineChart-Highlighting)'[EoFMonth])
)");

// QuantityRemovedMonthFilter
var QuantityRemovedMonthFilter = table.AddMeasure("QuantityRemovedMonthFilter", 
@"CALCULATE(
    [Quantity],
    REMOVEFILTERS(DimDate[CalendarMonthLabelShort], DimDate[CalendarMonthLabelOrder])
)");
QuantityRemovedMonthFilter.FormatString = "#,##0,.0";

// QuantitySelctedMonthLineChart-
var QuantitySelctedMonthLineChartNeg = table.AddMeasure("QuantitySelctedMonthLineChart-", 
@"IF(
    [Quantity] - [QuantityPreviousMonthLineChart] < 0,
    [Quantity],
    BLANK()
)");

// QuantitySelctedMonthLineChart+
var QuantitySelctedMonthLineChartPos = table.AddMeasure("QuantitySelctedMonthLineChart+", 
@"IF(
    [Quantity] - [QuantityPreviousMonthLineChart] > 0,
    [Quantity],
    BLANK()
)");

// QuantityVsPreviousMonth
var QuantityVsPreviousMonth = table.AddMeasure("QuantityVsPreviousMonth", 
@"DIVIDE(
    [Quantity] - [QuantityPreviousMonth],
    [QuantityPreviousMonth]
)");
QuantityVsPreviousMonth.FormatString = "▲0.0%;▼0.0%";

// QuantityVsPreviousMonthCF
var QuantityVsPreviousMonthCF = table.AddMeasure("QuantityVsPreviousMonthCF", 
@"IF(
    [Quantity] - [QuantityPreviousMonth] < 0,
    ""#FA0103"",
    ""#69BA16""
)");

// QuantityLineSubtitle
var quantityLineSubtitle = table.AddMeasure("QuantityLineSubtitle", 
@"VAR _change = [QuantityVsPreviousMonth]
VAR _changeAc = [Quantity] - [QuantityPreviousMonth]
RETURN
FORMAT(_changeAc, ""+#,##0,.0;-#,##0,.0"") & REPT(""‏‏‎ ‎"", 58) & FORMAT(_change, ""+0.0%;-0.0%"")");




// Cost




// CostPreviousMonth
var CostPreviousMonth = table.AddMeasure("CostPreviousMonth", 
@"CALCULATE(
    [Cost],
    DATEADD(DimDate[Datekey], -1, MONTH)
)");
CostPreviousMonth.FormatString = "#,##0,,.0";

// CostPreviousMonthLineChart
var CostPreviousMonthLineChart = table.AddMeasure("CostPreviousMonthLineChart", 
@"CALCULATE(
    [Cost],
    DATEADD(DimDate[Datekey], -1, MONTH),
    ALL('DimDate - (LineChart-Highlighting)'[EoFMonth])
)");

// CostRemovedMonthFilter
var CostRemovedMonthFilter = table.AddMeasure("CostRemovedMonthFilter", 
@"CALCULATE(
    [Cost],
    REMOVEFILTERS(DimDate[CalendarMonthLabelShort], DimDate[CalendarMonthLabelOrder])
)");
CostRemovedMonthFilter.FormatString = "#,##0,,.0";

// CostSelctedMonthLineChart-
var CostSelctedMonthLineChartNeg = table.AddMeasure("CostSelctedMonthLineChart-", 
@"IF(
    [Cost] - [CostPreviousMonthLineChart] < 0,
    [Cost],
    BLANK()
)");

// CostSelctedMonthLineChart+
var CostSelctedMonthLineChartPos = table.AddMeasure("CostSelctedMonthLineChart+", 
@"IF(
    [Cost] - [CostPreviousMonthLineChart] > 0,
    [Cost],
    BLANK()
)");

// CostVsPreviousMonth
var CostVsPreviousMonth = table.AddMeasure("CostVsPreviousMonth", 
@"DIVIDE(
    [Cost] - [CostPreviousMonth],
    [CostPreviousMonth]
)");
CostVsPreviousMonth.FormatString = "▲0.0%;▼0.0%";

// CostVsPreviousMonthCF
var CostVsPreviousMonthCF = table.AddMeasure("CostVsPreviousMonthCF", 
@"IF(
    [Cost] - [CostPreviousMonth] < 0,
    ""#FA0103"",
    ""#69BA16""
)");


// CostLineSubtitle
var CostLineSubtitle = table.AddMeasure("CostLineSubtitle", 
@"VAR _change = [CostVsPreviousMonth]
VAR _changeAc = [Cost] - [CostPreviousMonth]
RETURN
FORMAT(_changeAc, ""+#,##0,,.0;-#,##0,,.0"") & REPT(""‏‏‎ ‎"", 58) & FORMAT(_change, ""+0.0%;-0.0%"")");