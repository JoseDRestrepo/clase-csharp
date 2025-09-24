namespace POOWorkshop.Domain.Interfaces;

public interface IPayable //interfaz para las clases que implementen el metodo para calcular pago
{
    decimal CalculatePayment();
}
