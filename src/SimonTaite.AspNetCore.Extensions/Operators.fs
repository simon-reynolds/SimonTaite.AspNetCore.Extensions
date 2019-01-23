namespace SimonTaite.AspNetCore.Extensions

module Operators =

    /// Custom operator for Path.Combine
    let (</>) a b = System.IO.Path.Combine(a, b)
