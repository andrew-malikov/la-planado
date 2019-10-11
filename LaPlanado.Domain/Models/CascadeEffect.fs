module LaPlanado.Domain.Models.CascadeEffect

open CascadeEffectEntry
open MetricEffect

type CascadeEffect =
    { Name: string
      Requirements: CascadeEffectEntry Set
      Metric: MetricEffect }
