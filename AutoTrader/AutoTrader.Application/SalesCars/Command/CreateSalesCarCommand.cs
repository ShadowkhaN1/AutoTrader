﻿using AutoTrader.Application.Dtos;
using MediatR;

namespace AutoTrader.Application.SalesCars.Command;

public class CreateSalesCarCommand : IRequest
{
    public CreateSalesCarCommand(SalesCarDto salesCarDto)
    {
        SalesCarDto = salesCarDto;
    }

    public SalesCarDto SalesCarDto { get; }
}