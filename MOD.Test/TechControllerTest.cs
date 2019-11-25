using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MOD.TechnologyService.Repository;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MOD.Test
{
    public class TechControllerTest
    {
        private readonly Mock<SkillsRepository> _repo;
        private readonly SkillsController _controller;

        public TechControllerTest()
        {
            _repo = new Mock<SkillsRepository>();
            _controller = new SkillsController(_repo.Object);
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetSkills());
            var result = _controller.Get() as List<Skills>;
            Assert.Equal(3, result.Count);

        }
        [Fact]
        public void GetById()
        {
            _repo.Setup(m => m.GetById(11)).Returns(GetSkills()[0]);
            var result = _controller.Get(11) as Skills;
            Assert.NotNull(result);
            Assert.Equal(11, result.Sid);
        }
        [Fact]
        public void Post()
        {
            var item = GetSkills()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
            
        }
        [Fact]
        public void Put()
        {
            var item = GetSkills()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }
        private List<Skills> GetSkills()
        {
            return new List<Skills>()
            {
                new Skills() { Sid = 11, Sname = "Java" },
                new Skills() { Sid = 22, Sname = "IOT" },
                new Skills() { Sid = 33, Sname = "ML" }

            };

        }
    }
}
