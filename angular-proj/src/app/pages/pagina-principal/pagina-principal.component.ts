import { Component, OnInit } from '@angular/core';
import { CuentaService } from 'src/Servicios/cuenta.service';

@Component({
  selector: 'app-pagina-principal',
  templateUrl: './pagina-principal.component.html',
  styleUrls: ['./pagina-principal.component.css']
})
export class PaginaPrincipalComponent implements OnInit {
  mostrar_movimientos=true;
  cbu:any;
  tipoDeCuenta: any;
  datoMovimiento: any;
  

  /*datos = [ {tipo : "Extraccion", monto:15000} ,
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
              {tipo: "Ingreso", monto : 2000}];*/

  constructor(private cuentaService : CuentaService) { }

  ngOnInit(): void {
    this.cuentaService.obtenerCuenta(9).subscribe(
      data=> {
        console.log(data); // fijate si este data te trae la info antes y despues descomenta lo que esta abajo
        //this.datoMovimiento=data['Movimientos'];
        //this.tipoDeCuenta=data['Tipo_Cuenta1'];
        //this.cbu=data['CBU1'];
        
      }
    );

  }

}
