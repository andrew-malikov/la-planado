module LaPlanado.Habbit.Models.HabbitType

type HabbitTypeKey = string

type HabbitType =
    { Name: HabbitTypeKey
      Children: HabbitType Set
      Root: HabbitType option }