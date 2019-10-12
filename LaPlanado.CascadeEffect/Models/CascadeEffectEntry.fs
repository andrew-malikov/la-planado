module LaPlanado.CascadeEffect.Models.CascadeEffectEntry

open LaPlanado.Metric.Models.Metric
open LaPlanado.Habbit.Models.HabbitType
open LaPlanado.Habbit.Models.Habbit

type CascadeEffectEntryType =
    | MetricKey of MetricKey
    | HabbitTypeKey of HabbitTypeKey
    | HabbitKey of HabbitKey

type CascadeEffectEntry =
    { Type: CascadeEffectEntryType
      Threshold: int }
