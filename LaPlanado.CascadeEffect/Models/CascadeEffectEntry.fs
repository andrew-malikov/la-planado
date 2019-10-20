module LaPlanado.CascadeEffect.Models.CascadeEffectEntry

open LaPlanado.Metric.Models.Metric
open LaPlanado.Habit.Models.HabitType
open LaPlanado.Habit.Models.Habit

type CascadeEffectEntryType =
    | MetricKey of MetricKey
    | HabitTypeKey of HabitTypeKey
    | HabitKey of HabitKey

type CascadeEffectEntry =
    { Type: CascadeEffectEntryType
      Threshold: int }
