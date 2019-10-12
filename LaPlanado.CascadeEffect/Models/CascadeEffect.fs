module LaPlanado.CascadeEffect.Models.CascadeEffect

open LaPlanado.Metric.Models.MetricEffect

open CascadeEffectEntry

type CascadeEffect =
    { Name: string
      Requirements: CascadeEffectEntry Set
      MetricEffect: MetricEffect }
