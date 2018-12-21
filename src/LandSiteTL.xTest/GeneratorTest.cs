/// ***********************************************************************
///
/// =================================
/// CLR版本    ：4.0.30319.42000
/// 命名空间    ：LandSiteTL.xTest
/// 文件名称    ：GeneratorTest.cs
/// =================================
/// 创 建 者    ：ddsgis
/// 创建日期    ：2018/12/21 14:27:11 
/// 邮箱        ：691473083@qq.com
/// 个人主站    ：https://ddsgis.blogspot.com/
/// 功能描述    ：
/// 使用说明    ：
/// =================================
/// 修改者    ：
/// 修改日期    ：
/// 修改内容    ：
/// =================================
///
/// ***********************************************************************


using LandSiteTL.Core.CodeGenerator;
using LandSiteTL.Core.Models;
using LandSiteTL.Core.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Xunit;
using System.Linq;

namespace LandSiteTL.xTest
{
    /// <summary>
    /// 
    /// <see cref="GeneratorTest" langword="" />
    /// </summary>
    public class GeneratorTest
    {
        [Fact]
        public void GeneratorModelForSqlServer()
        {
            var serviceProvider = BuildServiceForSqlServer();
            var codeGenerator = serviceProvider.GetRequiredService<CodeGenerator>();
            codeGenerator.GenerateTemplateCodesFromDatabase(true);
            Assert.Equal("SQLServer", DatabaseType.SqlServer.ToString(), ignoreCase: true);

        }

        [Fact]
        public void TestBaseFactory()
        {
            //IServiceProvider serviceProvider = BuildServiceForSqlServer();
            //IArticleCategoryRepository categoryRepository = serviceProvider.GetService<IArticleCategoryRepository>();
            //var category = new ArticleCategory
            //{
            //    Title = "随笔",
            //    ParentId = 0,
            //    ClassList = "",
            //    ClassLayer = 0,
            //    Sort = 0,
            //    ImageUrl = "",
            //    SeoTitle = "随笔的SEOTitle",
            //    SeoKeywords = "随笔的SeoKeywords",
            //    SeoDescription = "随笔的SeoDescription",
            //    IsDeleted = false,
            //};
            //var categoryId = categoryRepository.Insert(category);
            //var list = categoryRepository.GetList();
            //Assert.True(1 == list.Count());
            //Assert.Equal("随笔", list.FirstOrDefault().Title);
            //Assert.Equal("SQLServer", DatabaseType.SqlServer.ToString(), ignoreCase: true);
            //categoryRepository.Delete(categoryId.Value);
            //var count = categoryRepository.RecordCount();
            //Assert.True(0 == count);
        }

        /// <summary>
        /// 构造依赖注入容器，然后传入参数
        /// </summary>
        /// <returns></returns>
        public IServiceProvider BuildServiceForSqlServer()
        {
            var services = new ServiceCollection();
            services.Configure<CodeGenerateOption>(options =>
            {
                options.ConnectionString = "Data Source=.;Initial Catalog=CzarCms;User ID=sa;Password=1;Persist Security Info=True;Max Pool Size=50;Min Pool Size=0;Connection Lifetime=300;";
                options.DbType = DatabaseType.SqlServer.ToString();//数据库类型是SqlServer,其他数据类型参照枚举DatabaseType
                options.Author = "ddsgis";//作者名称
                options.OutputPath = "C:\\CzarCmsCodeGenerator";//模板代码生成的路径
                options.ModelsNamespace = "LandSiteTL.Models";//实体命名空间
                options.IRepositoryNamespace = "LandSiteTL.IRepository";//仓储接口命名空间
                options.RepositoryNamespace = "LandSiteTL.Repository.SqlServer";//仓储命名空间

            });
            services.AddSingleton<CodeGenerator>();//注入Model代码生成器
            //services.Configure<DbOpion>("CzarCms", GetConfiguration().GetSection("DbOpion"));
            //services.AddScoped<IArticleRepository, ArticleRepository>();
            //services.AddScoped<IArticleCategoryRepository, ArticleCategoryRepository>();
            return services.BuildServiceProvider(); //构建服务提供程序
        }

        public IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(AppContext.BaseDirectory)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddEnvironmentVariables();
            return builder.Build();
        }
    }
}
