import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-retiro-pesos',
  templateUrl: './retiro-pesos.component.html',
  styleUrls: ['./retiro-pesos.component.css']
})
export class RetiroPesosComponent implements OnInit {

  saldo:number = 400;

  retirar:boolean = false;

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

}
