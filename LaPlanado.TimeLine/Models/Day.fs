module LaPlanado.TimeLine.Models.Day

open LaPlanado.Shared.Date
open LaPlanado.Metric.Models.Metric
open LaPlanado.Metric.Models.MetricEffect
open LaPlanado.Habit.Models.Habit
open LaPlanado.Activity.Models.Activity

type Day =
    { Name: DayName
      Number: int
      Activities: Activity Set
      Habits: Habit Set
      Metrics: Metric Set
      Effects: MetricEffect Set }
