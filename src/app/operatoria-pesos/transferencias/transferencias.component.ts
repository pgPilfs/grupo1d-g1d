import { Component, OnInit } from '@angular/core';
import { FormControl, Validators} from '@angular/forms';

@Component({
  selector: 'app-transferencias',
  templateUrl: './transferencias.component.html',
  styleUrls: ['./transferencias.component.css']
})
export class TransferenciasComponent implements OnInit {
  alias:string = "MANZANA.PELOTA.MANO"

  CBU = new FormControl('', [Validators.required,Validators.min(1), Validators.max(22)] );
  montoPesos = new FormControl(' ', [Validators.required, Validators.min(2), Validators.max(6) ] );
  montoDolares = new FormControl(' ', [Validators.required, Validators.min(2), Validators.max(4) ] );
  montoCripto = new FormControl(' ', [Validators.required, Validators.min(2), Validators.max(4) ] );
 


  constructor() { }

  ngOnInit(): void {
  }

  get CBUField(){
    return this.CBU;
  }
  get montoPesosField(){
    return this.montoPesos;
  }
  get montoDolaresField(){
    return this.montoDolares;
  }
  get montoCriptoField(){
    return this.montoCripto;
  }




}
