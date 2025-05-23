﻿using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using StudyBattle.API.Repostories.Interfaces.GenericRepository;

namespace StudyBattle.API.Repostories.Generic
{
    public class GenericRepository<TKey,TEntity> : IGenericRepository<TKey,TEntity> where TEntity : class
    {
        protected readonly TaskSystemDBContext _context;
        protected readonly DbSet<TEntity> _entities;

        public GenericRepository(TaskSystemDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _entities = _context.Set<TEntity>(); 
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            //Retornar vazio e não trolar
            //Se eu não espero o erro eu TROLO
            //Se eu imagino o erro eu TRATAR

            try
            {
                var newEntity = await _entities.AddAsync(entity);
                await _context.SaveChangesAsync();
                return newEntity.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the entity.", ex);
            }
        }

        public async Task<bool> DeleteAsync(TKey id)
        {
            try
            {
                var entity = await GetByIdAsync(id);
                if (entity == null)
                {
                    return false;
                }

                _entities.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the entity.", ex);
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            try
            {
                return await _entities.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving all entities.", ex);
            }
        }

        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            try
            {
                return await _entities.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the entity by ID.", ex);
            }
        }

        public async Task<TEntity> UpdateAsync(TKey id, TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            try
            {
                var existingEntity = await GetByIdAsync(id);
                if (existingEntity == null) throw new ArgumentException("Entity not found");
                

                _context.Entry(existingEntity).CurrentValues.SetValues(entity);

                await _context.SaveChangesAsync();
                return existingEntity;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the entity.", ex);
            }
        }
    }
}