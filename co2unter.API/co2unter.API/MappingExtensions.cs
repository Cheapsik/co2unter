﻿using co2unter.API.Infrastructure.Entities;
using co2unter.API.Models;
using System.Xml.Linq;

namespace co2unter.API;

public static class MappingExtensions
{
    public static ServiceEmissionModel Map(this DbServiceEmission serviceEmission)
    {
        return new ServiceEmissionModel
        {
            ServiceType = serviceEmission.ServiceType,
            TotalCO2EmissionsKg = serviceEmission.TotalCO2EmissionsKg,
            Year = serviceEmission.Year,
        };
    }

    public static TransportEmissionModel Map(this DbTransportEmission transportEmission)
    {
        return new TransportEmissionModel
        {
            TransportType = transportEmission.TransportType,
            TotalCO2EmissionsKg = transportEmission.TotalCO2EmissionsKg,
            TotalDistanceKm = transportEmission.TotalDistanceKm,
            Year = transportEmission.Year,
        };
    }

    public static MassEventModel Map(this DbMassEvent massEvent)
    {
        return new MassEventModel
        {
            Id = massEvent.Id,
            EmmissionT = massEvent.EmmissionT,
            EventDate = massEvent.EventDate,
            Name = massEvent.Name,
            Place = massEvent.Place,
        };
    }

    public static GreenArea Map(this DbGreenArea dbGreenArea)
    {
        return new GreenArea
        {
            Id = dbGreenArea.Id,
            Name = dbGreenArea.Name,
            Area = dbGreenArea.Area,
            Co2Absorption = dbGreenArea.Co2Absorption
        };
    }
}
