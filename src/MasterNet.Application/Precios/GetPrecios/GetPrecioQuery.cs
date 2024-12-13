namespace MasterNet.Application.Precios.GetPrecios;

public record PrecioResponse
(
    Guid Id,
    string Nombre,
    decimal PrecioPromocion,
    decimal PrecioActual
);