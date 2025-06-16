using AutoMapper;
using PharmAssist.DTOs;
using PharmAssist.Core.Entities;

namespace PharmAssist.Helpers
{
    public class RecommendationPictureUrlResolver : IValueResolver<MedicationRecommendation, MedicationRecommendationDTO, string>
    {
        private readonly IConfiguration _configuration;

        public RecommendationPictureUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Resolve(MedicationRecommendation source, MedicationRecommendationDTO destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.Product?.PictureUrl))
                return $"{_configuration["ApiBaseUrl"]}{source.Product.PictureUrl}";
            return string.Empty;
        }
    }
} 