using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {

        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        Owner GetOwnerByEmail(string email);
        Owner AddOwner(Owner owner);
        Owner UpdateOwner(Owner owner);
        OwnerRepository DeleteOwner(int ownerId);

    }
}
