module LaPlanado.Habit.Models.HabitType

type HabitTypeKey = string

type HabitType =
    { Name: HabitTypeKey
      Children: HabitType Set
      Root: HabitType option }