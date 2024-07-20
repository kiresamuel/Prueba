using System.Collections.Generic;

namespace PruebaUWP.Models
{
    public class KeywordModel
    {
        public string[] Keyword { get; set; }
    }

    public class GeneroModel
    {
        public List<GeneroDescModel> Genre { get; set; }
    }

    public class GeneroDescModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }

    public class RolModel
    {
        public List<RolDescModel> Role { get; set; }
    }

    public class RolDescModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public TalentoModel Talents { get; set; }
    }

    public class TalentoModel
    {
        public List<TalentoDescModel> Talent { get; set; }
    }

    public class TalentoDescModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get; set; }
    }

    public class FormatoModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Types { get; set; }
        public string Sell_types { get; set; }
        public string Est { get; set; }
    }

    public class RatingModel
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Desc { get; set; }
    }

    public class CountryOfOriginModel
    {
        public string Code { get; set; }
        public string Desc { get; set; }
    }

    public class HDModel
    {
        public string Enabled { get; set; }
        public string Detail { get; set; }
    }

    public class ProfileModel
    {
        public string Audiotype { get; set; }
        public string Videotype { get; set; }
        public string Screenformat { get; set; }
        public HDModel Hd { get; set; }
    }

    public class ProveedorModel
    {
        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
    }

    public class RightModel
    {
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
    }

    public class OriginalModel
    {
        public string Id { get; set; }
        public string Desc { get; set; }
    }

    public class OpcionModel
    {
        public List<OpcionDescModel> Option { get; set; }
        public int Count { get; set; }
    }

    public class OpcionDescModel
    {
        public string Group_Id { get; set; }
        public string Content_Id { get; set; }
        public string Current_Content { get; set; }
        public string Option_Id { get; set; }
        public string Audio { get; set; }
        public string Subtitle { get; set; }
        public string Option_Name { get; set; }
        public string Id { get; set; }
        public string Desc { get; set; }
        public string Label_Short { get; set; }
        public string Label_Large { get; set; }
        public string Intro_Start_Time { get; set; }
        public string Intro_Finish_Time { get; set; }
        public string Credits_Start_Time { get; set; }
        public string Audio_track { get; set; }
        public string Subtitle_track { get; set; }
        public string Resume_Start_Time { get; set; }
        public string Resume_Finish_Time { get; set; }
        public string[] Encodes { get; set; }
        public string[] Fast_play { get; set; }
        public int Count { get; set; }
    }

    public class LanguageModel
    {
        public OriginalModel Original { get; set; }
        public string Dubbed { get; set; }
        public string Subbed { get; set; }
        public OpcionModel Options { get; set; }
    }

    public class MediaModel
    {
        public string Originaltitle { get; set; }
        public string Description_extended { get; set; }
        public string Publishyear { get; set; }
        public string Boxoffice { get; set; }
        public RatingModel Rating { get; set; }
        public string Duration { get; set; }
        public string Haspreview { get; set; }
        public CountryOfOriginModel Countryoforigin { get; set; }
        public ProfileModel Profile { get; set; }
        public string Islive { get; set; }
        public string Livetype { get; set; }
        public string Liveref { get; set; }
        public string Timeshift { get; set; }
        public EncoderTecnologyModel Encoder_Tecnology { get; set; }
        public RecorderTecnologyModel Recorder_Technology { get; set; }
        public string Resource_Name { get; set; }
        public string RollingCreditsTime { get; set; }
        public string RollingCreditsTimeDb { get; set; }
        public ProveedorModel Proveedor { get; set; }
        public RightModel Rights { get; set; }
        public string Channel_number { get; set; }
        public LanguageModel Language { get; set; }
    }

    public class PeliculaModel
    {
        public RecordPeliculaModel Record { get; set; }
        public MetadataModel Metadata { get; set; }
    }

    public class RecordPeliculaModel
    {
        public ResponsePeliculaModel Response { get; set; }
    }

    public class ResponsePeliculaModel
    {
        public GrupoPeliculaModel Group { get; set; }
    }

    public class GrupoPeliculaModel
    {
        public ComunModel Common { get; set; }
        public UniversalIdModel Universal_Id { get; set; }
        public ExternalModel External { get; set; }
    }

    public class UniversalIdModel
    {
        public List<ContentProviderModel> Content_Providers { get; set; }
        public MetadataProviderModel Metadata_Providers { get; set; }
    }

    public class ContentProviderModel
    {
        public string Group_id { get; set; }
        public string Provider_Id { get; set; }
        public string Provider_Code { get; set; }
    }

    public class MetadataProviderModel
    {
        public Gracenote2Model Gracenote { get; set; }
    }

    public class Gracenote2Model
    {
        public string Reference_Id { get; set; }
        public string Provider_Id { get; set; }
        public string Provider_Code { get; set; }
    }

    public class ExternalModel
    {
        public GracenoteModel Gracenote { get; set; }
    }

    public class GracenoteModel
    {
        public string Id { get; set; }
        public string Provider_Id { get; set; }
        public string Provider_Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Publishyear { get; set; }
        public string Official_url { get; set; }
        public string Rating { get; set; }
        public string Rating_Classind { get; set; }
        public List<CastModel> Cast { get; set; }
        public string[] Genres { get; set; }
    }

    public class CastModel
    {
        public string Role_Id { get; set; }
        public string Role_Name { get; set; }
        public List<Talento2Model> Talents { get; set; }
    }

    public class Talento2Model
    {
        public string Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Image { get; set; }
        public int[] Internal_Ids { get; set; }
    }

    public class ComunModel
    {
        public int Position { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Large_Description { get; set; }
        public string Short_description { get; set; }
        public string Duration { get; set; }
        public string Image_Large_Alt { get; set; }
        public string Image_Medium_Alt { get; set; }
        public string Image_Small_Alt { get; set; }
        public string Image_Large { get; set; }
        public string Image_Medium { get; set; }
        public string Image_Small { get; set; }
        public string Image_Still { get; set; }
        public string Image_Background { get; set; }
        public string Image_Base_Horizontal { get; set; }
        public string Image_Base_Vertical { get; set; }
        public string Image_Base_Square { get; set; }
        public string Image_Clean_Horizontal { get; set; }
        public string Image_Clean_Vertical { get; set; }
        public string Image_Clean_Square { get; set; }
        public string Image_Sprites { get; set; }
        public string Image_Frames { get; set; }
        public string Image_External { get; set; }
        public string Image_Trickplay { get; set; }
        public string Date { get; set; }
        public string Mediatype { get; set; }
        public string Title_Uri { get; set; }
        public ExtendedCommonModel ExtendedCommon { get; set; }
        public RankingModel Ranking { get; set; }
    }

    public class ExtendedCommonModel
    {
        public KeywordModel Keywords { get; set; }
        public GeneroModel Genres { get; set; }
        public RolModel Roles { get; set; }
        public FormatoModel Format { get; set; }
        public MediaModel Media { get; set; }
    }

    public class RankingModel
    {
        public int Views_Count { get; set; }
        public int Votes_Count { get; set; }
        public int Average_Votes { get; set; }
    }
}