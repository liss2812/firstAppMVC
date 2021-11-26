using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace firstApp.Models
{ public class Documento
    
        {
[Key]
public int documentoId{get; set;}
[Required(ErrorMessage ="titulo es requerido")]
[Display(Name ="titulo")]
public string  titulo {get; set;}
[Required(ErrorMessage ="contenido es requerido")]
[Display(Name ="contenido")]
public string  contenido {get; set;}
[Required(ErrorMessage ="fechapublicacion es requerido")]
[DataType(DataType.Date)]
[Display(Name ="fechapublicacion")]
public string  fechapublicacion {get; set;}
[Required(ErrorMessage ="descripcion es requerido")]
[Display(Name ="descripcion")]
public string  descripcion {get; set;}

//referencias para autor

[Required(ErrorMessage ="Autor es requerido")]
[Display(Name ="Autor")]
public int AutorID{get; set;}

public Autor Autors {set; get;}



        }
}