namespace Bookify.Application.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public sealed record ValidationError(string PropertyName, string ErrorMessage);
