﻿using ei8.Avatar.Installer.Domain.Model.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ei8.Avatar.Installer.Application.Avatar
{
    public interface IAvatarApplicationService
    {
        Task CreateAvatarAsync(string configPath);
    }
}
