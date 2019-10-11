module LaPlanado.Domain.Models.Metric

type MetricKey = string

type ExistenceMetric =
    { Name: MetricKey }

type ValuableMetric =
    { Name: MetricKey
      Amount: double }

type Metric =
    | ExistenceMetric
    | ValuableMetric
