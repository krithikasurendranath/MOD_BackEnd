using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MOD.TrainingService.Repository;
using MOD.TrainingService.Controllers;
using MOD.TrainingService.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MOD.Test
{
    public class TrainingControllerTest
    {
        private readonly Mock<TrainingRepository> _repo;
        private readonly TrainingController _controller;

        public TrainingControllerTest()
        {
            _repo = new Mock<TrainingRepository>();
            _controller = new TrainingController(_repo.Object);
        }

        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetTrainings());
            var result = _controller.Get() as List<Training>;
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void Post()
        {
            var item = GetTrainings()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);

        }

        [Fact]
        public void Put()
        {
            var item = GetTrainings()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);

        }
        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.Delete(It.IsAny<int>()));
            var result = _controller.Delete(10) as OkResult;
            Assert.NotNull(result);
        }

        [Fact]


        private List<Training> GetTrainings()
        {
            return new List<Training>()
      {
        new Training(){Tid=10,Progress="30"},
         new Training(){Tid=11,Progress="50"},
          new Training(){Tid=12,Progress="80"}

      };
        }
    }
}
