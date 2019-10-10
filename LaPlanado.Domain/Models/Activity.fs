module LaPlanado.Domain.Models.Activity

open System

open MetricEffect

type Activity =
    { Name: string
      Duration: DateTimeOffset
      Effects: MetricEffect Set }
