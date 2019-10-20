module LaPlanado.Habit.Models.Habit

open LaPlanado.Metric.Models.MetricEffect

open HabitType
open Requirement

type HabitKey = string

type Habit =
    { Name: HabitKey
      Type: HabitType
      Priority: int
      Requirements: Requirement Set
      Effects: MetricEffect Set }
