C# String Mask
========

A simple-to-use C# extension for masking strings.

# Installation

Install from [this Nuget package](https://www.nuget.org/packages/Salazar.CSharp.String.Mask)

# Usage

Import the library with `using Salazar.CSharp.String.Mask` on top of your code.

For outputing a masked value of `(61) 98888-7777` from a string of value `61988887777`, simply do follow:

```csharp
var masked = "61988887777".ToMask("(##) #####-####");
```

Multiple masks can be informed in order to vary depending on content. The most suitable mask will automatically be used. The example below will mask 10 or 11 digit strings accordingly.

```csharp
var masked = "61988887777".ToMask("(##) #####-####", "(##) ####-####");
```

