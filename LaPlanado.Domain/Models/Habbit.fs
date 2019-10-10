module LaPlanado.Domain.Models.Habbit

open MetricEffect
open Requirement

type Habbit =
    { Name: string
      Requirements: Requirement Set
      Effects: MetricEffect Set }
