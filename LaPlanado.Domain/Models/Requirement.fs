module LaPlanado.Domain.Models.Requirement

open Metric

type ExistenceRequirement =
    { Metric: MetricKey }

type ValuableRequirement =
    { Metric: MetricKey
      Amount: double }

type Requirement =
    | ExistenceRequirement
    | ValuableRequirement
