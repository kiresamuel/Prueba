using System.Collections.Generic;

namespace PruebaUWP.Models
{
    public class EncoderTecnologyModel
    {
        public string Id { get; set; }
        public string Desc { get; set; }
    }

    public class RecorderTecnologyModel
    {
        public string Id { get; set; }
        public string Desc { get; set; }
    }

    public class GrupoModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Title_Episode { get; set; }
        public string Title_Uri { get; set; }
        public string Title_Original { get; set; }
        public string Description { get; set; }
        public string Description_Large { get; set; }
        public string Short_Description { get; set; }
        public string Image_Large { get; set; }
        public string Image_Medium { get; set; }
        public string Image_Small { get; set; }
        public string Image_Still { get; set; }
        public string Image_Background { get; set; }
        public string Url_Imagen_T1 { get; set; }
        public string Url_Imagen_T2 { get; set; }
        public string Image_Base_Horizontal { get; set; }
        public string Image_Base_Vertical { get; set; }
        public string Image_Base_Square { get; set; }
        public string Image_Clean_Horizontal { get; set; }
        public string Image_Clean_Vertical { get; set; }
        public string Image_Clean_Square { get; set; }
        public string Image_Sprites { get; set; }
        public string Image_Frames { get; set; }
        public string Image_TrickPlay { get; set; }
        public string Image_External { get; set; }
        public string Duration { get; set; }
        public string Date { get; set; }
        public string Year { get; set; }
        public string Preview { get; set; }
        public string Season_Number { get; set; }
        public string Episode_Number { get; set; }
        public string Format_Types { get; set; }
        public string Live_Enabled { get; set; }
        public string Live_Type { get; set; }
        public string Live_Ref { get; set; }
        public string Source_Uri { get; set; }
        public string Timeshift { get; set; }
        public int Votes_Average { get; set; }
        public string Rating_Code { get; set; }
        public string Proveedor_Name { get; set; }
        public string Proveedor_Code { get; set; }
        public EncoderTecnologyModel Encoder_Tecnology { get; set; }
        public RecorderTecnologyModel Recorder_Tecnology { get; set; }
        public string Resource_Name { get; set; }
        public string RollingCreditsTime { get; set; }
        public string RollingCreditsTimeDB { get; set; }
        public bool Is_Series { get; set; }
        public string Channel_Number { get; set; }
    }

    public class ResponseModel
    {
        public List<GrupoModel> Groups { get; set; }
        public int Total { get; set; }
    }

    public class MetadataModel
    {
        public string Id { get; set; }
        public bool Private { get; set; }
        public string CreatedAt { get; set; }
        public string CollectionId { get; set; }
        public string Name { get; set; }
    }

    public class RecordModel
    {
        public ResponseModel Response { get; set; }
    }

    public class JsonModel
    {
        public RecordModel Record { get; set; }
        public MetadataModel Metadata { get; set; }
    }
}