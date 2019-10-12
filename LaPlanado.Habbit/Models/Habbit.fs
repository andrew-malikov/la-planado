module LaPlanado.Habbit.Models.Habbit

open LaPlanado.Metric.Models.MetricEffect

open HabbitType
open Requirement

type HabbitKey = string

type Habbit =
    { Name: HabbitKey
      Type: HabbitType
      Priority: int
      Requirements: Requirement Set
      Effects: MetricEffect Set }
