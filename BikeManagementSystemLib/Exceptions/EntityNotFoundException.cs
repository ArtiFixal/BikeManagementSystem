namespace BikeManagementSystemLib.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(String entityName,Object id): base($"Entity {entityName} with ID: {id} not found"){}
    }
}
