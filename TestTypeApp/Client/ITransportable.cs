namespace TestTypeApp.Client
{
   public interface ITransportable <DTOType>
         {
             DTOType ToDTO();
         }
}
