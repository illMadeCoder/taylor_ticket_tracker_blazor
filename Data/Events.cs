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
    [Column("url")]
    public string Url { get; set; }   
    [Column("insertdatetime")]
    public DateTime InsertDateTime { get; set; }
    [Column("rowid")]
    public int RowId { get; set; }
    [Column("img")]
    public string Img { get; set; }
    [Column("section")]
    public string Section { get; set; }
}

