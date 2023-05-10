﻿using AdIntegration.Business.Services;
using AdIntegration.Data.Entities;
using AdIntegration.Data.Entities.WhatsApp;
using AdIntegration.Repository.Interfaces;
using Bogus;
using Moq;

namespace AdIntegration.UnitTest
{
    public class AdvertisementServiceTests
    {
        private readonly Mock<IAdvertisementRepository> _mockRepository;
        private readonly AdvertisementService _advertisementService;

        public AdvertisementServiceTests()
        {
            _mockRepository = new Mock<IAdvertisementRepository>();
            _advertisementService = new AdvertisementService( _mockRepository.Object );
        }

        /* Create Advertisement
         * 1. Success
         * 2. Fail
         * 3. Checking the method call
         */

        [Fact]
        public void CreateAdvertisement_WithValidAdvertisement_ReturnsCreatedAdvertisement()
        {
            // Arrange
            var advertisement = new Advertisement
            {
                Id = 1,
                Name = "Test",
                Topic = "Test",
                Description = "Test",
                Price = 1,
                DatePosted = DateTime.Now,
                UserEntity = new SystemUser(),
                ChannelType = new WhatsAppChannel()
            };

            var createdAdvertisement = new Advertisement
            {
                Id = 1,
                Name = "Test",
                Topic = "Test",
                Description = "Test",
                Price = 1,
                DatePosted = DateTime.Now,
                UserEntity = new SystemUser(),
                ChannelType = new WhatsAppChannel()
            };

            _mockRepository.Setup(repo => repo.CreateAdvertisement(advertisement)).Returns(createdAdvertisement);

            // Act
            var result = _advertisementService.CreateAdvertisement(advertisement);

            // Assert
            Assert.Equal(createdAdvertisement, result);
        }

        [Fact]
        public void CreateAdvertisement_WithNullResult_ThrowsInvalidOperationException()
        {
            // Arrange
            var advertisement = new Faker<Advertisement>()
                .RuleFor(a => a.Name, f => f.Commerce.ProductName())
                .RuleFor(a => a.Topic, f => f.Lorem.Word())
                .RuleFor(a => a.Description, f => f.Lorem.Paragraph())
                .RuleFor(a => a.Price, f => f.Random.Decimal(1, 1000))
                .RuleFor(a => a.DatePosted, f => f.Date.Past())
                .RuleFor(a => a.UserEntity, f => new SystemUser())
                .RuleFor(a => a.ChannelType, f => new WhatsAppChannel())
                .Generate();

            
            var mockAdvertisementRepository = new Mock<IAdvertisementRepository>();
            mockAdvertisementRepository.Setup(r => r.CreateAdvertisement(advertisement)).Returns(() => null);

            var sut = new AdvertisementService(mockAdvertisementRepository.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => sut.CreateAdvertisement(advertisement));
        }

        /* Delete Advertisement
         * 1. Success
         * 2. Fail
         * 3. Checking the method call
         */


        /* Update Advertisement
         * 1. Success
         * 2. Fail
         * 3. Checking the method call
         */
    }
}
