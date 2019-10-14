module LaPlanado.TimeLine.Models.TimeLine

open Day

type TimeLine =
    { Days: Day Set
      Rating: int }
