﻿using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace Volo.Abp.FeatureManagement
{
    [DependsOn(
        typeof(FeatureManagementDomainModule),
        typeof(FeatureManagementApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class FeatureManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<FeatureManagementApplicationAutoMapperProfile>(validate: true);
            });

            Configure<SettingOptions>(options =>
            {
                options.DefinitionProviders.Add<FeatureManagementSettingDefinitionProvider>();
            });
        }
    }
}
