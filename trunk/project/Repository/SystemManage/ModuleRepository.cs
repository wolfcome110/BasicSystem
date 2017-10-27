﻿using Repository.Data;
using Domain.Entity.SystemManage;
using Domain.IRepository.SystemManage;
using Repository.SystemManage;

namespace Repository.SystemManage
{
    public class ModuleRepository : RepositoryBase<ModuleEntity>, IModuleRepository
    {
    }
}
