﻿using System.Threading.Tasks;

namespace Param_RootNamespace.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
