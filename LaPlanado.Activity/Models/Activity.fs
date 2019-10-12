module LaPlanado.Activity.Models.Activity

open System

open LaPlanado.Metric.Models.MetricEffect

type Activity =
    { Name: string
      Duration: DateTimeOffset
      Effects: MetricEffect Set }
