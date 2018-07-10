using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.BusinessLayer.Core.Contracts
{
    public interface ITrackable
    {
        [Column("USER_ENT_BY")]
        [StringLength(60)]
        string UserEntBy { get; set; }

        [Column("DT_ENT")]
        DateTime DtEnt { get; set; }

        [StringLength(60)]
        [Column("USER_CHG_BY")]
        string UserChgBy { get; set; }

        [Column("DT_CHG")]
        DateTime? DtChg { get; set; }

    }

    public class BaseTrack : ITrackable
    {


        #region Log

        [Column("USER_ENT_BY")]
        [StringLength(60)]
        public string UserEntBy { get; set; }

        [Column("USER_SEQ_ENT_BY")]
        public int? UserIdEnt { get; set; }

        [Column("DT_ENT")]
        public DateTime DtEnt { get; set; }

        [StringLength(60)]
        [Column("USER_CHG_BY")]
        public string UserChgBy { get; set; }

        [Column("USER_SEQ_CHG_BY")]
        public int? UserIdChg { get; set; }

        [Column("DT_CHG")]
        public DateTime? DtChg { get; set; }


        #endregion
    }

    public class BaseTrackWithDueDate : BaseTrack
    {
        //pass away
        [Column("DUE_DATE")]
        public DateTime? DueDate { get; set; }
    }

}
