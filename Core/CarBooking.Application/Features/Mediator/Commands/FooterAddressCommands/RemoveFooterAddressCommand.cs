﻿using MediatR;

namespace CarBooking.Application.Features.Mediator.Commands.FooterAddressCommands;
public class RemoveFooterAddressCommand : IRequest
{
    public RemoveFooterAddressCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
