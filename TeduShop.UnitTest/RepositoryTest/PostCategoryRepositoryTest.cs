using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository postCategoryRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initiallize()
        {
            dbFactory = new DbFactory();
            postCategoryRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = postCategoryRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count());
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test Category";
            category.Alias = "Test-Category";
            category.Status = true;
            var rs = postCategoryRepository.Add(category);
            unitOfWork.Commit();
            Assert.IsNotNull(rs);
            Assert.Equals(3, rs.ID);
        }
    }
}
