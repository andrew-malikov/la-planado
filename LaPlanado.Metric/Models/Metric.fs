module LaPlanado.Metric.Models.Metric

type MetricKey = string

type ExistenceMetric =
    { Name: MetricKey }

type ValuableMetric =
    { Name: MetricKey
      Amount: double }

type Metric =
    | ExistenceMetric of ExistenceMetric
    | ValuableMetric of ValuableMetric
