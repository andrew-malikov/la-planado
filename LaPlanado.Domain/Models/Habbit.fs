module LaPlanado.Domain.Models.Habbit

open HabbitType
open MetricEffect
open Requirement

type HabbitKey = string

type Habbit =
    { Name: HabbitKey
      Type: HabbitType
      Priority: int
      Requirements: Requirement Set
      Effects: MetricEffect Set }
