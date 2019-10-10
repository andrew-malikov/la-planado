module LaPlanado.Domain.Models.MetricEffect

open System

open Metric

type ExistenceMetricEffect =
    { Name: string
      MetricName: string
      Metric: ExistenceMetric
      Duration: DateTimeOffset }

type ValuableMetricEffect =
    { Name: string
      MetricName: string
      Amount: double
      Duration: DateTimeOffset }

type MetricEffect =
    | ExistenceMetricEffect
    | ValuableMetricEffect
