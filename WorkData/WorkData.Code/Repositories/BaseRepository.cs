﻿// ------------------------------------------------------------------------------
// Copyright  吴来伟个人 版权所有。
// 项目名：WorkData.Infrastructure
// 文件名：BaseRepository.cs
// 创建标识：吴来伟 2017-12-06 18:17
// 创建描述：
//
// 修改标识：吴来伟2018-02-12 10:55
// 修改描述：
//  ------------------------------------------------------------------------------

#region

using System.Collections.Generic;
using System.Linq;
using WorkData.Code.Entities;
using WorkData.Code.UnitOfWorks;
using WorkData.Dependency;

#endregion

namespace WorkData.Code.Repositories
{
    /// <summary>
    ///     BaseRepository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public abstract class BaseRepository<TEntity, TPrimaryKey> :
        IBaseRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        /// <summary>
        ///     UnitOfWorkManager
        /// </summary>
        public IUnitOfWorkManager UnitOfWorkManager { get; set; }

        /// <summary>
        ///     IocResolver
        /// </summary>
        public IResolver IocResolver { get; set; }

        /// <summary>
        ///     Insert
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="model"></param>
        public abstract TEntity Insert(TEntity model);

        /// <summary>
        ///     InsertGetId
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract TPrimaryKey InsertGetId(TEntity model);

        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public abstract void Insert(IEnumerable<TEntity> entities);

        /// <summary>
        ///     GetAll
        /// </summary>
        /// <returns>IQueryable to be used to select entities from database</returns>
        public abstract IQueryable<TEntity> GetAll();

        /// <summary>
        /// FindBy
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public abstract TEntity FindBy(TPrimaryKey primaryKey);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public abstract void Delete(TEntity entity);

        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public abstract void Delete(IEnumerable<TEntity> entities);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        public abstract void Update(TEntity entity);

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public abstract void Update(IEnumerable<TEntity> entities);
    }
}