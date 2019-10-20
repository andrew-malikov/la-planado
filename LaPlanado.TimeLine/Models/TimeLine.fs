module LaPlanado.TimeLine.Models.TimeLine

open Day

open LaPlanado.Restricition.Models.Restriction

type TimeLine =
    { Days: Day Set
      Restrictions: Restriction Set
      Rating: int }
