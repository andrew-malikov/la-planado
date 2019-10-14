module LaPlanado.Metric.Models.MetricRating

open Metric

type OptimizationDirection =
    | Max
    | Min

type MetricRating =
    { Name: MetricKey
      Cost: int
      Direction: OptimizationDirection }
