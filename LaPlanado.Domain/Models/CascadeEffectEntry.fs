module LaPlanado.Domain.Models.CascadeEffectEntry

type CascadeEffectEntryType =
    | MetricKey
    | HabbitKey
    | HabbitTypeKey

type CascadeEffectEntry =
    { Type: CascadeEffectEntryType
      Threshold: int }
