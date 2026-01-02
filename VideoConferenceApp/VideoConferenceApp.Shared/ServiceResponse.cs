using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoConferenceApp.Shared
{
    public abstract record class ServiceResponse<T>(bool IsSuccess = false, string? Message = null, T? Data = default);
        
  }
