using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagementSystemLib.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(String entityName,Object id): base($"Entity {entityName} with ID: {id} not found"){}
    }
}
