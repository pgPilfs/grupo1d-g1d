import { Component, OnInit } from '@angular/core';
import { CuentaService } from '../../../Servicios/cuenta.service';
// import {AuthService} from '../../../app/servicios/auth.service';

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
  id: number = 0; //Declaro la variable donde voy a guardar el id que traigo del local storage
  

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
              // private authService : AuthService //Falto esto 
  constructor(private cuentaService : CuentaService ) { }

  ngOnInit(): void {
    // this.id
    // Quiero usar esto que me traigo del local storage el dato que llame ID en auth service
    this.id  = Number(localStorage.getItem("ID"));
  // lo vuelvo un numero y aca lo se lo paso a obtener cuenta 
  //que enrealidad deberia pasarle el idCuenta y le estoy pasando el idCliente 
    this.cuentaService.obtenerCuenta(this.id).subscribe(
      data=> {
        //console.log(data); 
        this.datoMovimiento=data['Movimientos'];
        this.tipoDeCuenta=data['Tipo_Cuenta1'];
        this.cbu=data['CBU1'];
        
      }
    );

  }

}
