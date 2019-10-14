module LaPlanado.TimeLine.Models.Day

open LaPlanado.Metric.Models.Metric
open LaPlanado.Metric.Models.MetricEffect
open LaPlanado.Habbit.Models.Habbit
open LaPlanado.Activity.Models.Activity

type DayName =
    | Sunday
    | Monday
    | Tuesday
    | Wednesday
    | Thursday
    | Friday
    | Saturday

type Day =
    { Name: DayName
      Number: int
      Activities: Activity Set
      Habbits: Habbit Set
      Metrics: Metric Set
      Effects: MetricEffect Set }
