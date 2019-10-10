module LaPlanado.Domain.Models.Requirement

type ExistenceRequirement =
    { MetricName: string }

type ValuableRequirement =
    { MetricName: string
      Amount: double }

type Requirement =
    | ExistenceRequirement
    | ValuableRequirement
