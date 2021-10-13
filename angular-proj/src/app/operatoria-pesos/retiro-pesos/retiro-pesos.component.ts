import { Component, OnInit } from '@angular/core';
import { FormControl, Validators} from '@angular/forms';

@Component({
  selector: 'app-retiro-pesos',
  templateUrl: './retiro-pesos.component.html',
  styleUrls: ['./retiro-pesos.component.css']
})
export class RetiroPesosComponent implements OnInit {

  saldo:number = 8000;

  retirar:boolean = false;

  retiroDinero = new FormControl('', [Validators.required] );

  constructor() { }

  ngOnInit(): void {
  }

  validarSaldo(){
    if (this.saldo == 0){
      alert("No tiene saldo suficiente")
    }else{
      this.retirar = true;
    }
  }

  get retiroField(){
    return this.retiroDinero;
  }

}
