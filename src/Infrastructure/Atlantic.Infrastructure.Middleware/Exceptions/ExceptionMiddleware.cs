﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Atlantic.Infrastructure.Middleware.Exceptions {
    public class ExceptionMiddleware {
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware>,IHostEnvironment  environment) {

        }
    }
}