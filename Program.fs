open System.ComponentModel.DataAnnotations

type FsRangeAttribute =
    inherit RangeAttribute
    new(minimum: int, maximum: int) = { inherit RangeAttribute(minimum = minimum, maximum = maximum) }
    new(minimum: double, maximum: double) = { inherit RangeAttribute(minimum = minimum, maximum = maximum) }

printfn "Hello World"
