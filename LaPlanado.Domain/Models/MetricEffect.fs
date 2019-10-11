module LaPlanado.Domain.Models.MetricEffect

open System

open Metric

type ExistenceMetricEffect =
    { Name: string
      Metric: MetricKey
      Duration: DateTimeOffset }

type ValuableMetricEffect =
    { Name: string
      Metric: MetricKey
      Amount: double
      Duration: DateTimeOffset }

type MetricEffect =
    | ExistenceMetricEffect
    | ValuableMetricEffect
