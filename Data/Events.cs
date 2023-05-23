using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace taylor_ticket_tracker_blazor.Data;

[Table("events", Schema = "events")]
public class Event
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("price")]
    public int Price { get; set; }
    // public string Url { get; set; }

    // [Column("insertdatetime")]
    // public DateTime InsertDateTime { get; set; }

    // [Column("rowid")]
    // public int RowId { get; set; }

    // public string Img { get; set; }
    // public string Section { get; set; }
}

