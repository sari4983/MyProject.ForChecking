using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Claim = MyProject.Repositories.Entities.Claim;

namespace MyProject.Repositories.Repositories
{
    class ClaimRepository : IClaim
    {
        private readonly IMockContext _context;
        public Claim Add(int id, Role role,Permission permission,Policy policy)
        {
            Claim claim = new Claim { Id = id, RoleId=role, PermissionId=permission,policy=policy };
            _context.Claims.Add(claim);
            return claim;
        }

       

        public void Delete(int id)
        {
            for (int i = 0; i < _context.Claims.Count; i++)
            {
                if (_context.Claims[i].Id == id)
                    _context.Claims.Remove(_context.Claims[i]);
            }
        }

        public List<Claim> GetAll()
        {
            return _context.Claims;
        }

        public Claim GetById(int id)
        {
            Claim claim = new Claim();
            for (int i = 0; i < _context.Claims.Count; i++)
            {
                if (_context.Claims[i].Id == id)
                {
                    claim = _context.Claims[i];
                    break;
                }
            }
            return claim;
        }

        public Claim Update(Claim claim)
        {
            return claim;
        }

        public System.Security.Claims.Claim Update(System.Security.Claims.Claim role)
        {
            throw new NotImplementedException();
        }

        List<System.Security.Claims.Claim> IClaim.GetAll()
        {
            throw new NotImplementedException();
        }

        System.Security.Claims.Claim IClaim.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
