import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormControl, Validators} from '@angular/forms';
import { AuthService } from '../../../app/Servicios/auth.service';
import {AuthGuard } from '../../../app/Servicios/auth.guard';


@Component({
  selector: 'app-ingreso-pesos',
  templateUrl: './ingreso-pesos.component.html',
  styleUrls: ['./ingreso-pesos.component.css']
})
export class IngresoPesosComponent implements OnInit {
  registro:boolean = false;
  registro2:boolean = false;
  

  alias:string = "MANZANA.PELOTA.MANO"

  nombre = new FormControl('', [Validators.required, Validators.min(1), Validators.max(10)] );
  numero = new FormControl('', [Validators.required, Validators.min(1), Validators.max(16)] );
  venc = new FormControl('', [Validators.required] );
  cvv = new FormControl('', [Validators.required, Validators.min(1), Validators.max(3)] );

  constructor() {
   
  }


  ngOnInit(): void {

  }

  registroTarjeta(){
    this.registro = true;
     
  }

 
  get nombreField(){
    return this.nombre;
  }

  get numeroField(){
    return this.numero;
  }

  get cvvField(){
    return this.cvv;
  }

  get vencField(){
    return this.venc;
  }

}
