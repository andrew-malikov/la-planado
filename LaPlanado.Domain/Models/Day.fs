module LaPlanado.Domain.Models.Day

open Activity
open Habbit
open Metric
open MetricEffect

type DayName =
    | Sunday
    | Monday
    | Tuesday
    | Wednesday
    | Thursday
    | Friday
    | Saturday

type Day =
    { Name: string
      Activities: Activity Set
      Habbits: Habbit Set
      Metrics: Metric Set
      Effects: MetricEffect Set }
