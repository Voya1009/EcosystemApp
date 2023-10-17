﻿using Domain.Entities;
using Domain.RepositoryInterfaces;
using Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessLogic.Repositories
{
    public class EcosystemsRepository : IRepositoryEcosystems
    {
        public EcosystemContext Context { get; set; }

        public EcosystemsRepository(EcosystemContext context)
        {
            Context = context;
        }

        public void Add(Ecosystem e)
        {
            try
            {
                if (e != null)
                {
                    e.Validate();
                    Context.Ecosystems.Add(e);
                    Context.SaveChanges();
                }
                else throw new EcosystemException("Error al crear un ecosistema, intente nuevamente.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Ecosystem> FindAll()
        {
            return Context.Ecosystems.Include(e => e.EcoConservation).ToList();
        }

        //public void 

        public Ecosystem FindById(int id)
        {
            Ecosystem? e = Context.Ecosystems.Find(id);
            if (e != null)
            {
                return e;
            }
            else throw new EcosystemException("No se encontró un ecosistema con ese id.");
        }

        public void Remove(Ecosystem e)
        {
            try
            {
                if (e != null)
                {
                    if (e.Species == null)
                    {
                        Context.Ecosystems.Remove(e);
                        Context.SaveChanges();
                    }
                    else throw new EcosystemException("El ecosistema no debe tener especies que lo habiten para poder eliminarlo.");
                }
                else throw new EcosystemException("El ecosistema que intenta eliminar no existe.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Ecosystem e)
        {
            if (e != null)
            {
                Context.Ecosystems.Update(e);
                Context.SaveChanges();
            }
            throw new EcosystemException("El ecosistema que intenta actualizar no existe.");
        }
    }
}
