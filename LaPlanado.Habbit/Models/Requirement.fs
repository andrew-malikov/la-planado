module LaPlanado.Habbit.Models.Requirement

open LaPlanado.Metric.Models.Metric

type ExistenceRequirement =
    { Metric: MetricKey }

type ValuableRequirement =
    { Metric: MetricKey
      Amount: double }

type Requirement =
    | ExistenceRequirement of ExistenceRequirement
    | ValuableRequirement of ValuableRequirement
