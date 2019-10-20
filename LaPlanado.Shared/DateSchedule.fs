module LaPlanado.Shared.DateSchedule

open LaPlanado.Shared.Date

type RepeatWeeklySchedule =
    { Every: int
      Days: DayName Set }

type UniqueWeekSchedule =
    { Days: DayName Set }

type UniqueWeeklySchedule =
    { Number: int
      Weeks: UniqueWeekSchedule Set }

type DateSchedule =
    | Daily
    | Weekly of RepeatWeeklySchedule
    | UniqueWeekly of UniqueWeeklySchedule
