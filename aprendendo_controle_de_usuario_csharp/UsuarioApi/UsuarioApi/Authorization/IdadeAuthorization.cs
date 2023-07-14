﻿using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace UsuarioApi.Authorization;

public class IdadeAuthorization : AuthorizationHandler<IdadeMinima>
{
    protected override Task HandleRequirementAsync
        (AuthorizationHandlerContext context,
        IdadeMinima requirement)
    {
        var dataNascimentoClaim = context
            .User.FindFirst(claim =>
            claim.Type == ClaimTypes.DateOfBirth);

        if (dataNascimentoClaim is null)
            return Task.CompletedTask;

        var dataNascimento = Convert
            .ToDateTime (dataNascimentoClaim.Value);

        var idadeUsuario = DateTime.Today.Year - dataNascimento.Year;


        if (dataNascimento > 
            DateTime.Today.AddYears(-idadeUsuario)) 
            idadeUsuario--;
    
        if (idadeUsuario >= requirement.idade)
            context.Succeed(requirement);
        return Task.CompletedTask;
    }
}
