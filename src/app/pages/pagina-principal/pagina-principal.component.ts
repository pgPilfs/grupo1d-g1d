import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pagina-principal',
  templateUrl: './pagina-principal.component.html',
  styleUrls: ['./pagina-principal.component.css']
})
export class PaginaPrincipalComponent implements OnInit {
  saldo:number = 400;
   //con esta linea le damos formato a la fecha en tiempo real (hay que ver si se puede agregar al arreglo )
  fecha:Date = new Date();
  
  datos = [ {tipo : "Extraccion", monto:15000} ,
            {tipo: "Ingreso", monto : 3000},
            {tipo: "Ingreso", monto : 12000},
            {tipo: "Ingreso", monto : 2000}];

  datos2 = [ {tipo : "Ingreso", monto:15000} ,
             {tipo: "Extraccion", monto : 3000},
             {tipo: "Extraccion", monto : 12000},
             {tipo: "Extraccion", monto : 2000}];

  datos3 = [ {tipo : "Ingreso", monto:15000} ,
              {tipo: "Extraccion", monto : 3000},
              {tipo: "Extraccion", monto : 12000},
              {tipo: "Ingreso", monto : 2000}];

  constructor() { }

  ngOnInit(): void {
  }

}
