module LaPlanado.Domain.Models.Metric

type ExistenceMetric =
    { Name: string }

type ValuableMetric =
    { Name: string
      Amount: double }

type Metric =
    | ExistenceMetric
    | ValuableMetric
