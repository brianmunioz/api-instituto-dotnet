namespace MasterNet.Application.Precios.GetPrecios;

public record PrecioResponse
(
    Guid? Id,
    string? Nombre,
    decimal? PrecioPromocion,
    decimal? PrecioActual
)
{
    public PrecioResponse():this(null,null,null,null){}
};