module LaPlanado.Restricition.Models.Restriction

open LaPlanado.Shared.DateSchedule
open LaPlanado.Metric.Models.MetricEffect
open LaPlanado.Habit.Models.Habit
open LaPlanado.Habit.Models.HabitType

type RestrictionObject =
    | HabitTypeKey of HabitTypeKey
    | HabitKey of HabitKey

type RestrictionType =
    | Maximum
    | Minimum

type Restriction =
    { Name: string
      Object: RestrictionObject
      Type: RestrictionType
      Effect: MetricEffect
      Schedule: DateSchedule }
