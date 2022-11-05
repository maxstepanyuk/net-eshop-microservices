using System.Collections.Generic;
using PlatformService.Models;

namespace PlatformService{
    public interface IPlatformRepo{
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform platform);
    }
}