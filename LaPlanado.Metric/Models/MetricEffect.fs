module LaPlanado.Metric.Models.MetricEffect

open System

open Metric

type MetricEffectActionType =
    | Add
    | Remove

type ExistenceMetricEffect =
    { Name: string
      Metric: MetricKey
      Action: MetricEffectActionType
      Duration: DateTimeOffset }

type ValuableMetricEffect =
    { Name: string
      Metric: MetricKey
      Action: MetricEffectActionType
      Amount: double
      Duration: DateTimeOffset }

type MetricEffect =
    | ExistenceMetricEffect of ExistenceMetricEffect
    | ValuableMetricEffect of ValuableMetricEffect
